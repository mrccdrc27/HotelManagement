using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using NOAKAY.CLASSES;
using NOAKAY.CLASSES.Joined_Tables;
using SQLCONNECTION;
using NOAKAY.DASHFORM;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardGenerateReport : Form
    {
        private Connection dbContext;
        private List<GuestRoomCategoryDTO> filteredGuest; // To store the filtered list of guest
        private List<Invoice> filteredRoom;

        public DashboardGenerateReport()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CurrentFilter(loadData());

        }

        // ====== GUEST DEMOGRAPHICS ======
        public List<GuestRoomCategoryDTO> loadData()
        {
            this.dbContext = new Connection();
            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new GuestRoomCategoryDTO
                               {
                                   RoomID = Room.RoomID,
                                   GuestID = Guest.GuestID,
                                   RoomNum = Room.RoomNum,
                                   // LastName = Guest.LastName!,
                                   // FirstName = Guest.FirstName!,
                                   // MiddleName = Guest.MiddleName!, // new
                                   fullname = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
                                   // Suffix = Guest.Suffix!, // new
                                   Address = Guest.Address!,
                                   Contact = Guest.Contact!,
                                   CheckIn = (DateTime)Guest.CheckIn!,
                                   CheckOut = (DateTime)Guest.CheckOut!,
                                   CategoryName = Category.CategoryName!,
                                   GuestStatus = $"{Guest.GuestStatus}",
                                   Status = $"{Guest.BookingStatus}",
                                   Email = Guest.Email!
                               };

            var combinedList = combinedData.ToList();
            List<GuestRoomCategoryDTO> filter = new List<GuestRoomCategoryDTO>();

            foreach (var item in combinedList)
            {
                if (item.GuestStatus == "0")
                {
                    item.GuestStatus = "Check In";
                    filter.Add(item);
                }
                else if (item.GuestStatus == "1")
                {
                    item.GuestStatus = "Check Out";
                    filter.Add(item);
                }
            }

            if (combinedList.Count == 0)
            {
                MessageBox.Show("No data loaded.");
            }

            this.dbContext.Database.CloseConnection();
            filteredGuest = filter;
            return filter.ToList();

        } // loadData2

        public void TimespanFilterGuest(List<GuestRoomCategoryDTO> guest, DateTime Start, DateTime End)
        {
            List<GuestRoomCategoryDTO> printlist = new List<GuestRoomCategoryDTO>();
            int standardCount = 0;
            int deluxeCount = 0;
            int suiteCount = 0;

            foreach (var item in guest)
            {
                if ((Start <= item.CheckIn && item.CheckOut <= End))
                {
                    printlist.Add(item);
                }
            }
            guestRoomCategoryDTOBindingSource.DataSource = printlist.ToList();
            filteredGuest = printlist;
            // roomGuestModelBindingSource.DataSource = printlist.ToList();
        }

        public void CurrentFilter(List<GuestRoomCategoryDTO> guest)
        {
            List<GuestRoomCategoryDTO> printlist = new List<GuestRoomCategoryDTO>();
            foreach (var item in guest)
            {
                if ((item.CheckIn >= DateTime.Now && item.CheckOut >= DateTime.Now) || (item.CheckIn <= DateTime.Now && item.CheckOut <= DateTime.Now))
                {
                    printlist.Add(item);
                }
            }
            guestRoomCategoryDTOBindingSource.DataSource = printlist.ToList();
            filteredGuest = printlist;
            // roomGuestModelBindingSource.DataSource = printlist.ToList();
        } // CurrentFilter

        private void btnFilterGuest_Click(object sender, EventArgs e)
        {
            TimespanFilterGuest(loadData(), dtpGuestStart.Value, dtpGuestEnd.Value);
        }

        private void btnPrintGuestReport_Click(object sender, EventArgs e)
        {
            if (filteredGuest == null || !filteredGuest.Any())
            {
                MessageBox.Show("No data to generate the report.");
                return;
            }

            DateTime startDate = dtpGuestStart.Value;
            DateTime endDate = dtpGuestEnd.Value;

            int? StandardCount = filteredGuest.Count(item => item.CategoryName == "Standard");
            int? DeluxeCount = filteredGuest.Count(item => item.CategoryName == "Deluxe");
            int? SuiteCount = filteredGuest.Count(item => item.CategoryName == "Suite");


            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "MonthlyRoomReport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    var logoPath = "C:\\Users\\abc\\Desktop\\Design Component\\DRIVE\\logo.png";

                    Document.Create(document =>
                    {
                        document.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(1, Unit.Centimetre);

                            // Row 1: Image, Title, Date Generated
                            page.Header().Element(container =>
                            {
                                container.Row(row =>
                                {
                                    row.ConstantItem(100).Image(logoPath, ImageScaling.FitArea); // Logo on the left

                                    row.RelativeItem().AlignCenter().Column(column =>
                                    {
                                        column.Item().Text("NOAKAY Guest Demographics")
                                              .FontFamily("Times New Roman")
                                              .Bold()
                                              .FontSize(24)
                                              .FontColor(Colors.Blue.Medium)
                                              .AlignCenter();
                                    });

                                    row.ConstantItem(100).AlignRight().Column(column =>
                                    {
                                        column.Item().Text($"Generated on: {DateTime.Now}")
                                              .FontFamily("Arial")
                                              .FontSize(12)
                                              .AlignRight();
                                    });
                                });
                            });

                            page.Content().Column(content =>
                            {
                                // Row 2: Date Time Frame
                                content.Item().PaddingTop(10).Text($"Timeframe: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}")
                                      .Bold()
                                      .FontFamily("Arial")
                                      .FontSize(12)
                                      .AlignCenter();

                                // Row 3: Table headers
                                content.Item().PaddingTop(10).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(); // Guest Name
                                        columns.RelativeColumn(); // Contact
                                        columns.RelativeColumn(); // Address
                                        columns.RelativeColumn(); // CheckIn Date
                                        columns.RelativeColumn(); // CheckOut Date
                                        columns.RelativeColumn(); // Room Num
                                        columns.RelativeColumn(); // Category
                                    });

                                    table.Header(header =>
                                    {
                                        header.Cell().Border(1).Padding(5).Text("Guest Name").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Contact").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Address").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Check-In Date").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Check-Out Date").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Room Num").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Category").Bold();
                                    });

                                    // Row 4: Table contents
                                    foreach (var item in filteredGuest)
                                    {
                                        table.Cell().Border(1).Padding(5).Text(item.fullname);
                                        table.Cell().Border(1).Padding(5).Text(item.Contact);
                                        table.Cell().Border(1).Padding(5).Text(item.Address);
                                        table.Cell().Border(1).Padding(5).Text(item.CheckIn.ToShortDateString() ?? string.Empty);
                                        table.Cell().Border(1).Padding(5).Text(item.CheckOut.ToShortDateString() ?? string.Empty);
                                        table.Cell().Border(1).Padding(5).Text(item.RoomNum.ToString());
                                        table.Cell().Border(1).Padding(5).Text(item.CategoryName.ToString());
                                    }
                                });

                                // Row 5: Guest category summary title
                                content.Item().PaddingTop(20).Text("Guest Summary")
                                      .FontFamily("Arial")
                                      .FontSize(14)
                                      .Bold()
                                      .AlignCenter();

                                // Row 6:
                                content.Item().PaddingTop(5).Text($"No. of Guest/s checked-in on Standard Room:  {StandardCount.ToString()}")
                                     .FontFamily("Arial")
                                     .FontSize(12)
                                     .AlignLeft();
                                // Row 7:
                                content.Item().PaddingTop(5).Text($"No. of Guest/s checked-in on Deluxe Room:  {DeluxeCount.ToString()}")
                                     .FontFamily("Arial")
                                     .FontSize(12)
                                     .AlignLeft();

                                // Row 8:
                                content.Item().PaddingTop(5).Text($"No. of Guest/s checked-in on Suite Room:  {SuiteCount.ToString()}")
                                     .FontFamily("Arial")
                                     .FontSize(12)
                                     .AlignLeft();


                                // HERE 
                                // ADD ANOTHER CONTENT

                            });
                        });
                    }).GeneratePdf(fileName);

                    MessageBox.Show($"PDF generated: {fileName}");
                } // if

            } // using
        } // btnPrintGuestReport


        // ====== ROOM REPORT ======
        public List<Invoice> loadData2()
        {
            this.dbContext = new Connection();
            var combinedData = from Guest in dbContext.GuestModels
                               join Room in dbContext.RoomModels
                               on Guest.RoomID equals Room.RoomID
                               join Category in dbContext.CategoryModels
                               on Room.CategoryId equals Category.CategoryID
                               select new Invoice
                               {
                                   fullName = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
                                   guestID = Guest.GuestID,
                                   checkIn = Guest.CheckIn,
                                   checkOut = Guest.CheckOut,
                                   gueststatus = $"{Guest.GuestStatus}",
                                   status = $"{Guest.BookingStatus}",
                                   price = CalculateTotalPrice(Guest.CheckIn, Guest.CheckOut, Category.basePrice),
                                   roomName = Room.RoomNum,
                                   categoryID = Room.CategoryId
                               };
            var combinedList = combinedData.ToList();
            List<Invoice> filter = new List<Invoice>();

            foreach (var item in combinedList)
            {
                if (item.gueststatus == "0")
                {
                    item.gueststatus = "Check In";
                    filter.Add(item);
                }
                else if (item.gueststatus == "1")
                {
                    item.gueststatus = "Check Out";
                    filter.Add(item);
                }
            }

            //if (combinedList.Count == 0)
            //{
            //    MessageBox.Show("No data loaded.");
            //}

            this.dbContext.Database.CloseConnection();
            filteredRoom = filter;
            return filter.ToList();

        } // loadData2

        private static decimal CalculateTotalPrice(DateTime? checkIn, DateTime? checkOut, int basePrice)
        {
            if (checkIn.HasValue && checkOut.HasValue)
            {
                TimeSpan totalDuration = checkOut.Value - checkIn.Value;
                int totalDays = totalDuration.Days + 1; // Include the check-out day
                return totalDays * basePrice;
            }
            return 0; // Handle the case where either check-in or check-out date is null
        }

        public void TimespanFilterRoom(List<Invoice> guest, DateTime Start, DateTime End)
        {
            List<Invoice> printlist = new List<Invoice>();


            foreach (var item in guest)
            {
                if ((Start <= item.checkIn && item.checkOut <= End))
                {
                    printlist.Add(item);
                }
            }
            // guestRoomCategoryDTOBindingSource.DataSource = printlist.ToList();
            invoiceBindingSource.DataSource = printlist;
            filteredRoom = printlist;
            // roomGuestModelBindingSource.DataSource = printlist.ToList();
        }

        public void CurrentFilter1(List<Invoice> guest)
        {
            List<Invoice> printlist = new();
            foreach (var item in guest)
            {
                if ((item.checkIn >= DateTime.Now && item.checkOut >= DateTime.Now) || (item.checkIn <= DateTime.Now && item.checkOut <= DateTime.Now))
                {
                    printlist.Add(item);
                }
            }

            // guestRoomCategoryDTOBindingSource.DataSource = printlist.ToList();
            invoiceBindingSource.DataSource = printlist;
            filteredRoom = printlist;
            // roomGuestModelBindingSource.DataSource = printlist.ToList();
        } // CurrentFilter

        private void btnFilterRoom_Click(object sender, EventArgs e)
        {
            TimespanFilterRoom(loadData2(), dtpRoomStart.Value, dtpRoomEnd.Value);
        }

        private void btnPrintRoomReport_Click(object sender, EventArgs e)
        {
            if(filteredRoom == null || !filteredRoom.Any())
            {
                MessageBox.Show("No data to generate the report.");
                return;
            }

            DateTime startDate = dtpRoomStart.Value;
            DateTime endDate = dtpRoomEnd.Value;

            // Calculate total price for all categories within the specified timeframe
            decimal? totalPrice = filteredRoom.Sum(item => item.price);
            decimal? standardTotalRevenue = filteredRoom.Where(item => item.roomName > 100 && item.roomName < 106).Sum(item => item.price);
            decimal? deluxeTotalRevenue = filteredRoom.Where(item => item.roomName > 105 && item.roomName < 111).Sum(item => item.price);
            decimal? suiteTotalRevenue = filteredRoom.Where(item => item.roomName >= 111).Sum(item => item.price);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";
                saveFileDialog.FileName = "MonthlyRoomReport.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveFileDialog.FileName;
                    var logoPath = "C:\\Users\\abc\\Desktop\\Design Component\\DRIVE\\logo.png";

                    Document.Create(document =>
                    {
                        document.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(1, Unit.Centimetre);

                            // Row 1: Image, Title, Date Generated
                            page.Header().Element(container =>
                            {
                                container.Row(row =>
                                {
                                    row.ConstantItem(100).Image(logoPath, ImageScaling.FitArea); // Logo on the left

                                    row.RelativeItem().AlignCenter().Column(column =>
                                    {
                                        column.Item().Text("NOAKAY Monthly Room Report")
                                              .FontFamily("Times New Roman")
                                              .Bold()
                                              .FontSize(24)
                                              .FontColor(Colors.Blue.Medium)
                                              .AlignCenter();
                                    });

                                    row.ConstantItem(100).AlignRight().Column(column =>
                                    {
                                        column.Item().Text($"Generated on: {DateTime.Now}")
                                              .FontFamily("Arial")
                                              .FontSize(12)
                                              .AlignRight();
                                    });
                                });
                            });

                            page.Content().Column(content =>
                            {
                                // Row 2: Date Time Frame
                                content.Item().PaddingTop(10).Text($"Timeframe: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}")
                                      .Bold()
                                      .FontFamily("Arial")
                                      .FontSize(12)
                                      .AlignCenter();

                                // Row 3: Table headers
                                content.Item().PaddingTop(10).Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn(); // Room Number
                                        columns.RelativeColumn(); // Guest Name
                                        columns.RelativeColumn(); // Guest Status
                                        columns.RelativeColumn(); // Check-In Date
                                        columns.RelativeColumn(); // Check-Out Date
                                        columns.RelativeColumn(); // Price
                                    });

                                    table.Header(header =>
                                    {
                                        header.Cell().Border(1).Padding(5).Text("Room Number").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Guest Name").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Guest Status").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Check-In Date").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Check-Out Date").Bold();
                                        header.Cell().Border(1).Padding(5).Text("Price").Bold();
                                    });

                                    // Row 4: Table contents
                                    foreach (var item in filteredRoom)
                                    {
                                        table.Cell().Border(1).Padding(5).Text(item.roomName);
                                        table.Cell().Border(1).Padding(5).Text(item.fullName);
                                        table.Cell().Border(1).Padding(5).Text(item.gueststatus);
                                        table.Cell().Border(1).Padding(5).Text(item.checkIn?.ToShortDateString() ?? string.Empty);
                                        table.Cell().Border(1).Padding(5).Text(item.checkOut?.ToShortDateString() ?? string.Empty);
                                        table.Cell().Border(1).Padding(5).Text(item.price.ToString());
                                    }
                                });

                                // Row 5: Room category summary title
                                content.Item().PaddingTop(20).Text("Room Category Summary")
                                      .FontFamily("Arial")
                                      .FontSize(14)
                                      .Bold()
                                      .AlignCenter();

                                // Row 6: Standard Room: Total Revenue
                                content.Item().PaddingTop(5).Text($"Standard Room: Total Revenue: {standardTotalRevenue.ToString()}")
                                      .FontFamily("Arial")
                                      .FontSize(12)
                                      .AlignLeft();

                                // Row 7: Deluxe Room: Total Revenue
                                content.Item().PaddingTop(5).Text($"Deluxe Room: Total Revenue: {deluxeTotalRevenue.ToString()}")
                                      .FontFamily("Arial")
                                      .FontSize(12)
                                      .AlignLeft();

                                // Row 8: Suite Room: Total Revenue
                                content.Item().PaddingTop(5).Text($"Suite Room: Total Revenue: {suiteTotalRevenue.ToString()}")
                                      .FontFamily("Arial")
                                      .FontSize(12)
                                      .AlignLeft();

                                // Row 9: Total Revenue
                                content.Item().PaddingTop(5).Text($"Total Revenue: {totalPrice.ToString()}")
                                      .FontFamily("Arial")
                                      .FontSize(12)
                                      .Bold()
                                      .AlignLeft();
                            });
                        });
                    }).GeneratePdf(fileName);

                    MessageBox.Show($"PDF generated: {fileName}");
                } // if
            } // using 
        }
    }
}
