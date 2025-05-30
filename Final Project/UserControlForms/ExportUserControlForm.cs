using Final_Project.BussinessLogic.Services;
using Final_Project.DataAccess;
using Final_Project.DataAccess.Repositories;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace Final_Project.UserControlForms
{
    public partial class ExportUserControlForm : UserControl
    {
        private ExportLogService exportLogService;

        public ExportUserControlForm()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                LoadService();
                // Khởi tạo DataGridView
                DisplayDataGridView();
            }
        }

        public void DisplayDataGridView()
        {
            txn_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Cấu hình DataGridView
            txn_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Cột tự động điều chỉnh để lấp đầy
            txn_datagridview.ReadOnly = true; // Chỉ cho phép xem
            txn_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn toàn bộ hàng
            txn_datagridview.AllowUserToAddRows = false; // Không cho phép thêm hàng mới

            // Gán dữ liệu
            DataTable logs = exportLogService.GetInventoryLogsForGrid();
            txn_datagridview.DataSource = logs;

            // Ẩn cột Old Quantity
            txn_datagridview.Columns["Old Quantity"].Visible = false;
        }
        public void RefreshData()
        {
            DisplayDataGridView();
        }
        public void LoadService()
        {
            var dbContext = new DBContext();
            var repository = new ExportLogRepository(dbContext);
            exportLogService = new ExportLogService(repository);
        }
    }
}
