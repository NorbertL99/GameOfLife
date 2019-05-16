// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

using System;
using System.Drawing;
using System.Windows.Forms;
using Game_Of_Life.Interfaces;
using Game_Of_Life.Classes;

namespace Game_Of_Life
{
    public partial class MainWindow : Form
    {
        #region VARIABLES
        const int blockSize = 15;
        const int mapSize = 40;
        Color emptyBlockColor = Color.Gray;
        Color fullBlockColor = Color.Orange;
        int steps = 0;
        int biggestPopulation = 0;
        int populate = 0;
        IMapManagament mapManagement = new MapManagement();

        // Logical version of map, 0 - empty, 1 - full
        int[,] logicalMap = new int[mapSize, mapSize];
        #endregion

        /// <summary>
        /// This method run when program start
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            generateMap();
        }

        #region MAP GENERATOR
        /// <summary>
        /// This method is used to generate map
        /// </summary>
        private void generateMap()
        {
            for(int i = 0; i < mapSize; i++)
            {
                for(int j = 0; j < mapSize; j++)
                {
                    // Set logical value of a map as 0
                    logicalMap[i, j] = 0;

                    Point blockPosition = new Point(j * blockSize, i * blockSize);
                    generateBlock(blockPosition);
                }
            }
        }
        /// <summary>
        /// This map is used to generate single block
        /// </summary>
        /// <param name="blockPosition">Block position</param>
        private void generateBlock(Point blockPosition)
        {
            Button block = new Button();
            block.Size = new Size(blockSize, blockSize);
            block.Location = blockPosition;
            block.BackColor = emptyBlockColor;
            block.FlatStyle = 0;
            block.Name = blockPosition.Y / 15 + "_" + blockPosition.X / 15;
            block.Tag = "block";

            // Foreach button click event
            block.Click += (s, e) =>
            {
                if(logicalMap[block.Location.Y / 15, block.Location.X / 15] == 0)
                {
                    logicalMap[block.Location.Y / 15, block.Location.X / 15] = 1;
                    block.BackColor = fullBlockColor;
                }
                else
                {
                    logicalMap[block.Location.Y / 15, block.Location.X / 15] = 0;
                    block.BackColor = emptyBlockColor;
                }
            };

            Controls.Add(block);
        }
        #endregion

        /// <summary>
        /// This method run after "Reset default" button click. It's used to reset default settings of simulation
        /// </summary>
        private void defaulBT_Click(object sender, EventArgs e)
        {
            delayNUD.Value = 1000;
            lowerDepopulationNUD.Value = 1;
            upperDepopulationNUD.Value = 4;
            toAlive_1NUD.Value = 2;
            toAlive_2NUD.Value = 3;
            toPopulateNUD.Value = 3;
        }
        /// <summary>
        /// This method run after "Start" button click. It's used to start simulation
        /// </summary>
        private void startBT_Click(object sender, EventArgs e)
        {
            stepControler.Interval = Convert.ToInt32(delayNUD.Value);
            stepControler.Start();
        }
        /// <summary>
        /// This method run after "Stop" button click. It's used to stop simulation
        /// </summary>
        private void stopBT_Click(object sender, EventArgs e)
        {
            stepControler.Stop();
        }
        /// <summary>
        /// This method run after "Reset" button click. It's used to reset simulation
        /// </summary>
        private void resetBT_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure about restarting current simulation ?", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        logicalMap[i, j] = 0;
                    }
                }
                steps = 0;
                populate = 0;
                biggestPopulation = 0;
                refreshStats();
                refreshMap();
            }
        }
        /// <summary>
        /// This method run after "Instruction" button click. It's used to show instruction
        /// </summary>
        private void instruciotnBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create your simulation of 'Game Of Life' ! \n You can manage your own settings ! \n Remember to stop current simulation before restarting or starting new one !", "Instruction",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This method run after "Author" button click. It's used to show author
        /// </summary>
        private void authorBT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Norbert Lubaszka \n Contact: norbert.lubaszka@gmail.com \n All rights reserved © \n If you want to use the source code contact me", "Info about author",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This timer is used to do steps of simulation
        /// </summary>
        private void stepControler_Tick(object sender, EventArgs e)
        {
            logicalMap = mapManagement.calculateMap(logicalMap, mapSize, Convert.ToInt32(toPopulateNUD.Value), Convert.ToInt32(lowerDepopulationNUD.Value), 
                Convert.ToInt32(upperDepopulationNUD.Value), Convert.ToInt32(toAlive_1NUD.Value), Convert.ToInt32(toAlive_2NUD.Value));
            populate = mapManagement.getPopulate(logicalMap, mapSize);
            if (populate > biggestPopulation) biggestPopulation = populate;
            steps = steps + 1;
            refreshStats();
            refreshMap();
        }
        /// <summary>
        /// This method is used to refresh graphical interpretation of map
        /// </summary>
        private void refreshMap()
        {
            foreach (Control control in Controls)
            {
                if(control.Tag == "block")
                {
                    int value = 0;
                    string x = "";
                    string y = "";
                    for(int i = 0; i < control.Name.Length; i++)
                    {
                        if (control.Name[i] == '_') value = 1;
                        else
                        {
                            if (value == 0) x = x + control.Name[i];
                            else y = y + control.Name[i];
                        }
                    }
                    if (logicalMap[Convert.ToInt32(x), Convert.ToInt32(y)] == 0) control.BackColor = emptyBlockColor;
                    else control.BackColor = fullBlockColor;
                }
            }
        }
        /// <summary>
        /// This method is used to refresh stats
        /// </summary>
        private void refreshStats()
        {
            aliveLB.Text = "Alive nodes: " + populate.ToString();
            largestLB.Text = "Largest population: " + biggestPopulation.ToString();
            stepsLB.Text = "Total steps: " + steps.ToString();
        }
        /// <summary>
        /// This method run after "Random" button click
        /// </summary>
        private void randomBT_Click(object sender, EventArgs e)
        {
            logicalMap = mapManagement.setRandom(logicalMap, mapSize);
            refreshMap();
        }
    }
}
