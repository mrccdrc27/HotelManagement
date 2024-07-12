//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Windows.Forms;
//using NOAKAY.CLASSES.Joined_Tables;
//using SQLCONNECTION;
//using NOAKAY.CLASSES;
//using QuestPDF.Fluent;
//using QuestPDF.Helpers;
//using QuestPDF.Infrastructure;

//namespace NOAKAY.DASHFORM
//{
//    public partial class DashboardGenerateRoomReport : Form
//    {
//        private Connection dbContext;
//        private List<Invoice> allInvoices; // To store the original list of invoices
//        private List<Invoice> filteredInvoices; // To store the filtered list of invoices

//        public DashboardGenerateRoomReport()
//        {
//            InitializeComponent();
//        }

//        protected override void OnLoad(EventArgs e)
//        {
//            base.OnLoad(e);
//            LoadAndDisplayData();
//        }

//        private void LoadAndDisplayData()
//        {
//            allInvoices = loadData1();
//            filteredInvoices = new List<Invoice>(allInvoices); // Initialize with all invoices
//            invoiceBindingSource.DataSource = filteredInvoices;
//            dgvRoom.Refresh();
//        }

//        public List<Invoice> loadData1()
//        {
//            this.dbContext = new Connection();
//            var combinedData = from Guest in dbContext.GuestModels
//                               join Room in dbContext.RoomModels
//                               on Guest.RoomID equals Room.RoomID
//                               join Category in dbContext.CategoryModels
//                               on Room.CategoryId equals Category.CategoryID
//                               select new Invoice
//                               {
//                                   fullName = $"{Guest.FirstName} {Guest.MiddleName} {Guest.LastName} {Guest.Suffix}",
//                                   guestID = Guest.GuestID,
//                                   checkIn = Guest.CheckIn,
//                                   checkOut = Guest.CheckOut,
//                                   gueststatus = $"{Guest.GuestStatus}",
//                                   status = $"{Guest.BookingStatus}",
//                                   price = CalculateTotalPrice(Guest.CheckIn, Guest.CheckOut, Category.basePrice),
//                                   roomName = Room.RoomNum,
//                               };

//            var combinedList = combinedData.ToList();
//            List<Invoice> filter = new List<Invoice>();

//            foreach (var item in combinedList)
//            {
//                if (item.gueststatus == "0")
//                {
//                    item.gueststatus = "Check In";
//                    filter.Add(item);
//                }
//                else if (item.gueststatus == "1")
//                {
//                    item.gueststatus = "Check Out";
//                    filter.Add(item);
//                }
//            }

//            if (combinedList.Count == 0)
//            {
//                MessageBox.Show("No data loaded.");
//            }

//            return filter.ToList();
//        }

//        public void TimespanFilter(List<Invoice> roomGuest, DateTime Start, DateTime End)
//        {
//            filteredInvoices = new List<Invoice>();
//            List<int> roomlist = new List<int>();
//            int standardCount = 0;
//            int deluxeCount = 0;
//            int suiteCount = 0;
//            float standardTotalRevenue = 0;
//            float deluxeTotalRevenue = 0;
//            float suiteTotalRevenue = 0;
//            float totalRevenue = 0;

//            foreach (var item in roomGuest)
//            {
//                if ((Start <= item.checkIn && item.checkOut <= End))
//                {
//                    if (item.roomName > 100 && item.roomName < 106)
//                    {
//                        standardCount++;
//                        standardTotalRevenue += (float)item.price;
//                        filteredInvoices.Add(item);
//                    }
//                    else if (item.roomName > 105 && item.roomName < 111)
//                    {
//                        deluxeCount++;
//                        deluxeTotalRevenue += (float)item.price;
//                        filteredInvoices.Add(item);
//                    }
//                    else
//                    {
//                        suiteCount++;
//                        suiteTotalRevenue += (float)item.price;
//                        filteredInvoices.Add(item);
//                    }
//                    totalRevenue = standardCount + deluxeCount + suiteCount;
//                }
//            }

//            lblTotalStandard.Text = standardTotalRevenue.ToString();
//            lblTotalDeluxe.Text = deluxeTotalRevenue.ToString();
//            lblTotalSuite.Text = suiteTotalRevenue.ToString();
//            lblTotal.Text = totalRevenue.ToString();
//            invoiceBindingSource.DataSource = filteredInvoices;
//            dgvRoom.Refresh();
//        }

//        private static decimal CalculateTotalPrice(DateTime? checkIn, DateTime? checkOut, int basePrice)
//        {
//            if (checkIn.HasValue && checkOut.HasValue)
//            {
//                TimeSpan totalDuration = checkOut.Value - checkIn.Value;
//                int totalDays = totalDuration.Days + 1; // Include the check-out day
//                return totalDays * basePrice;
//            }
//            return 0; // Handle the case where either check-in or check-out date is null
//        }

//        private void btnFilterRoom_Click(object sender, EventArgs e)
//        {
//            TimespanFilter(allInvoices, dtpStart.Value, dtpEnd.Value);
//        }

//        private void btnPrintRoomReport_Click(object sender, EventArgs e)
//        {
//            if (filteredInvoices == null || !filteredInvoices.Any())
//            {
//                MessageBox.Show("No data to generate the report.");
//                return;
//            }

//            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
//            {
//                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
//                saveFileDialog.Title = "Save PDF File";
//                saveFileDialog.FileName = "MonthlyRoomReport.pdf";

//                if (saveFileDialog.ShowDialog() == DialogResult.OK)
//                {
//                    var fileName = saveFileDialog.FileName;
//                    var logoPath = "C:\\Users\\abc\\Desktop\\Design Component\\DRIVE\\logo.png";

//                    Document.Create(document =>
//                    {
//                        document.Page(page =>
//                        {
//                            page.Size(PageSizes.A4);
//                            page.Margin(1, Unit.Centimetre);
//                            page.Header().Element(container =>
//                            {
//                                container.Row(row =>
//                                {
//                                    row.ConstantItem(100).Image(logoPath, ImageScaling.FitArea); // Logo on the left

//                                    row.RelativeItem().AlignCenter().Column(column =>
//                                    {
//                                        column.Item().Text("NOAKAY\n Monthly Room Report")
//                                              .FontFamily("Times New Roman")
//                                              .Bold()
//                                              .FontSize(24)
//                                              .FontColor(Colors.Blue.Medium)
//                                              .AlignCenter();
//                                    });

//                                    row.ConstantItem(100).AlignRight().Column(column =>
//                                    {
//                                        column.Item().Text($"Generated on: {DateTime.Now}")
//                                              .FontFamily("Arial")
//                                              .FontSize(12)
//                                              .AlignRight();
//                                    });
//                                });
//                            });
//                            page.Content().Table(table =>
//                            {
//                                table.ColumnsDefinition(columns =>
//                                {
//                                    columns.RelativeColumn(); // Room Number
//                                    columns.RelativeColumn(); // Guest Name
//                                    columns.RelativeColumn(); // Check-In Date
//                                    columns.RelativeColumn(); // Check-Out Date
//                                    columns.RelativeColumn(); // Status
//                                    columns.RelativeColumn(); // Status
//                                });

//                                table.Header(header =>
//                                {
//                                    header.Cell().Text("Room Number").Bold();
//                                    header.Cell().Text("Guest Name").Bold();
//                                    header.Cell().Text("Guest Status").Bold();
//                                    header.Cell().Text("Check-In Date").Bold();
//                                    header.Cell().Text("Check-Out Date").Bold();
//                                    header.Cell().Text("Price").Bold();
//                                });

//                                foreach (var item in filteredInvoices)
//                                {
//                                    //table.Cell().Element(cell => cell.Text(item.roomName));
//                                    //table.Cell().Element(cell => cell.Text(item.fullName));
//                                    //table.Cell().Element(cell => cell.Text(item.gueststatus));
//                                    //table.Cell().Element(cell => cell.Text(item.checkIn?.ToShortDateString() ?? string.Empty));
//                                    //table.Cell().Element(cell => cell.Text(item.checkOut?.ToShortDateString() ?? string.Empty));
//                                    //table.Cell().Element(cell => cell.Text(item.price.ToString()));

//                                    table.Cell().Element(CellStyle).Text(item.roomName);
//                                    table.Cell().Element(CellStyle).Text(item.fullName);
//                                    table.Cell().Element(CellStyle).Text(item.gueststatus);
//                                    table.Cell().Element(CellStyle).Text(item.checkIn?.ToShortDateString() ?? string.Empty);
//                                    table.Cell().Element(CellStyle).Text(item.checkOut?.ToShortDateString() ?? string.Empty);
//                                    table.Cell().Element(CellStyle).Text(item.price.ToString());
//                                }
//                            });
//                        });
//                    }).GeneratePdf(fileName);

//                    MessageBox.Show($"PDF generated: {fileName}");
//                } // if
//            } // using 
//        } // btnPrintRoomReport

//        private IContainer CellStyle(IContainer container)
//        {
//            return container.Border(1).Padding(5);
//        }
//    }
//}
