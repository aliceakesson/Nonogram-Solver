using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram_Solver
{
    enum Difficulty
    {
        Easy, 
        Medium, 
        Hard, 
        Expert
    }

    public partial class Form1 : Form
    {

        Difficulty difficulty = 0;
        bool difficultyChoosen = false;
        
        Panel[] panels = new Panel[9];

        int gridWidth = 400;

        List<TextBox[]> numbers = new List<TextBox[]>();
        TextBox[] mediumNumbers = new TextBox[20];

        bool fillTheBoxes = false;
        int[,] solution_10 = new int[10, 10]; // 0 för tom, 1 för fill 
        int[,] solution_15 = new int[15, 15]; //första delen = xpos, andra = ypos
        int[,] solution_20 = new int[20, 20];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int x = 81;
            int y = 66; 

            panel_pickDifficulty.Visible = true;
            panel_Easy.Visible = false;
            panel_Medium.Visible = false;

            panel_pickDifficulty.Location = new Point(x, y);
            panel_Easy.Location = new Point(x, y);
            panel_Medium.Location = new Point(x, y);

            panels[0] = panel_pickDifficulty;
            panels[1] = panel_Easy;
            panels[2] = panel_Medium;

            panels[5] = panel_Medium_grid;

            mediumNumbers[0] = tbox_Medium_1;
            mediumNumbers[1] = tbox_Medium_2;
            mediumNumbers[2] = tbox_Medium_3;
            mediumNumbers[3] = tbox_Medium_4;
            mediumNumbers[4] = tbox_Medium_5;
            mediumNumbers[5] = tbox_Medium_6;
            mediumNumbers[6] = tbox_Medium_7;
            mediumNumbers[7] = tbox_Medium_8;
            mediumNumbers[8] = tbox_Medium_9;
            mediumNumbers[9] = tbox_Medium_10;
            mediumNumbers[10] = tbox_Medium_11;
            mediumNumbers[11] = tbox_Medium_12;
            mediumNumbers[12] = tbox_Medium_13;
            mediumNumbers[13] = tbox_Medium_14;
            mediumNumbers[14] = tbox_Medium_15;
            mediumNumbers[15] = tbox_Medium_16;
            mediumNumbers[16] = tbox_Medium_17;
            mediumNumbers[17] = tbox_Medium_18;
            mediumNumbers[18] = tbox_Medium_19;
            mediumNumbers[19] = tbox_Medium_20;

            numbers.Add(mediumNumbers);

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    solution_10[i, j] = 0; 
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    solution_15[i, j] = 0;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    solution_20[i, j] = 0;
                }
            }

        }

        private void programTimer_Tick(object sender, EventArgs e)
        {

            if(difficultyChoosen)
            {
                panel_pickDifficulty.Visible = false;

                Panel gamePanel = panels[(int)difficulty + 1];
                Panel gridPanel = panels[(int)difficulty + 5];
                TextBox[] currentNumbers = numbers[0]; // = numbers[(int)difficulty];


                gamePanel.Visible = true;

            }

        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Easy;
            difficultyChoosen = true;
        }
        private void btn_hard_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Hard;
            difficultyChoosen = true;
        }
        private void btn_expert_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Expert;
            difficultyChoosen = true;
        }
        private void btn_medium_Click(object sender, EventArgs e)
        {
            difficulty = Difficulty.Medium;
            difficultyChoosen = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OnPaint_Medium_Grid(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            Brush brush = (Brush)Brushes.Black;

            int margin = 1; 

            int amountOfBoxes = 10;

            int celWidth = gridWidth / amountOfBoxes; 

            for(int i = 1; i <= (amountOfBoxes-1); i++)
            { 
                g.DrawLine(pen, celWidth*i, 0, celWidth*i, gridWidth);
                g.DrawLine(pen, 0, celWidth*i, gridWidth, celWidth*i);
            }

            Pen thickPen = new Pen(Color.Black, 3);

            g.DrawLine(thickPen, 0, 0, gridWidth, 0);
            g.DrawLine(thickPen, 0, 0, 0, gridWidth);
            g.DrawLine(thickPen, 0, gridWidth - 1, gridWidth, gridWidth - 1);
            g.DrawLine(thickPen, gridWidth - 1, 0, gridWidth - 1, gridWidth);

            g.DrawLine(thickPen, celWidth*5, 0, celWidth*5, gridWidth);
            g.DrawLine(thickPen, 0, celWidth*5, gridWidth, celWidth*5);

            if(fillTheBoxes)
            {
                for(int i = 0; i < 10; i++)
                {
                    for(int j = 0; j < 10; j++)
                    {
                        int fill = solution_10[i, j];
                        if(fill == 1)
                        {
                            g.FillRectangle(brush, celWidth*i, celWidth*j, celWidth, celWidth);
                        }
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbox_Medium_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void solvePuzzle(object sender, EventArgs e)
        {

            
            TextBox[] currentNumbers = numbers[0]; // = numbers[(int)difficulty];
            bool readyToSolve = true;

            int amountOfBoxes = 20;
            if (difficulty == Difficulty.Hard)
                amountOfBoxes = 30;
            else if (difficulty == Difficulty.Expert)
                amountOfBoxes = 40;

            List<List<string>> strings = new List<List<string>>();

            for(int i = 0; i < amountOfBoxes/2; i++) // första halvan, de där uppe
            {
                string text = currentNumbers[i].Text;

                if(text.Length == 0)
                {
                    readyToSolve = false;
                    //break; 
                }
                else
                {
                    List<string> lines = new List<string>();

                    if (text.IndexOf('\n') > 0)
                    {
                        int index = 0;
                        int k = 0; 

                        while(text.IndexOf('\n') > 0)
                        {

                            string line = "";
                            
                            line = text.Substring(0, text.IndexOf('\n')-1);
                            lines.Add(line);

                            index = text.IndexOf('\n');
                            text = text.Substring(index+1);
                            
                        }

                        lines.Add(text);
                        
                    }
                    else
                    {
                        string line = text;
                        lines.Add(line);
                        
                    }

                    for(int j = 0; j < lines.Count; j++) { // fix all strings in List<string> lines
                        string line = lines[j];
                        line.Trim();

                        string lineOnlyNumbers = "";
                        if(line.Length > 0)
                        {
                            for(int k = 0; k < line.Length; k++)
                            {
                                bool isANumber = false;
                                for(int l = 0; l < 9; l++)
                                {
                                    if (line[k].ToString() == (l + ""))
                                        isANumber = true;
                                }
                                if (isANumber)
                                    lineOnlyNumbers += line[k];
                            }

                            //algoritm for checking if the first number is '0', if so remove it. 
                            //couldn't bother to finish this part sorry </3
                            //if(lineOnlyNumbers.Length > 0)
                            //{
                            //    if(lineOnlyNumbers.Contains("0"))
                            //    {
                            //        while(lineOnlyNumbers.Contains("0") || lineOnlyNumbers.Length != 0)
                            //        {
                            //            if (lineOnlyNumbers.IndexOf("0") == 0)
                            //                lineOnlyNumbers = lineOnlyNumbers.Substring(1);
                            //        }
                            //    }
                            //}

                        }

                        if (line.Length == 0)
                            lines.RemoveAt(j);

                    }

                    if(lines.Count == 0)
                    {
                        readyToSolve = false;
                        //break; 
                    }
                    else
                    {
                        strings.Add(lines);
                    }
                    
                }
            }

            for (int i = amountOfBoxes / 2; i < amountOfBoxes; i++) // andra halvan, de horisontella 
            {
                string text = currentNumbers[i].Text;

                if (text.Length == 0)
                {
                    readyToSolve = false;
                    //break; 
                }
                else
                {
                    List<string> lines = new List<string>();

                    if (text.IndexOf(' ') > 0)
                    {
                        int index = 0;
                        int k = 0;

                        while (text.IndexOf(' ') > 0)
                        {

                            string line = "";

                            line = text.Substring(0, text.IndexOf(' '));
                            lines.Add(line);

                            index = text.IndexOf(' ');

                            text = text.Substring(index + 1);

                        }

                        lines.Add(text);

                    }
                    else
                    {
                        string line = text;
                        lines.Add(line);

                    }

                    for (int j = 0; j < lines.Count; j++)
                    { // fix all strings in List<string> lines
                        string line = lines[j];
                        line.Trim();

                        string lineOnlyNumbers = "";
                        if (line.Length > 0)
                        {
                            for (int k = 0; k < line.Length; k++)
                            {
                                bool isANumber = false;
                                for (int l = 0; l < 9; l++)
                                {
                                    if (line[k].ToString() == (l + ""))
                                        isANumber = true;
                                }
                                if (isANumber)
                                    lineOnlyNumbers += line[k];
                            }

                            //algoritm for checking if the first number is '0', if so remove it. 
                            //couldn't bother to finish this part sorry </3
                            //if(lineOnlyNumbers.Length > 0)
                            //{
                            //    if(lineOnlyNumbers.Contains("0"))
                            //    {
                            //        while(lineOnlyNumbers.Contains("0") || lineOnlyNumbers.Length != 0)
                            //        {
                            //            if (lineOnlyNumbers.IndexOf("0") == 0)
                            //                lineOnlyNumbers = lineOnlyNumbers.Substring(1);
                            //        }
                            //    }
                            //}

                        }

                        if (line.Length == 0)
                            lines.RemoveAt(j);

                    }

                    if (lines.Count == 0)
                    {
                        readyToSolve = false;
                        //break; 
                    }
                    else
                    {
                        strings.Add(lines);
                    }

                }
            }

            if(readyToSolve) //now, solve if all boxes have valid numbers 
            {

                int n = 10; 
                int[,] solution = new int[10, 10];
                if (difficulty == Difficulty.Hard)
                {
                    n = 15;
                    solution = new int[15, 15];
                }
                else if (difficulty == Difficulty.Expert)
                {
                    n = 20; 
                    solution = new int[20, 20];
                }

                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        solution[i, j] = 0; 
                    }
                }

                Console.WriteLine("solve");

                for(int i = 0; i < amountOfBoxes/2; i++) // vertical part 
                {
                    for (int j = 0; j < strings[i].Count; j++) {

                        int number = 0; 
                        try
                        {
                            number = int.Parse(strings[i][j]);
                        } catch(FormatException fe)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Couldn't convert number from box to int");
                        }

                        int numberSum = 0; 
                        for (int k = 0; k < strings[i].Count; k++)
                        {
                            int numberAtIndex = 0; 
                            try
                            {
                                numberAtIndex = int.Parse(strings[i][k]);
                            } catch(FormatException fe) {
                                Console.WriteLine("");
                                Console.WriteLine("Couldn't convert number from box to int");
                            }

                            numberSum += (numberAtIndex + 1);

                        }
                        numberSum--; 

                        double numberLineLimit = amountOfBoxes / 4; //7.5 --> 7
                        if(number == (amountOfBoxes/2)) // full line
                        {
                            for(int k = 0; k < (amountOfBoxes/2); k++)
                            {
                                solution[i, k] = 1;
                            }
                        }
                        else if(numberSum == (amountOfBoxes/2)) //full line including spaces between
                        {
                            int indexCount = 0; 
                            for (int k = 0; k < strings[i].Count; k++)
                            {
                                int numberAtIndex = 0;
                                try
                                {
                                    numberAtIndex = int.Parse(strings[i][k]);
                                }
                                catch (FormatException fe)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Couldn't convert number from box to int");
                                }

                                for(int l = 0; l < numberAtIndex; l++)
                                {
                                    solution[i, indexCount + l] = 1; 
                                }
                                if(k != (strings[i].Count-1))
                                    solution[i, indexCount + numberAtIndex] = 0;

                                indexCount += (numberAtIndex + 1);

                            }
                        }
                        else if(number > numberLineLimit) //filled boxes in the middle becuase number overlapses middle
                        { 
                            if(difficulty == Difficulty.Hard)
                            {
                                solution[i, (int)(numberLineLimit+0.5)] = 1; // fill the middle part of the line 

                                int boxesLeftToFill = number - (int)(numberLineLimit + 0.5); //7.5 --> 8
                                if (boxesLeftToFill > 0)
                                {
                                    for (int k = 1; k <= boxesLeftToFill; k++)
                                    {
                                        solution[i, (int)(numberLineLimit + 0.5) - k] = 1;
                                        solution[i, (int)(numberLineLimit + 0.5) + k] = 1;
                                    }
                                }
                            }
                            else
                            {
                                int boxesLeftToFill = number - (int)(numberLineLimit); //7.5 --> 8
                                if (boxesLeftToFill > 0)
                                {
                                    for (int k = 1; k <= boxesLeftToFill; k++)
                                    {
                                        solution[i, (int)(amountOfBoxes/4) - k] = 1;
                                        solution[i, (int)(amountOfBoxes/4) + k - 1] = 1;
                                    }
                                }

                                if (j != 0) //not first number in box 
                                {
                                    int placesBeforeMin = 0;
                                    for (int k = 0; k < j; k++)
                                    {
                                        int numberAtIndex = 0;
                                        try
                                        {
                                            numberAtIndex = int.Parse(strings[i][k]);
                                        } catch(FormatException fe)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Couldn't convert number in box to int");
                                        }
                                        
                                        placesBeforeMin += (numberAtIndex + 1);
                                    }

                                    for (int k = 1; k <= placesBeforeMin; k++)
                                    {
                                        solution[i, (int)(amountOfBoxes/4) - 1 + boxesLeftToFill + k] = 1; 
                                    }
                                }

                                if (j != (strings[i].Count - 1)) //not last number in box 
                                {
                                    int placesAfterMin = 0;
                                    for (int k = j+1; k < (strings[i].Count); k++)
                                    {
                                        int numberAtIndex = 0;
                                        try
                                        {
                                            numberAtIndex = int.Parse(strings[i][k]);
                                        }
                                        catch (FormatException fe)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Couldn't convert number in box to int");
                                        }
                                        Console.WriteLine(numberAtIndex);
                                        placesAfterMin += (numberAtIndex + 1);
                                    }

                                    for (int k = 1; k <= placesAfterMin; k++)
                                    {
                                        solution[i, (int)(amountOfBoxes / 4) - boxesLeftToFill - k] = 1;
                                    }
                                }
                            }


                        }

                    }
                }
                for(int i = amountOfBoxes / 2; i < amountOfBoxes; i++) //horizontal part 
                {
                    for (int j = 0; j < strings[i].Count; j++)
                    {

                        int number = 0;
                        try
                        {
                            number = int.Parse(strings[i][j]);
                        }
                        catch (FormatException fe)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Couldn't convert number from box to int");
                        }

                        int numberSum = 0; // empty spaces, crosses (ex. 3 6) (?)
                        for (int k = 0; k < strings[i].Count; k++)
                        {
                            int numberAtIndex = 0;
                            try
                            {
                                numberAtIndex = int.Parse(strings[i][k]);
                            }
                            catch (FormatException fe)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Couldn't convert number from box to int");
                            }

                            numberSum += (numberAtIndex + 1);

                        }
                        numberSum--;

                        double numberLineLimit = amountOfBoxes / 4; //7.5 --> 7
                        if (number == (amountOfBoxes / 2)) // full line
                        {
                            for (int k = 0; k < (amountOfBoxes / 2); k++)
                            {
                                solution[k, i - amountOfBoxes / 2] = 1;
                            }
                        }
                        else if (numberSum == (amountOfBoxes / 2)) //full line including spaces between
                        { /* NOT COMPLETED */
                            int indexCount = 0;
                            for (int k = 0; k < strings[i].Count; k++)
                            {
                                int numberAtIndex = 0;
                                try
                                {
                                    numberAtIndex = int.Parse(strings[k][i - amountOfBoxes / 2]);
                                }
                                catch (FormatException fe)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Couldn't convert number from box to int");
                                }

                                for (int l = 0; l < numberAtIndex; l++)
                                {
                                    solution[i, indexCount + l] = 1;
                                }
                                if (k != (strings[i].Count - 1))
                                    solution[i, indexCount + numberAtIndex] = 0;

                                indexCount += (numberAtIndex + 1);

                            }
                        }
                        //else if (number > numberLineLimit) //filled boxes in the middle becuase number overlapses middle
                        //{
                        //    if (difficulty == Difficulty.Hard)
                        //    {
                        //        solution[i, (int)(numberLineLimit + 0.5)] = 1; // fill the middle part of the line 

                        //        int boxesLeftToFill = number - (int)(numberLineLimit + 0.5); //7.5 --> 8
                        //        if (boxesLeftToFill > 0)
                        //        {
                        //            for (int k = 1; k <= boxesLeftToFill; k++)
                        //            {
                        //                solution[i, (int)(numberLineLimit + 0.5) - k] = 1;
                        //                solution[i, (int)(numberLineLimit + 0.5) + k] = 1;
                        //            }
                        //        }
                        //    }
                        //    else
                        //    {
                        //        int boxesLeftToFill = number - (int)(numberLineLimit); //7.5 --> 8
                        //        if (boxesLeftToFill > 0)
                        //        {
                        //            for (int k = 1; k <= boxesLeftToFill; k++)
                        //            {
                        //                solution[i, (int)(amountOfBoxes / 4) - k] = 1;
                        //                solution[i, (int)(amountOfBoxes / 4) + k - 1] = 1;
                        //            }
                        //        }

                        //        if (j != 0) //not first number in box 
                        //        {
                        //            int placesBeforeMin = 0;
                        //            for (int k = 0; k < j; k++)
                        //            {
                        //                int numberAtIndex = 0;
                        //                try
                        //                {
                        //                    numberAtIndex = int.Parse(strings[i][k]);
                        //                }
                        //                catch (FormatException fe)
                        //                {
                        //                    Console.WriteLine("");
                        //                    Console.WriteLine("Couldn't convert number in box to int");
                        //                }

                        //                placesBeforeMin += (numberAtIndex + 1);
                        //            }

                        //            for (int k = 1; k <= placesBeforeMin; k++)
                        //            {
                        //                solution[i, (int)(amountOfBoxes / 4) - 1 + boxesLeftToFill + k] = 1;
                        //            }
                        //        }

                        //        if (j != (strings[i].Count - 1)) //not last number in box 
                        //        {
                        //            int placesAfterMin = 0;
                        //            for (int k = j + 1; k < (strings[i].Count); k++)
                        //            {
                        //                int numberAtIndex = 0;
                        //                try
                        //                {
                        //                    numberAtIndex = int.Parse(strings[i][k]);
                        //                }
                        //                catch (FormatException fe)
                        //                {
                        //                    Console.WriteLine("");
                        //                    Console.WriteLine("Couldn't convert number in box to int");
                        //                }
                        //                Console.WriteLine(numberAtIndex);
                        //                placesAfterMin += (numberAtIndex + 1);
                        //            }

                        //            for (int k = 1; k <= placesAfterMin; k++)
                        //            {
                        //                solution[i, (int)(amountOfBoxes / 4) - boxesLeftToFill - k] = 1;
                        //            }
                        //        }
                        //    }


                        //}

                    }
                }

                if (difficulty == Difficulty.Easy || difficulty == Difficulty.Medium)
                    solution_10 = solution;
                else if (difficulty == Difficulty.Hard)
                    solution_15 = solution;
                else
                    solution_20 = solution;

                fillTheBoxes = true;
                this.Refresh();

            }

        }

    }
}
