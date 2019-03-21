using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anna
{
    public partial class WeightConverter : Form
    {
        public WeightConverter()
        {
            InitializeComponent();
        }

        private void WeightConverter_Load(object sender, EventArgs e)
        {

        }

        private void LiquedConverterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(OunceToGill.Checked == true)
                {
                    var convert = new OunceToGillConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Ounces Is " + convert.OtoC_Converter(LiquedCoverterTxtBox.Text) + " Gills";

                }
                else if (GillToPint.Checked == true)
                {
                    var convert = new GillToPintConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Gills Is " + convert.GtoP_Coverter(LiquedCoverterTxtBox.Text) + " Pints";

                }
                else if (PintToQuart.Checked == true)
                {
                    var convert = new PintToQuartConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Pints Is " + convert.PtoC_Converter(LiquedCoverterTxtBox.Text) + " Quarts";

                }
                else if (QuartToGallon.Checked == true)
                {
                    var convert = new QuartToGallonConverter();
                    LiquedCoverterTxtBox.Text = LiquedCoverterTxtBox.Text + " Quarts Is " + convert.QtoG_Converter(LiquedCoverterTxtBox.Text) + " Gallons";

                }

                else
                {
                    MessageBox.Show("Please select a conversion formula");

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please make sure only one formula box is selected before converting or that you have a valid entry in the input field");

            }
        }

        private void LiquedCoverterTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OunceToGill_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GillToPint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PintToQuart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void QuartToGallon_CheckedChanged(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////////////////
        

        private void GrainToDram_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DramToOunce_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OunceToPound_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PoundToTon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WeightConverterTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightConverterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GrainToDram.Checked == true)
                {
                    var convert = new GrainToDramConverter();
                    WeightConverterTxtBox.Text = WeightConverterTxtBox.Text + " Grains Is " + convert.GtoD_Converter(WeightConverterTxtBox.Text) + " Drams";

                }
                else if (DramToOunce.Checked == true)
                {
                    var convert = new DramToOunceConverter();
                    WeightConverterTxtBox.Text = WeightConverterTxtBox.Text + " Drams Is " + convert.DtoO_Converter(WeightConverterTxtBox.Text) + " Ounces";

                }
                else if (OunceToPound.Checked == true)
                {
                    var convert = new OunceToPoundConverter();
                    WeightConverterTxtBox.Text = WeightConverterTxtBox.Text + " Ounces Is " + convert.OtoP_Converter(WeightConverterTxtBox.Text) + " Pounds";

                }
                else if (PoundToTon.Checked == true)
                {
                    var convert = new PoundToTonConverter();
                    WeightConverterTxtBox.Text = WeightConverterTxtBox.Text + " Pounds Is " + convert.PtoT_Converter(WeightConverterTxtBox.Text) + " Tons";
                }

                else
                {
                    MessageBox.Show("Please select a conversion formula");

                }
            }

            catch (Exception)
            {
                MessageBox.Show("Please make sure only one formula box is selected before converting or that you have a valid entry in the input field");

            }
        }
    }

    public class GrainToDramConverter
    {
        public string GtoD_Converter(string unit)
        {
            double Dram;
            double Weight = Convert.ToDouble(unit);
            Dram = Weight / 27.344;
            return (Dram).ToString();
        }
    }

    public class DramToOunceConverter
    {
        public string DtoO_Converter(string unit)
        {
            double Ounce;
            double Weight = Convert.ToDouble(unit);
            Ounce = Weight / 16;
            return (Ounce).ToString();
        }
    }

    public class OunceToPoundConverter
    {
        public string OtoP_Converter(string unit)
        {
            double Pound;
            double Weight = Convert.ToDouble(unit);
            Pound = Weight / 16;
            return (Pound).ToString();
        }
    }

    public class PoundToTonConverter
    {
        public string PtoT_Converter(string unit)
        {
            double Ton;
            double Weight = Convert.ToDouble(unit);
            Ton = Weight / 2000;
            return (Ton).ToString();
        }
    }
    /// <summary>
    /// 
    /// </summary>

    public class OunceToGillConverter {

    public string OtoC_Converter(string unit){
            double Gill;
            double Weight = Convert.ToDouble(unit);
            Gill = Weight / 4;
            return (Gill).ToString();
        }
           
    }
    public class GillToPintConverter {

    public string GtoP_Coverter(string unit){
            double Pint;
            double Weight = Convert.ToDouble(unit);
            Pint = Weight / 4;
            return (Pint).ToString();
        }

    }
    public class PintToQuartConverter {

    public string PtoC_Converter (string unit){
            double Quart;
            double Weight = Convert.ToDouble(unit);
            Quart = Weight / 2.402;
            return (Quart).ToString();
        }

    }
    public class QuartToGallonConverter {

    public string QtoG_Converter(string unit){
            double Gallon;
            double Weight = Convert.ToDouble(unit);
            Gallon = Weight / 3.331;
            return (Gallon).ToString();
        }

    }

}
