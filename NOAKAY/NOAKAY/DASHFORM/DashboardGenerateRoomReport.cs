using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NOAKAY.CLASSES.Joined_Tables;
using SQLCONNECTION;
using NOAKAY.CLASSES;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace NOAKAY.DASHFORM
{
    public partial class DashboardGenerateRoomReport : Form
    {
        private Connection dbContext;
        private List<Invoice> allInvoices; // To store the original list of invoices
        private List<Invoice> filteredInvoices; // To store the filtered list of invoices
        private List<GuestRoomCategoryDTO> allGuest; // To store the original list of guest
        private List<GuestRoomCategoryDTO> filteredGuest; // To store the filtered list of guest

        public DashboardGenerateRoomReport()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAndDisplayData();
        }

        private void LoadAndDisplayData()
        {
            allInvoices = loadData1();
            filteredInvoices = new List<Invoice>(allInvoices); // Initialize with all invoices
            invoiceBindingSource.DataSource = filteredInvoices;
            dgvRoom.Refresh();

            allGuest = loadData2();
            filteredGuest = new List<GuestRoomCategoryDTO>(allGuest);
            guestRoomCategoryDTOBindingSource.DataSource = filteredGuest;
            dgvGuest.Refresh();
        }

        // ====== GUEST DEMOGRAPHICS ======
        public List<GuestRoomCategoryDTO> loadData2()
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
                                   LastName = Guest.LastName!,
                                   FirstName = Guest.FirstName!,
                                   MiddleName = Guest.MiddleName!, // new
                                   Suffix = Guest.Suffix!, // new
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

            return filter.ToList();

        } // loadData2

        // ====== GUEST DEMOGRAPHICS ======


        // ====== ROOM REPORT ======

        public List<Invoice> loadData1()
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

            if (combinedList.Count == 0)
            {
                MessageBox.Show("No data loaded.");
            }

            return filter.ToList();
        }

        public void TimespanFilterRoom(List<Invoice> roomGuest, DateTime Start, DateTime End)
        {
            filteredInvoices = new List<Invoice>();
            List<int> roomlist = new List<int>();
            int standardCount = 0;
            int deluxeCount = 0;
            int suiteCount = 0;
            float standardTotalRevenue = 0;
            float deluxeTotalRevenue = 0;
            float suiteTotalRevenue = 0;
            float totalRevenue = 0;

            foreach (var item in roomGuest)
            {
                if ((Start <= item.checkIn && item.checkOut <= End))
                {
                    // if (item.roomName > 100 && item.roomName < 106)
                    if (item.categoryID == 1)
                    {
                        standardCount++;
                        standardTotalRevenue += (float)item.price;
                        filteredInvoices.Add(item);
                    }
                    else if (item.categoryID == 2)
                    {
                        deluxeCount++;
                        deluxeTotalRevenue += (float)item.price;
                        filteredInvoices.Add(item);
                    }
                    else
                    {
                        suiteCount++;
                        suiteTotalRevenue += (float)item.price;
                        filteredInvoices.Add(item);
                    }

                    totalRevenue = standardCount + deluxeCount + suiteCount;
                }
            }

            lblTotalStandard.Text = standardTotalRevenue.ToString();
            lblTotalDeluxe.Text = deluxeTotalRevenue.ToString();
            lblTotalSuite.Text = suiteTotalRevenue.ToString();
            lblTotal.Text = totalRevenue.ToString();
            invoiceBindingSource.DataSource = filteredInvoices;
            guestRoomCategoryDTOBindingSource.DataSource = filteredGuest;
            dgvGuest.Refresh();
            dgvRoom.Refresh();
        }

        public void TimespanFilterGuest(List<GuestRoomCategoryDTO> guest, DateTime Start, DateTime End)
        {
            filteredGuest = new List<GuestRoomCategoryDTO>();
            List<int> guestlist = new List<int>();

            foreach (var item in guest)
            {
                if ((Start <= item.CheckIn && item.CheckOut <= End))
                {
                    filteredGuest.Add(item);
                }

            }
        }

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

        private void btnFilterRoom_Click(object sender, EventArgs e)
        {
            TimespanFilterRoom(allInvoices, dtpStart.Value, dtpEnd.Value);
        }

        private void btnPrintRoomReport_Click(object sender, EventArgs e)
        {
            if (filteredInvoices == null || !filteredInvoices.Any())
            {
                MessageBox.Show("No data to generate the report.");
                return;
            }

            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            // Calculate total price for all categories within the specified timeframe
            decimal? totalPrice = filteredInvoices.Sum(item => item.price);
            decimal? standardTotalRevenue = filteredInvoices.Where(item => item.roomName > 100 && item.roomName < 106).Sum(item => item.price);
            decimal? deluxeTotalRevenue = filteredInvoices.Where(item => item.roomName > 105 && item.roomName < 111).Sum(item => item.price);
            decimal? suiteTotalRevenue = filteredInvoices.Where(item => item.roomName >= 111).Sum(item => item.price);

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
                                    foreach (var item in filteredInvoices)
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
        } // btnPrintRoomReport

        private void btnFilterGuest_Click(object sender, EventArgs e)
        {
            TimespanFilterGuest(allGuest, dtpStartGuest.Value, dtpEndGuest.Value);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        // ====== ROOM REPORT ======

    }
}
