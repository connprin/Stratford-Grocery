using System;
//January 22, 2021
//created by Connor Prince
//this program is a cash register for a grocery store, it simulates features similiar to real cash registers
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stratford_Grocery
{
    public partial class stratfordGrocery : Form
    {
        //meat global variables
        double groundbeefPrice = 3.70;
        int groundbeefAmount = 0;
        double chickenPrice = 11.00;
        int chickenAmount = 0;
        double baconPrice = 3.77;
        int baconAmount = 0;
        double steakPrice = 13.20;
        int steakAmount = 0;

        //produce global variables
        double applesPrice = 0.51;
        int applesAmount = 0;
        double bananasPrice = 0.28;
        int bananasAmount = 0;
        double orangesPrice = 1.04;
        int orangesAmount = 0;
        double carrotsPrice = 1.97;
        int carrotsAmount = 0;

        //dairy global variables
        double milkPrice = 4.50;
        int milkAmount = 0;
        double cheesePrice = 5.77;
        int cheeseAmount = 0;
        double butterPrice = 4.47;
        int butterAmount = 0;
        double eggsPrice = 2.84;
        int eggsAmount = 0;

        //snacks global variables
        double chipsPrice = 3.00;
        int chipsAmount = 0;
        double cookiesPrice = 2.50;
        int cookiesAmount = 0;
        double chocolatePrice = 1.00;
        int chocolateAmount = 0;
        double candyPrice = 3.50;
        int candyAmount = 0;

        //drinks global variables
        double winePrice = 10.00;
        int wineAmount = 0;
        double chocmilkPrice = 1.48;
        int chocmilkAmount = 0;
        double sodaPrice = 2.00;
        int sodaAmount = 0;

        //calculations
        double tax;
        double subtotal;
        double total;
        double chickenTotal;
             double steakTotal;
            double groundbeefTotal;
            double baconTotal;
            double orangesTotal;
            double bananasTotal;
            double applesTotal;
            double carrotsTotal;
            double butterTotal;
             double eggsTotal;
            double milkTotal;
            double chocolateTotal;
             double chipsTotal;
            double cookiesTotal;
            double sodaTotal;
            double wineTotal;
            double chockmilkTotal;
             double cheeseTotal;
        double candyTotal;

        //discounts
        double thirty = 0.30;
        double thirtyResult;
        
        public stratfordGrocery()
        {
            InitializeComponent();
        }

        private void displayBackground_Click(object sender, EventArgs e)
        {

        }

        private void meatButton_Click(object sender, EventArgs e)
        {
            groundbeefButton.Visible = true;
            groundbeefButton.Enabled = true;
            chickenButton.Visible = true;
            chickenButton.Enabled = true;
            baconButton.Visible = true;
            baconButton.Enabled = true;
            steakButton.Visible = true;
            steakButton.Enabled = true;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
        }

        private void produceButton_Click(object sender, EventArgs e)
        {
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            applesButton.Visible = true;
            applesButton.Enabled = true;
            orangesButton.Enabled = true;
            orangesButton.Visible = true;
            carrotsButton.Enabled = true;
            carrotsButton.Visible = true;
            bananasButton.Visible = true;
            bananasButton.Enabled = true;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
        }

        private void dairyButton_Click(object sender, EventArgs e)
        {
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = true;
            milkButton.Visible = true;
            cheeseButton.Enabled = true;
            cheeseButton.Visible = true;
            butterButton.Enabled = true;
            butterButton.Visible = true;
            eggsButton.Enabled = true;
            eggsButton.Visible = true;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
        }

        private void snacksButton_Click(object sender, EventArgs e)
        {
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false; 
            chipsButton.Enabled = true;
            chipsButton.Visible = true;
            chocolateButton.Visible = true;
            chocolateButton.Enabled = true;
            cookiesButton.Visible = true;
            cookiesButton.Enabled = true;
            candyButton.Enabled = true;
            candyButton.Visible = true;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
        }

        private void drinksButton_Click(object sender, EventArgs e)
        {
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false; 
            wineButton.Enabled = true;
            wineButton.Visible = true;
            chocmilkButton.Enabled = true;
            chocmilkButton.Visible = true;
            sodaButton.Enabled = true;
            sodaButton.Visible = true;
        }

        private void candyButton_Click(object sender, EventArgs e)
        {

            if (voidButton.BackColor == Color.Gray)
            {
                candyAmount++;
            }
            else
            {
                candyAmount--;
            }
            double candyTotal = candyPrice * candyAmount;
            displayLabel.Text += $"\n {candyAmount}x candy  {candyTotal.ToString("$0.00")}";
        }

        private void cheeseButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                cheeseAmount ++;
            }
            else
            {
                cheeseAmount --;
            }
            double cheeseTotal = cheesePrice * cheeseAmount;
            displayLabel.Text += $"\n {cheeseAmount}x cheese  {cheeseTotal.ToString("$0.00")}";
        }

        private void chocmilkButton_Click(object sender, EventArgs e)
        {
            

          

            if (voidButton.BackColor == Color.Gray)
            {
                chocmilkAmount++;
            }
            else
            {
                if (chocmilkAmount > 0)
                {
                    chocmilkAmount--;
                }
            }
            double chocmilkTotal = chocmilkPrice * chocmilkAmount;
            displayLabel.Text += $"\n {chocmilkAmount}x chocolate milk  {chocmilkTotal.ToString("$0.00")}";
        }

        private void wineButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                wineAmount++;
            }
            else
            {
                if (wineAmount > 0)
                {
                    wineAmount--;
                }
            }
            double wineTotal = winePrice * wineAmount;
            displayLabel.Text += $"\n {wineAmount}x wine  {wineTotal.ToString("$0.00")}";
        }

        private void sodaButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                sodaAmount++;
            }
            else
            {
                if (sodaAmount > 0)
                {
                    sodaAmount--;
                }
            }
            double sodaTotal = sodaPrice * sodaAmount;
            displayLabel.Text += $"\n {sodaAmount}x soda  {sodaTotal.ToString("$0.00")}";
        }

        private void cookiesButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                cookiesAmount++;
            }
            else
            {
                if (cookiesAmount > 0)
                {
                    cookiesAmount--;
                }
            }
            double cookiesTotal = cookiesPrice * cookiesAmount;
            displayLabel.Text += $"\n {cookiesAmount}x cookies  {cookiesTotal.ToString("$0.00")}";
        }

        private void chipsButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                chipsAmount++;
            }
            else
            {
                if (chipsAmount > 0)
                {
                    chipsAmount--;
                }
            }
            double chipsTotal = chipsPrice * chipsAmount;
            displayLabel.Text += $"\n {chipsAmount}x chips  {chipsTotal.ToString("$0.00")}";
        }

        private void chocolateButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                chocolateAmount++;
            }
            else
            {
                if (chocolateAmount > 0)
                {
                    chocolateAmount--;
                }
            }
            double chocolateTotal = chocolatePrice * chocolateAmount;
            displayLabel.Text += $"\n {chocolateAmount}x chocolate bar  {chocolateTotal.ToString("$0.00")}";
        }

        private void milkButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                milkAmount++;
            }
            else
            {
                if (milkAmount > 0)
                {
                    milkAmount--;
                }
            }
            double milkTotal = milkPrice * milkAmount;
            displayLabel.Text += $"\n {milkAmount}x milk  {milkTotal.ToString("$0.00")}";
        }

        private void eggsButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                eggsAmount++;
            }
            else
            {
                if (eggsAmount > 0)
                {
                    eggsAmount--;
                }
            }
            double eggsTotal = eggsPrice * eggsAmount;
            displayLabel.Text += $"\n {eggsAmount}x eggs  {eggsTotal.ToString("$0.00")}";
        }

        private void butterButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                butterAmount++;
            }
            else
            {
                if (butterAmount > 0)
                {
                    butterAmount--;
                }
            }
            double butterTotal = butterPrice * butterAmount;
            displayLabel.Text += $"\n {butterAmount}x butter  {butterTotal.ToString("$0.00")}";
        }

        private void carrotsButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                carrotsAmount++;
            }
            else
            {
                if (carrotsAmount > 0)
                {
                    carrotsAmount--;
                }
            }
            double carrotsTotal = carrotsPrice * carrotsAmount;
            displayLabel.Text += $"\n {carrotsAmount}x carrots  {carrotsTotal.ToString("$0.00")}";
        }

        private void applesButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                applesAmount++;
            }
            else
            {
                if (applesAmount > 0)
                {
                    applesAmount--;
                }
            }
            double applesTotal = applesPrice * applesAmount;
            displayLabel.Text += $"\n {applesAmount}x apples  {applesTotal.ToString("$0.00")}";
        }

        private void bananasButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                bananasAmount++;
            }
            else
            {
                if (bananasAmount > 0)
                {
                    bananasAmount--;
                }
            }
            double bananasTotal = bananasPrice * bananasAmount;
            displayLabel.Text += $"\n {bananasAmount}x bananas  {bananasTotal.ToString("$0.00")}";
        }

        private void orangesButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                orangesAmount++;
            }
            else
            {
                if (orangesAmount > 0)
                {
                    orangesAmount--;
                }
            }
            double orangesTotal = orangesPrice * orangesAmount;
            displayLabel.Text += $"\n {orangesAmount}x oranges  {orangesTotal.ToString("$0.00")}";
        }

        private void baconButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                baconAmount++;
            }
            else
            {
                if (baconAmount > 0)
                {
                    baconAmount--;
                }
            }
            double baconTotal = baconPrice * baconAmount;
            displayLabel.Text += $"\n {baconAmount}x bacon  {baconTotal.ToString("$0.00")}";
        }

        private void groundbeefButton_Click(object sender, EventArgs e)
        {

            if (voidButton.BackColor == Color.Gray)
            {
                groundbeefAmount++;
            }
            else
            {
                if (groundbeefAmount > 0)
                {
                    groundbeefAmount--;
                }
            }
            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            displayLabel.Text += $"\n {groundbeefAmount}x groundbeef  {groundbeefTotal.ToString("$0.00")}";
        }

        private void steakButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                steakAmount++;
            }
            else
            {
                if (steakAmount > 0)
                {
                    steakAmount--;
                }
            }
            double steakTotal = steakPrice * steakAmount;
            displayLabel.Text += $"\n {steakAmount}x steak  {steakTotal.ToString("$0.00")}";
        }

        private void chickenButton_Click(object sender, EventArgs e)
        {
            if (voidButton.BackColor == Color.Gray)
            {
                chickenAmount++;
            }
            else
            {
                if(chickenAmount > 0)
                {
                    chickenAmount--;
                }
            }
            double chickenTotal = chickenPrice * chickenAmount;
            displayLabel.Text += $"\n {chickenAmount}x chicken  {chickenTotal.ToString("$0.00")}";
        }

        public void calculateButton_Click(object sender, EventArgs e)
        {
            //calculates subtotal, tax, and total
            double butterTotal = butterPrice * butterAmount;
            double eggsTotal = eggsPrice * eggsAmount;
                        double milkTotal = milkPrice  * milkAmount;
            double chocolateTotal = chocolatePrice * chocolateAmount;
            double chipsTotal = chipsPrice * chipsAmount;
            double cookiesTotal = cookiesPrice * cookiesAmount;
            double sodaTotal = sodaPrice * sodaAmount;
            double wineTotal = winePrice * wineAmount;
            double chockmilkTotal = chocmilkPrice * chocmilkAmount;
            double cheeseTotal = cheesePrice * cheeseAmount;
            double candyTotal = candyPrice * candyAmount;
            double baconTotal = baconPrice * baconAmount;
            double orangesTotal = orangesPrice * orangesAmount;
            double bananasTotal = bananasPrice * bananasAmount;
            double applesTotal = applesPrice * applesAmount;
            double carrotsTotal = carrotsPrice * carrotsAmount;

            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            double steakTotal = steakPrice * steakAmount;
            double chickenTotal = chickenPrice * chickenAmount;
            double subtotal = chickenTotal + steakTotal + groundbeefTotal + carrotsTotal + applesTotal + bananasTotal + orangesTotal + baconTotal + candyTotal + cheeseTotal + chockmilkTotal + wineTotal + sodaTotal + cookiesTotal + chipsTotal + chocolateTotal + milkTotal + eggsTotal + butterTotal;
            double tax = subtotal * 0.13;
            double total = tax + subtotal;

            subtotalLabel.Text = $"{subtotal.ToString("$0.00")}";
            taxLabel.Text = $"{tax.ToString("$0.00")}";
            totalsLabel.Text = $"{total.ToString("$0.00")}";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears all values except stored ones
            displayLabel.Text = "";
            chickenAmount = 0;
            steakAmount = 0;
            wineAmount = 0;
            sodaAmount = 0;
            cookiesAmount = 0;
            chipsAmount = 0;
            chocolateAmount = 0;
            milkAmount = 0;
            eggsAmount = 0;
            butterAmount = 0;
            groundbeefAmount = 0;
            carrotsAmount = 0;
            applesAmount = 0;
            bananasAmount = 0;
            orangesAmount = 0;
            baconAmount = 0;
            candyAmount = 0;
            cheeseAmount = 0;
            chocmilkAmount = 0;
            subtotalLabel.Text = "";
            taxLabel.Text = "";
            totalsLabel.Text = "";
            receiptDisplay.Text = "";
            pastordersLabel.Text += $"\n {subtotal}\n {tax}\n {total}\n";
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            //prints receipt
            double butterTotal = butterPrice * butterAmount;
            double eggsTotal = eggsPrice * eggsAmount;
            double milkTotal = milkPrice * milkAmount;
            double chocolateTotal = chocolatePrice * chocolateAmount;
            double chipsTotal = chipsPrice * chipsAmount;
            double cookiesTotal = cookiesPrice * cookiesAmount;
            double sodaTotal = sodaPrice * sodaAmount;
            double wineTotal = winePrice * wineAmount;
            double chockmilkTotal = chocmilkPrice * chocmilkAmount;
            double cheeseTotal = cheesePrice * cheeseAmount;
            double candyTotal = candyPrice * candyAmount;
            double baconTotal = baconPrice * baconAmount;
            double orangesTotal = orangesPrice * orangesAmount;
            double bananasTotal = bananasPrice * bananasAmount;
            double applesTotal = applesPrice * applesAmount;
            double carrotsTotal = carrotsPrice * carrotsAmount;

            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            double steakTotal = steakPrice * steakAmount;
            double chickenTotal = chickenPrice * chickenAmount;
            double subtotal = chickenTotal + steakTotal + groundbeefTotal + carrotsTotal + applesTotal + bananasTotal + orangesTotal + baconTotal + candyTotal + cheeseTotal + chockmilkTotal + wineTotal + sodaTotal + cookiesTotal + chipsTotal + chocolateTotal + milkTotal + eggsTotal + butterTotal;
            double tax = subtotal * 0.13;
            double total = tax + subtotal;
            categoryBackground.Visible = false;
            meatButton.Visible = false;
            produceButton.Visible = false;
            dairyButton.Visible = false;
            snacksButton.Visible = false;
            drinksButton.Visible = false;
            displayHeader.Visible = false;
            displayLabel.Visible = false;
            totalLabel.Visible = false;
            subtotalLabel.Visible = false;
            taxLabel.Visible = false;
            totalsLabel.Visible = false;
            printButton.Visible = false;
            voidButton.Visible = false;
            calculateButton.Visible = false;
            discountButton.Visible = false;
            pastordersButton.Visible = false;
            clearButton.Visible = false;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            receiptDisplay.Visible = true;
            receiptHeader.Visible = true;
            backButton.Visible = true;
            if (total > 0)
            {
                receiptDisplay.Text += $"\n subtotal = {subtotal.ToString("$0.00")}";
                receiptDisplay.Text += $"\n tax = {tax.ToString("$0.00")}";
                receiptDisplay.Text += $"\n total = {total.ToString("$0.00")} \n";
            }
      
            if (chickenAmount > 0)
            {
                receiptDisplay.Text += $"\n {chickenAmount}x chicken {chickenTotal.ToString("$0.00")}";
            }
             if (steakAmount > 0)
            {
                receiptDisplay.Text += $"\n {steakAmount}x steak {steakTotal.ToString("$0.00")}";
            }
             if (groundbeefAmount > 0)
            {
                receiptDisplay.Text += $"\n {groundbeefAmount}x groundbeef {groundbeefTotal.ToString("$0.00")}";
            }
             if (baconAmount > 0)
            {
                receiptDisplay.Text += $"\n {baconAmount}x bacon {baconTotal.ToString("$0.00")}";
            }
             if (applesAmount > 0)
            {
                receiptDisplay.Text += $"\n {applesAmount}x apple {applesTotal.ToString("$0.00")}";
            }
             if (orangesAmount  > 0)
            {
                receiptDisplay.Text += $"\n {orangesAmount }x orange {orangesTotal.ToString("$0.00") }";
            }
             if (bananasAmount  > 0)
            {
                receiptDisplay.Text += $"\n {bananasAmount}x banana {bananasAmount.ToString("$0.00")}";

            }
             if (applesAmount > 0)
            {
                receiptDisplay.Text += $"\n {applesAmount}x apple {applesTotal.ToString("$0.00")}";
            }
             if (carrotsAmount  > 0)
            {
                receiptDisplay.Text += $"\n {carrotsAmount }x carrots {carrotsTotal.ToString("$0.00")}";
            }
             if (milkAmount  > 0)
            {
                receiptDisplay.Text += $"\n {milkAmount }x milk {milkTotal.ToString("$0.00")}";
            }
             if (eggsAmount > 0)
            {
                receiptDisplay.Text += $"\n {eggsAmount}x eggs {eggsTotal.ToString("$0.00") }";
            }
             if (butterAmount > 0)
            {
                receiptDisplay.Text += $"\n {butterAmount }x butter {butterTotal.ToString("$0.00")}";
            }
             if (cheeseAmount > 0)
            {
                receiptDisplay.Text += $"\n {cheeseAmount}x cheese {cheeseTotal.ToString("$0.00")}";
            }
             if (applesAmount > 0)
            {
                receiptDisplay.Text += $"\n {applesAmount}x apple {applesTotal.ToString("$0.00")}";
            }
             if (chocolateAmount > 0)
            {
                receiptDisplay.Text += $"\n {chocolateAmount}x chocolate bar {chocolateTotal.ToString("$0.00")}";
            }
             if (chipsAmount  > 0)
            {
                receiptDisplay.Text += $"\n {chipsAmount }x chips {chipsTotal.ToString("$0.00")}";
            }
             if (cookiesAmount  > 0)
            {
                receiptDisplay.Text += $"\n {cookiesAmount }x cookies {cookiesTotal.ToString("$0.00")}";
            }
             if (candyAmount > 0)
            {
                receiptDisplay.Text += $"\n {candyAmount}x candy {candyTotal.ToString("$0.00")}";
            }
             if (sodaAmount > 0)
            {
                receiptDisplay.Text += $"\n {sodaAmount}x soda {sodaTotal.ToString("$0.00")}";
            }
             if (wineAmount > 0)
            {
                receiptDisplay.Text += $"\n {wineAmount}x wine {wineTotal.ToString("$0.00")}";
            }
             if (chocmilkAmount > 0)
            {
                receiptDisplay.Text += $"\n {chocmilkAmount}x choc milk {chockmilkTotal.ToString("$0.00")}";
            }

            pastordersLabel.Text += $"\n Subtotal -- {subtotal.ToString("$0.00")}\n Tax -- {tax.ToString("$0.00")}\n Total -- {total.ToString("$0.00")}\n";
        }

        private void receiptDisplay_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //takes user to main screen
            categoryBackground.Visible = true;
            meatButton.Visible = true;
            produceButton.Visible = true;
            dairyButton.Visible = true;
            snacksButton.Visible = true;
            drinksButton.Visible = true;
            displayHeader.Visible = true;
            displayLabel.Visible = true;
            totalLabel.Visible = true;
            subtotalLabel.Visible = true;
            taxLabel.Visible = true;
            totalsLabel.Visible = true;
            printButton.Visible = true;
            voidButton.Visible = true;
            calculateButton.Visible = true;
            discountButton.Visible = true;
            pastordersButton.Visible = true;
            clearButton.Visible = true;
            applesButton.Visible = true;
            applesButton.Enabled = true;
            orangesButton.Enabled = true;
            orangesButton.Visible = true;
            carrotsButton.Enabled = true;
            carrotsButton.Visible = true;
            bananasButton.Visible = true;
            bananasButton.Enabled = true;
            milkButton.Enabled = true;
            milkButton.Visible = true;
            cheeseButton.Enabled = true;
            cheeseButton.Visible = true;
            butterButton.Enabled = true;
            butterButton.Visible = true;
            eggsButton.Enabled = true;
            eggsButton.Visible = true;
            chipsButton.Enabled = true;
            chipsButton.Visible = true;
            chocolateButton.Visible = true;
            chocolateButton.Enabled = true;
            cookiesButton.Visible = true;
            cookiesButton.Enabled = true;
            candyButton.Enabled = true;
            candyButton.Visible = true;
            wineButton.Enabled = true;
            wineButton.Visible = true;
            chocmilkButton.Enabled = true;
            chocmilkButton.Visible = true;
            sodaButton.Enabled = true;
            sodaButton.Visible = true;
            groundbeefButton.Visible = true;
            groundbeefButton.Enabled = true;
            chickenButton.Visible = true;
            chickenButton.Enabled = true;
            baconButton.Visible = true;
            baconButton.Enabled = true;
            steakButton.Visible = true;
            steakButton.Enabled = true;
            receiptDisplay.Visible = false;
            receiptHeader.Visible = false;
            backButton.Visible = false;
            receiptDisplay.Text = "";
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            //allows user to discard items
            if (voidButton.BackColor == Color.Gray)
            {
                voidButton.BackColor = Color.Red;
            }
            else
            {
                voidButton.BackColor = Color.Gray;
            }
            
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            //takes user to discount screen
            categoryBackground.Visible = false;
            meatButton.Visible = false;
            produceButton.Visible = false;
            dairyButton.Visible = false;
            snacksButton.Visible = false;
            drinksButton.Visible = false;

           
            printButton.Visible = false;
            voidButton.Visible = false;
            calculateButton.Visible = false;
            discountButton.Visible = false;
            pastordersButton.Visible = false;
            clearButton.Visible = false;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            twodozeneggsButton.Visible = true;
            twodozeneggsButton.Enabled = true;
            twoforoneButton.Visible = true;
            twoforoneButton.Enabled = true;
            thirtypercentButton.Visible = true;
            thirtypercentButton.Enabled = true;
            backButton3.Visible = true;
            backButton3.Enabled = true;
        }

        private void pastordersButton_Click(object sender, EventArgs e)
        {
            //takes user to past orders screen
            categoryBackground.Visible = false;
            meatButton.Visible = false;
            produceButton.Visible = false;
            dairyButton.Visible = false;
            snacksButton.Visible = false;
            drinksButton.Visible = false;
            
            totalLabel.Visible = false;
            subtotalLabel.Visible = false;
            taxLabel.Visible = false;
            totalsLabel.Visible = false;
            printButton.Visible = false;
            voidButton.Visible = false;
            calculateButton.Visible = false;
            discountButton.Visible = false;
            pastordersButton.Visible = false;
            clearButton.Visible = false;
            applesButton.Visible = false;
            applesButton.Enabled = false;
            orangesButton.Enabled = false;
            orangesButton.Visible = false;
            carrotsButton.Enabled = false;
            carrotsButton.Visible = false;
            bananasButton.Visible = false;
            bananasButton.Enabled = false;
            milkButton.Enabled = false;
            milkButton.Visible = false;
            cheeseButton.Enabled = false;
            cheeseButton.Visible = false;
            butterButton.Enabled = false;
            butterButton.Visible = false;
            eggsButton.Enabled = false;
            eggsButton.Visible = false;
            chipsButton.Enabled = false;
            chipsButton.Visible = false;
            chocolateButton.Visible = false;
            chocolateButton.Enabled = false;
            cookiesButton.Visible = false;
            cookiesButton.Enabled = false;
            candyButton.Enabled = false;
            candyButton.Visible = false;
            wineButton.Enabled = false;
            wineButton.Visible = false;
            chocmilkButton.Enabled = false;
            chocmilkButton.Visible = false;
            sodaButton.Enabled = false;
            sodaButton.Visible = false;
            groundbeefButton.Visible = false;
            groundbeefButton.Enabled = false;
            chickenButton.Visible = false;
            chickenButton.Enabled = false;
            baconButton.Visible = false;
            baconButton.Enabled = false;
            steakButton.Visible = false;
            steakButton.Enabled = false;
            pastordersLabel.Visible = true;
            pastordersHeader.Visible = true;
            backButton2.Visible = true;
            backButton2.Enabled = true;
            double butterTotal = butterPrice * butterAmount;
            double eggsTotal = eggsPrice * eggsAmount;
            double milkTotal = milkPrice * milkAmount;
            double chocolateTotal = chocolatePrice * chocolateAmount;
            double chipsTotal = chipsPrice * chipsAmount;
            double cookiesTotal = cookiesPrice * cookiesAmount;
            double sodaTotal = sodaPrice * sodaAmount;
            double wineTotal = winePrice * wineAmount;
            double chockmilkTotal = chocmilkPrice * chocmilkAmount;
            double cheeseTotal = cheesePrice * cheeseAmount;
            double candyTotal = candyPrice * candyAmount;
            double baconTotal = baconPrice * baconAmount;
            double orangesTotal = orangesPrice * orangesAmount;
            double bananasTotal = bananasPrice * bananasAmount;
            double applesTotal = applesPrice * applesAmount;
            double carrotsTotal = carrotsPrice * carrotsAmount;

            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            double steakTotal = steakPrice * steakAmount;
            double chickenTotal = chickenPrice * chickenAmount;
            double subtotal = chickenTotal + steakTotal + groundbeefTotal + carrotsTotal + applesTotal + bananasTotal + orangesTotal + baconTotal + candyTotal + cheeseTotal + chockmilkTotal + wineTotal + sodaTotal + cookiesTotal + chipsTotal + chocolateTotal + milkTotal + eggsTotal + butterTotal;
            double tax = subtotal * 0.13;
            double total = tax + subtotal;

            

        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            //takes user to main menu
            categoryBackground.Visible = true;
            meatButton.Visible = true;
            produceButton.Visible = true;
            dairyButton.Visible = true;
            snacksButton.Visible = true;
            drinksButton.Visible = true;
           
            totalLabel.Visible = true;
            subtotalLabel.Visible = true;
            taxLabel.Visible = true;
            totalsLabel.Visible = true;
            printButton.Visible = true;
            voidButton.Visible = true;
            calculateButton.Visible = true;
            discountButton.Visible = true;
            pastordersButton.Visible = true;
            clearButton.Visible = true;
            applesButton.Visible = true;
            applesButton.Enabled = true;
            orangesButton.Enabled = true;
            orangesButton.Visible = true;
            carrotsButton.Enabled = true;
            carrotsButton.Visible = true;
            bananasButton.Visible = true;
            bananasButton.Enabled = true;
            milkButton.Enabled = true;
            milkButton.Visible = true;
            cheeseButton.Enabled = true;
            cheeseButton.Visible = true;
            butterButton.Enabled = true;
            butterButton.Visible = true;
            eggsButton.Enabled = true;
            eggsButton.Visible = true;
            chipsButton.Enabled = true;
            chipsButton.Visible = true;
            chocolateButton.Visible = true;
            chocolateButton.Enabled = true;
            cookiesButton.Visible = true;
            cookiesButton.Enabled = true;
            candyButton.Enabled = true;
            candyButton.Visible = true;
            wineButton.Enabled = true;
            wineButton.Visible = true;
            chocmilkButton.Enabled = true;
            chocmilkButton.Visible = true;
            sodaButton.Enabled = true;
            sodaButton.Visible = true;
            groundbeefButton.Visible = true;
            groundbeefButton.Enabled = true;
            chickenButton.Visible = true;
            chickenButton.Enabled = true;
            baconButton.Visible = true;
            baconButton.Enabled = true;
            steakButton.Visible = true;
            steakButton.Enabled = true;
            pastordersLabel.Visible = false;
            pastordersHeader.Visible = false;
            backButton2.Visible = false;
            backButton2.Enabled = false;
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            //takes user to main menu
            categoryBackground.Visible = true;
            meatButton.Visible = true;
            produceButton.Visible = true;
            dairyButton.Visible = true;
            snacksButton.Visible = true;
            drinksButton.Visible = true;

            totalLabel.Visible = true;
            subtotalLabel.Visible = true;
            taxLabel.Visible = true;
            totalsLabel.Visible = true;
            printButton.Visible = true;
            voidButton.Visible = true;
            calculateButton.Visible = true;
            discountButton.Visible = true;
            pastordersButton.Visible = true;
            clearButton.Visible = true;
            applesButton.Visible = true;
            applesButton.Enabled = true;
            orangesButton.Enabled = true;
            orangesButton.Visible = true;
            carrotsButton.Enabled = true;
            carrotsButton.Visible = true;
            bananasButton.Visible = true;
            bananasButton.Enabled = true;
            milkButton.Enabled = true;
            milkButton.Visible = true;
            cheeseButton.Enabled = true;
            cheeseButton.Visible = true;
            butterButton.Enabled = true;
            butterButton.Visible = true;
            eggsButton.Enabled = true;
            eggsButton.Visible = true;
            chipsButton.Enabled = true;
            chipsButton.Visible = true;
            chocolateButton.Visible = true;
            chocolateButton.Enabled = true;
            cookiesButton.Visible = true;
            cookiesButton.Enabled = true;
            candyButton.Enabled = true;
            candyButton.Visible = true;
            wineButton.Enabled = true;
            wineButton.Visible = true;
            chocmilkButton.Enabled = true;
            chocmilkButton.Visible = true;
            sodaButton.Enabled = true;
            sodaButton.Visible = true;
            groundbeefButton.Visible = true;
            groundbeefButton.Enabled = true;
            chickenButton.Visible = true;
            chickenButton.Enabled = true;
            baconButton.Visible = true;
            baconButton.Enabled = true;
            steakButton.Visible = true;
            steakButton.Enabled = true;
            twodozeneggsButton.Visible = false;
            twodozeneggsButton.Enabled = false;
            twoforoneButton.Visible = false;
            twoforoneButton.Enabled = false;
            thirtypercentButton.Visible = false;
            thirtypercentButton.Enabled = false;
            backButton3.Visible = false;
            backButton3.Enabled = false;
        }

        private void thirtypercentButton_Click(object sender, EventArgs e)
        {
            //thirty percent off discount
            double butterTotal = butterPrice * butterAmount;
            double eggsTotal = eggsPrice * eggsAmount;
            double milkTotal = milkPrice * milkAmount;
            double chocolateTotal = chocolatePrice * chocolateAmount;
            double chipsTotal = chipsPrice * chipsAmount;
            double cookiesTotal = cookiesPrice * cookiesAmount;
            double sodaTotal = sodaPrice * sodaAmount;
            double wineTotal = winePrice * wineAmount;
            double chockmilkTotal = chocmilkPrice * chocmilkAmount;
            double cheeseTotal = cheesePrice * cheeseAmount;
            double candyTotal = candyPrice * candyAmount;
            double baconTotal = baconPrice * baconAmount;
            double orangesTotal = orangesPrice * orangesAmount;
            double bananasTotal = bananasPrice * bananasAmount;
            double applesTotal = applesPrice * applesAmount;
            double carrotsTotal = carrotsPrice * carrotsAmount;

            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            double steakTotal = steakPrice * steakAmount;
            double chickenTotal = chickenPrice * chickenAmount;
            double subtotal = chickenTotal + steakTotal + groundbeefTotal + carrotsTotal + applesTotal + bananasTotal + orangesTotal + baconTotal + candyTotal + cheeseTotal + chockmilkTotal + wineTotal + sodaTotal + cookiesTotal + chipsTotal + chocolateTotal + milkTotal + eggsTotal + butterTotal;
            double tax = subtotal * 0.13;
            double total = tax + subtotal;
            if (total >= 50)
            {
                
                thirtyResult = thirty * total;
                total = total - thirtyResult;
                displayLabel.Text += $"\n 30% Discount added";
                totalsLabel.Text = $"{total.ToString("$0.00")}";
                receiptDisplay.Text += $"\n DISCOUNTS ADDED:\nTOTAL ACTUAL = {total.ToString("$0.00")}";
            }
        }

        private void twodozeneggsButton_Click(object sender, EventArgs e)
        {
            //2 dozen eggs for free discount button
            double butterTotal = butterPrice * butterAmount;
            double eggsTotal = eggsPrice * eggsAmount;
            double milkTotal = milkPrice * milkAmount;
            double chocolateTotal = chocolatePrice * chocolateAmount;
            double chipsTotal = chipsPrice * chipsAmount;
            double cookiesTotal = cookiesPrice * cookiesAmount;
            double sodaTotal = sodaPrice * sodaAmount;
            double wineTotal = winePrice * wineAmount;
            double chockmilkTotal = chocmilkPrice * chocmilkAmount;
            double cheeseTotal = cheesePrice * cheeseAmount;
            double candyTotal = candyPrice * candyAmount;
            double baconTotal = baconPrice * baconAmount;
            double orangesTotal = orangesPrice * orangesAmount;
            double bananasTotal = bananasPrice * bananasAmount;
            double applesTotal = applesPrice * applesAmount;
            double carrotsTotal = carrotsPrice * carrotsAmount;

            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            double steakTotal = steakPrice * steakAmount;
            double chickenTotal = chickenPrice * chickenAmount;
            double subtotal = chickenTotal + steakTotal + groundbeefTotal + carrotsTotal + applesTotal + bananasTotal + orangesTotal + baconTotal + candyTotal + cheeseTotal + chockmilkTotal + wineTotal + sodaTotal + cookiesTotal + chipsTotal + chocolateTotal + milkTotal + eggsTotal + butterTotal;
            double tax = subtotal * 0.13;
            double total = tax + subtotal;
            double twoeggs = eggsPrice * 2;
            double eggtax = twoeggs * 0.13;
            if (eggsAmount == 2)
            {

                total = total - twoeggs - eggtax;
                displayLabel.Text += $"\n 2 dozen eggs free discount added";
                totalsLabel.Text = $"{total.ToString("$0.00")}";
                receiptDisplay.Text += $"\n DISCOUNTS ADDED:\nTOTAL ACTUAL = {total.ToString("$0.00")}";

            }
        }

        private void twoforoneButton_Click(object sender, EventArgs e)
        {
            //2 for 1 soda discount button
            double butterTotal = butterPrice * butterAmount;
            double eggsTotal = eggsPrice * eggsAmount;
            double milkTotal = milkPrice * milkAmount;
            double chocolateTotal = chocolatePrice * chocolateAmount;
            double chipsTotal = chipsPrice * chipsAmount;
            double cookiesTotal = cookiesPrice * cookiesAmount;
            double sodaTotal = sodaPrice * sodaAmount;
            double wineTotal = winePrice * wineAmount;
            double chockmilkTotal = chocmilkPrice * chocmilkAmount;
            double cheeseTotal = cheesePrice * cheeseAmount;
            double candyTotal = candyPrice * candyAmount;
            double baconTotal = baconPrice * baconAmount;
            double orangesTotal = orangesPrice * orangesAmount;
            double bananasTotal = bananasPrice * bananasAmount;
            double applesTotal = applesPrice * applesAmount;
            double carrotsTotal = carrotsPrice * carrotsAmount;

            double groundbeefTotal = groundbeefPrice * groundbeefAmount;
            double steakTotal = steakPrice * steakAmount;
            double chickenTotal = chickenPrice * chickenAmount;
            double subtotal = chickenTotal + steakTotal + groundbeefTotal + carrotsTotal + applesTotal + bananasTotal + orangesTotal + baconTotal + candyTotal + cheeseTotal + chockmilkTotal + wineTotal + sodaTotal + cookiesTotal + chipsTotal + chocolateTotal + milkTotal + eggsTotal + butterTotal;
            double tax = subtotal * 0.13;
            double total = tax + subtotal;
            double sodatax = sodaPrice * 0.13;
            if (sodaAmount == 2)
            {
                total = total - sodaPrice - sodatax;
                displayLabel.Text += $"\n 2 for 1 sodas discount added";
                totalsLabel.Text = $"{total.ToString("$0.00")}";
                receiptDisplay.Text += $"\n DISCOUNTS ADDED:\nTOTAL ACTUAL = {total.ToString("$0.00")}";
            }

        }
    }
}
