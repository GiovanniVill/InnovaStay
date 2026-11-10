using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Controller;
using Model;

namespace UI
{
    public partial class RoomMaintenanceForm : Form
    {
        private readonly RoomController _roomController;
        private readonly string _currentUserRole = "Admin";
        private int _selectedRoomId = 0;

        // In-memory cache for fast search filtering
        private List<RoomModel> _allRooms = new List<RoomModel>();

        // InnovaStay Theme Colors
        private readonly Color OliveGold = Color.FromArgb(184, 172, 102);
        private readonly Color OliveHover = Color.FromArgb(160, 150, 85);
        private readonly Color SidebarCream = Color.FromArgb(238, 236, 203);
        private readonly Color TableHeaderNavy = Color.FromArgb(20, 26, 40);
        private readonly Color SelectionTan = Color.FromArgb(226, 222, 190);
        private readonly Color DangerRed = Color.FromArgb(220, 53, 69);
        private readonly Color DangerHover = Color.FromArgb(200, 35, 51);
        private readonly Color NeutralGray = Color.FromArgb(160, 165, 170);

        // Dynamic control references
        private TextBox? _txtRoomNum;
        private ComboBox? _cmbType;
        private TextBox? _txtPrice;
        private ComboBox? _cmbRate;
        private ComboBox? _cmbStatus;
        private DataGridView? _grid;
        private Button? _btnCreate;
        private Button? _btnEdit;
        private Button? _btnView;
        private Button? _btnDeactivate;
        private Panel? _leftPanel;

        // Search Bar Controls
        private Label? _lblSearch;
        private TextBox? _txtSearch;
        private Button? _btnClearSearch;

        public RoomMaintenanceForm()
        {
            InitializeComponent();
            _roomController = new RoomController();
        }

        private void DesignRoomMaintenanceForm_Load_1(object sender, EventArgs e)
        {
            FindFormControls();
            ApplyInnovaStayStyling();
            BuildSearchBar();
            HookEvents();
            RefreshGridAndInputs();
        }

        private void FindFormControls()
        {
            foreach (Control c in GetAllControls(this))
            {
                string name = c.Name.ToLower();

                if (c is Panel p && (name.Contains("left") || name.Contains("input") || p.Width < 350))
                {
                    _leftPanel = p;
                }
                else if (c is TextBox tb)
                {
                    if (name.Contains("number") || name.Contains("num") || name.Contains("roomno"))
                        _txtRoomNum = tb;
                    else if (name.Contains("rate") || name.Contains("price"))
                        _txtPrice = tb;
                }
                else if (c is ComboBox cb)
                {
                    if (name.Contains("type"))
                        _cmbType = cb;
                    else if (name.Contains("rate"))
                        _cmbRate = cb;
                    else if (name.Contains("status"))
                        _cmbStatus = cb;
                }
                else if (c is DataGridView dgv)
                {
                    _grid = dgv;
                }
                else if (c is Button btn)
                {
                    if (name.Contains("add") || name.Contains("create"))
                        _btnCreate = btn;
                    else if (name.Contains("edit") || name.Contains("update"))
                        _btnEdit = btn;
                    else if (name.Contains("view") || name.Contains("info"))
                        _btnView = btn;
                    else if (name.Contains("deactivate") || name.Contains("delete"))
                        _btnDeactivate = btn;
                }
            }

            if (_cmbType != null && _cmbType.Items.Count == 0)
            {
                _cmbType.Items.AddRange(new object[] { "Single", "Double", "Deluxe", "Suite" });
            }

            if (_cmbStatus != null && _cmbStatus.Items.Count == 0)
            {
                _cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Reserved", "Maintenance" });
            }
        }

        private void ApplyInnovaStayStyling()
        {
            this.BackColor = SidebarCream;
            this.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            if (_leftPanel != null)
            {
                _leftPanel.BackColor = SidebarCream;
            }

            if (_txtRoomNum != null)
            {
                _txtRoomNum.Font = new Font("Segoe UI", 10F);
                _txtRoomNum.BorderStyle = BorderStyle.FixedSingle;
            }

            if (_txtPrice != null)
            {
                _txtPrice.Font = new Font("Segoe UI", 10F);
                _txtPrice.BorderStyle = BorderStyle.FixedSingle;
            }

            Control[] combos = { _cmbType!, _cmbRate!, _cmbStatus! };
            foreach (var cb in combos.Where(c => c != null))
            {
                if (cb is ComboBox combo)
                {
                    combo.Font = new Font("Segoe UI", 10F);
                    combo.FlatStyle = FlatStyle.Flat;
                }
            }

            Button[] primaryBtns = { _btnCreate!, _btnEdit!, _btnView! };
            foreach (var btn in primaryBtns.Where(b => b != null))
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = OliveGold;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.MouseEnter += (s, e) => btn.BackColor = OliveHover;
                btn.MouseLeave += (s, e) => btn.BackColor = OliveGold;
            }

            if (_btnDeactivate != null)
            {
                _btnDeactivate.FlatStyle = FlatStyle.Flat;
                _btnDeactivate.FlatAppearance.BorderSize = 0;
                _btnDeactivate.BackColor = DangerRed;
                _btnDeactivate.ForeColor = Color.White;
                _btnDeactivate.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                _btnDeactivate.Cursor = Cursors.Hand;
                _btnDeactivate.MouseEnter += (s, e) => _btnDeactivate.BackColor = DangerHover;
                _btnDeactivate.MouseLeave += (s, e) => _btnDeactivate.BackColor = DangerRed;
            }

            if (_grid != null)
            {
                _grid.BackgroundColor = Color.White;
                _grid.BorderStyle = BorderStyle.None;
                _grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                _grid.GridColor = Color.FromArgb(230, 233, 236);
                _grid.RowHeadersVisible = false;
                _grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _grid.MultiSelect = false;
                _grid.AllowUserToResizeRows = false;
                _grid.RowTemplate.Height = 36;
                _grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                _grid.EnableHeadersVisualStyles = false;
                _grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                _grid.ColumnHeadersHeight = 38;
                _grid.ColumnHeadersDefaultCellStyle.BackColor = TableHeaderNavy;
                _grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                _grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = TableHeaderNavy;
                _grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                _grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

                _grid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
                _grid.DefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40);
                _grid.DefaultCellStyle.SelectionBackColor = SelectionTan;
                _grid.DefaultCellStyle.SelectionForeColor = TableHeaderNavy;
                _grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 246);
                _grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = SelectionTan;
                _grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = TableHeaderNavy;
            }
        }

        private void BuildSearchBar()
        {
            if (_grid == null) return;

            int posY = Math.Max(10, _grid.Top - 34);
            int startX = Math.Max(20, _grid.Right - 360);

            _lblSearch = new Label
            {
                Text = "Search:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = TableHeaderNavy,
                AutoSize = true,
                Location = new Point(startX - 58, posY + 4),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            _txtSearch = new TextBox
            {
                Name = "txtSearchRooms",
                PlaceholderText = "Room #, type, status...",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                Size = new Size(230, 26),
                Location = new Point(startX, posY),
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            _btnClearSearch = new Button
            {
                Name = "btnClearSearchRooms",
                Text = "Clear",
                Size = new Size(65, 26),
                Location = new Point(startX + 236, posY - 1),
                FlatStyle = FlatStyle.Flat,
                BackColor = OliveGold,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            _btnClearSearch.FlatAppearance.BorderSize = 0;
            _btnClearSearch.MouseEnter += (s, e) => _btnClearSearch.BackColor = OliveHover;
            _btnClearSearch.MouseLeave += (s, e) => _btnClearSearch.BackColor = OliveGold;

            _txtSearch.TextChanged += (s, e) => ApplySearchFilter();

            _btnClearSearch.Click += (s, e) =>
            {
                if (_txtSearch != null)
                {
                    _txtSearch.Text = string.Empty;
                }
                ApplySearchFilter();
                ResetToAutomatedDefaults();
            };

            Control parent = _grid.Parent ?? this;
            parent.Controls.Add(_lblSearch);
            parent.Controls.Add(_txtSearch);
            parent.Controls.Add(_btnClearSearch);
            _lblSearch.BringToFront();
            _txtSearch.BringToFront();
            _btnClearSearch.BringToFront();
        }

        private void ApplySearchFilter()
        {
            if (_grid == null) return;

            string query = _txtSearch?.Text.Trim().ToLower() ?? "";

            if (string.IsNullOrEmpty(query))
            {
                _grid.DataSource = null;
                _grid.DataSource = _allRooms;
            }
            else
            {
                var filtered = _allRooms.Where(r =>
                    (r.RoomNumber != null && r.RoomNumber.ToLower().Contains(query)) ||
                    (r.RoomType != null && r.RoomType.ToLower().Contains(query)) ||
                    (r.Status != null && r.Status.ToLower().Contains(query))
                ).ToList();

                _grid.DataSource = null;
                _grid.DataSource = filtered;
            }

            FormatColumns();
        }

        private void FormatColumns()
        {
            if (_grid == null || _grid.Columns.Count == 0) return;

            if (_grid.Columns.Contains("PricePerNight"))
                _grid.Columns["PricePerNight"].DefaultCellStyle.Format = "PHP #,##0.00";

            if (_grid.Columns.Contains("CreatedAt"))
                _grid.Columns["CreatedAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";

            if (_grid.Columns.Contains("UpdatedAt"))
                _grid.Columns["UpdatedAt"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
        }

        private System.Collections.Generic.IEnumerable<Control> GetAllControls(Control root)
        {
            foreach (Control c in root.Controls)
            {
                yield return c;
                foreach (Control child in GetAllControls(c))
                {
                    yield return child;
                }
            }
        }

        private void HookEvents()
        {
            if (_grid != null)
            {
                _grid.CellClick -= Grid_CellClick;
                _grid.CellClick += Grid_CellClick;

                // Clicking empty gray space inside grid deselects and resets to Add mode
                _grid.MouseDown += (s, e) =>
                {
                    var hit = _grid.HitTest(e.X, e.Y);
                    if (hit.Type == DataGridViewHitTestType.None)
                    {
                        ResetToAutomatedDefaults();
                    }
                };
            }

            // Clicking outside inputs resets back to Add mode
            this.Click += (s, e) => ResetToAutomatedDefaults();
            if (_leftPanel != null)
            {
                _leftPanel.Click += (s, e) => ResetToAutomatedDefaults();
            }

            // Sync type changes to standard base rates
            if (_cmbType != null)
            {
                _cmbType.SelectedIndexChanged += (s, e) =>
                {
                    if (_selectedRoomId == 0 && _txtPrice != null)
                    {
                        string selected = _cmbType.SelectedItem?.ToString() ?? "";
                        if (selected == "Single") _txtPrice.Text = "1500.00";
                        else if (selected == "Double") _txtPrice.Text = "2500.00";
                        else if (selected == "Deluxe") _txtPrice.Text = "3500.00";
                        else if (selected == "Suite") _txtPrice.Text = "5000.00";
                    }
                };
            }
        }

        private void ResetToAutomatedDefaults()
        {
            _selectedRoomId = 0;

            if (_txtRoomNum != null)
            {
                _txtRoomNum.Text = _roomController.GetNextRoomNumber();
                _txtRoomNum.ReadOnly = true;
            }

            if (_cmbStatus != null)
            {
                _cmbStatus.SelectedItem = "Available";
                _cmbStatus.Enabled = false;
            }

            if (_cmbType != null && _cmbType.SelectedIndex < 0 && _cmbType.Items.Count > 0)
            {
                _cmbType.SelectedIndex = 0;
            }

            if (_txtPrice != null)
            {
                _txtPrice.Text = "1500.00";
            }

            if (_btnCreate != null) _btnCreate.Enabled = true;
            if (_grid != null) _grid.ClearSelection();
        }

        private void RefreshGridAndInputs()
        {
            _allRooms = _roomController.GetAllRooms() ?? new List<RoomModel>();
            ApplySearchFilter();
            ResetToAutomatedDefaults();
        }

        private void cmbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cmbRate?.SelectedItem != null && _txtPrice != null)
            {
                _txtPrice.Text = _cmbRate.SelectedItem.ToString();
            }
        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {
            if (_cmbType?.SelectedItem == null)
            {
                MessageBox.Show("Please select a room type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rateText = _txtPrice?.Text.Trim() ?? _cmbRate?.SelectedItem?.ToString() ?? "0";
            if (!decimal.TryParse(rateText, out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Please enter a valid price per night greater than 0.00.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string roomNum = !string.IsNullOrWhiteSpace(_txtRoomNum?.Text)
                ? _txtRoomNum.Text.Trim()
                : _roomController.GetNextRoomNumber();

            int floor = 1;
            if (roomNum.Length >= 2 && int.TryParse(roomNum.Substring(0, roomNum.Length - 2), out int f))
            {
                floor = f;
            }

            var room = new RoomModel
            {
                RoomNumber = roomNum,
                RoomType = _cmbType.SelectedItem.ToString(),
                PricePerNight = rate,
                Status = "Available",
                Floor = floor
            };

            var (success, message) = _roomController.AddRoom(room, _currentUserRole);
            MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (success)
            {
                RefreshGridAndInputs();
            }
        }

        private void btnEditRoom_Click_1(object sender, EventArgs e)
        {
            {
                var grid = _grid ?? (this.Controls.Find("dgvRooms", true).FirstOrDefault() as DataGridView);

                if (grid == null || grid.SelectedRows.Count == 0 || _selectedRoomId <= 0)
                {
                    MessageBox.Show("Please select a room from the list to edit.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var row = grid.SelectedRows[0];

                // Read values using either direct object binding or column lookups
                var boundRoom = row.DataBoundItem as RoomModel;

                int roomId = boundRoom?.RoomId ?? _selectedRoomId;
                string roomNumber = boundRoom?.RoomNumber ?? row.Cells["RoomNumber"]?.Value?.ToString() ?? _txtRoomNum?.Text ?? "";
                string roomType = boundRoom?.RoomType ?? row.Cells["RoomType"]?.Value?.ToString() ?? _cmbType?.SelectedItem?.ToString() ?? "Standard";
                decimal price = boundRoom?.PricePerNight ?? (decimal.TryParse(row.Cells["PricePerNight"]?.Value?.ToString(), out decimal p) ? p : 0m);
                string status = boundRoom?.Status ?? row.Cells["Status"]?.Value?.ToString() ?? _cmbStatus?.SelectedItem?.ToString() ?? "Available";

                using var editModal = new EditRoomForm(roomId, roomNumber, roomType, price, status);
                if (editModal.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshGridAndInputs();
                }
            }
        }
        private void btnDeactivateRoom_Click_1(object sender, EventArgs e)
        {
            if (_selectedRoomId <= 0)
            {
                MessageBox.Show("Please select a room to deactivate.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Are you sure you want to deactivate room {_txtRoomNum?.Text}?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var (success, message) = _roomController.DeleteRoom(_selectedRoomId, _currentUserRole);
                MessageBox.Show(message, success ? "Success" : "Error", MessageBoxButtons.OK,
                    success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

                if (success)
                {
                    RefreshGridAndInputs();
                }
            }
        }

        private void btnViewRoom_Click_1(object sender, EventArgs e)
        {
            if (_selectedRoomId <= 0)
            {
                MessageBox.Show("Please select a room from the list first.", "Select Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow? selectedRow = null;
            if (_grid != null && _grid.CurrentRow != null && _grid.CurrentRow.Index >= 0)
            {
                selectedRow = _grid.CurrentRow;
            }

            var selectedRoom = new RoomModel
            {
                RoomId = _selectedRoomId,
                RoomNumber = selectedRow?.Cells["RoomNumber"]?.Value?.ToString() ?? _txtRoomNum?.Text ?? "",
                RoomType = selectedRow?.Cells["RoomType"]?.Value?.ToString() ?? _cmbType?.SelectedItem?.ToString() ?? "",
                PricePerNight = decimal.TryParse(selectedRow?.Cells["PricePerNight"]?.Value?.ToString(), out decimal p) ? p : 0m,
                Status = selectedRow?.Cells["Status"]?.Value?.ToString() ?? _cmbStatus?.SelectedItem?.ToString() ?? "Available",
                Floor = int.TryParse(selectedRow?.Cells["Floor"]?.Value?.ToString(), out int fl) ? fl : 1
            };

            try
            {
                var targetType = typeof(RoomInfo);
                var ctor = targetType.GetConstructor(new[] { typeof(RoomModel) });

                Form infoForm = (ctor != null)
                    ? (Form)Activator.CreateInstance(typeof(RoomInfo), selectedRoom)!
                    : (Form)Activator.CreateInstance(typeof(RoomInfo))!;

                using (infoForm)
                {
                    infoForm.StartPosition = FormStartPosition.CenterParent;
                    infoForm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Room Info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Grid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _grid == null) return;

            var row = _grid.Rows[e.RowIndex];
            _selectedRoomId = Convert.ToInt32(row.Cells["RoomId"].Value);

            if (_txtRoomNum != null)
            {
                _txtRoomNum.Text = row.Cells["RoomNumber"]?.Value?.ToString() ?? "";
                _txtRoomNum.ReadOnly = true;
            }

            if (_cmbType != null)
                _cmbType.SelectedItem = row.Cells["RoomType"]?.Value?.ToString() ?? "";

            string priceVal = row.Cells["PricePerNight"]?.Value?.ToString() ?? "";
            if (_txtPrice != null)
                _txtPrice.Text = priceVal;
            if (_cmbRate != null)
                _cmbRate.SelectedItem = priceVal;

            if (_cmbStatus != null)
            {
                _cmbStatus.Enabled = true;
                _cmbStatus.SelectedItem = row.Cells["Status"]?.Value?.ToString() ?? "Available";
            }

            if (_btnCreate != null) _btnCreate.Enabled = false;
        }
    }
}