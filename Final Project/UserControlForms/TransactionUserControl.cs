using Final_Project.BussinessLogic.Interfaces;
using Final_Project.BussinessLogic.Services;
using Final_Project.DataAccess;
using Final_Project.DataAccess.Repositories;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Final_Project.UserControlForms
{
    public partial class TransactionUserControl : UserControl
    {
        private InventoryLogService inventoryLogService;
        
        public TransactionUserControl()
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
            txn_datagridview.ReadOnly = true;
            txn_datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txn_datagridview.AllowUserToAddRows = false;

            DataTable logs = inventoryLogService.GetInventoryLogsForGrid();
            txn_datagridview.DataSource = logs;
        }
        public void LoadService()
        {
            var dbContext = new DBContext();
            var repository = new InventoryLogRepository(dbContext);
            inventoryLogService = new InventoryLogService(repository);
        }
    }
}
