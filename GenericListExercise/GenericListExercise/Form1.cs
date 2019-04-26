using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Author: Nikita Mieshalnykov
/// Project: GeneriCListExercise
/// Date: April 26th, 2019
/// </summary>

namespace GenericListExercise
{
    public struct Grade
    {
        public int maxPoints;
        public string mark;
    }

    public partial class Form1 : Form
    {
        private Grade grade;
        private List<Grade> allGrades = new List<Grade>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindingMark();
        }
        
        //Loading grades to a generic list according to maximum and minimum points
        private void LoadGrades()
        {
            grade.maxPoints = 299;
            grade.mark = "F";
            allGrades.Add(grade);

            grade.maxPoints = 349;
            grade.mark = "D";
            allGrades.Add(grade);

            grade.maxPoints = 399;
            grade.mark = "C";
            allGrades.Add(grade);

            grade.maxPoints = 449;
            grade.mark = "B";
            allGrades.Add(grade);

            grade.maxPoints = 500;
            grade.mark = "A";
            allGrades.Add(grade);
        }

        //iterating through each grade to find a mark according to the max points
        private void FindingMark()
        {
            int points = Convert.ToInt32(txtScore.Text);

            foreach (var grade in allGrades.Where(e => e.maxPoints > points))
            {
                MessageBox.Show(grade.mark);
                return;
            }
        }
    }
}
