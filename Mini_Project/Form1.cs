namespace Mini_Project
{
    public partial class Form1 : Form
    {
        FirstFitAllocation firstfit = new FirstFitAllocation();

        public Form1()
        {
            InitializeComponent();
            InitializeDataGrids();
        }

        private void InitializeDataGrids()
        {
            // Configure the Allocation Results DataGridView
            AllocationGridView.ColumnCount = 2;
            AllocationGridView.Columns[0].Name = "Request (KB)";
            AllocationGridView.Columns[1].Name = "Block Allocated";
            AllocationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Configure the Remaining Blocks DataGridView
            RemainingBlocksGridView.ColumnCount = 2;
            RemainingBlocksGridView.Columns[0].Name = "Block Index";
            RemainingBlocksGridView.Columns[1].Name = "Remaining Size (KB)";
            RemainingBlocksGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn2Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Get block sizes and process sizes from the text boxes
                int[] blockSizes = BlockSize.Text.Split(',').Select(int.Parse).ToArray();
                int[] processSizes = ProcessSize.Text.Split(',').Select(int.Parse).ToArray();

                // Perform allocation using First Fit algorithm
                int[] allocation = firstfit.FirstFitAlgorithm(blockSizes, processSizes);

                // Display results in the DataGrids
                DisplayAllocationResults(blockSizes, processSizes, allocation);
                DisplayRemainingBlocks(blockSizes);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input! Please enter sizes separated by commas.");
            }
        }

        private void DisplayAllocationResults(int[] blocks, int[] requests, int[] allocation)
        {
            // Clear previous data
            AllocationGridView.Rows.Clear();

            // Add rows to the Allocation DataGridView
            for (int i = 0; i < requests.Length; i++)
            {
                string blockAllocated = allocation[i] != -1 ? $"Block {allocation[i] + 1}" : "Not Allocated";
                AllocationGridView.Rows.Add(requests[i], blockAllocated);
            }
        }

        private void DisplayRemainingBlocks(int[] blocks)
        {
            // Clear previous data
            RemainingBlocksGridView.Rows.Clear();

            // Add rows to the Remaining Blocks DataGridView
            for (int i = 0; i < blocks.Length; i++)
            {
                RemainingBlocksGridView.Rows.Add($"Block {i + 1}", blocks[i]);
            }
        }
    }
}
