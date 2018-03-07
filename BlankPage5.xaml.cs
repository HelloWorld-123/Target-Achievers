using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App15
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage5 : Page
    {      
        List<String> questionlist;
        List<String> op1list;
        List<String> op2list;
        List<String> op3list;
        List<String> op4list;
        List<String> corlist;
        DispatcherTimer dt = new DispatcherTimer();
        DispatcherTimer timedisp = new DispatcherTimer();

        void generatequestions()
        {
           
            questionlist = new List<string>();

            op1list = new List<string>();
            op2list = new List<string>();
            op3list = new List<string>();
            op4list = new List<string>();
            corlist = new List<string>();



            questionlist.Add("A solution when diluted with H2O and boiled, it gives a white precipitate. On addition of excess NH4Cl/NH4OH. the volume of precipitate decreases leaving behind a white gelatinous precipitate. Identify the precipitate which dissolves in NH4OH/NH4Cl");
op1list.Add("Zn(OH)2") ;
op2list.Add("Al(OH)3") ;
op3list.Add("Mg(OH)2") ;
op4list.Add("Ca(OH)2") ;
corlist.Add("Zn(OH)2") ;

questionlist.Add("When benzene sulfonic acid and p-nitrophenol are treated with NaHCO3, the gases released respectively are") ;
op1list.Add("SO2, NO2") ;
op2list.Add("SO2, NO");
op3list.Add("SO2, CO2");
op4list.Add ("CO2, CO2") ;
corlist.Add("CO2, CO2");

questionlist.Add("A monatomic ideal gas undergoes a process in which the ratio of P to V at any instant is constant and equals to 1. What is the molar heat capacity of the gas?") ;
op1list.Add("4R/2") ;
op2list.Add("3R") ;
op3list.Add("5R/2") ; 
op4list.Add("0") ;
corlist.Add("4R/2") ;

questionlist.Add("(I) 1,2-dihydroxy benzene (II) 1,3-dihydroxy benzene (III) 1,4-dihydroxy benzene (IV) Hydroxy benzene The increasing order of boiling points of above mentioned alcohols is") ;
op1list.Add("I < II < III < IV") ;
op2list.Add("I < II < IV < III") ;
op3list.Add("IV < I < II < III") ; 
op4list.Add("IV < II < I < III") ;
corlist.Add("IV < I < II < III") ;


questionlist.Add( "The IUPAC name of C6H5COCl is") ;
op1list.Add("Benzoyl chloride") ;
op2list.Add("Benzene chloro ketone") ;
op3list.Add("Benzene carbonyl chloride") ;
op4list.Add("Chloro phenyl ketone") ;
corlist.Add("Benzene carbonyl chloride") ;

questionlist.Add("CuSO4 decolourises on addition of KCN, the product is") ;
op1list.Add("[Cu(CN)4]2−") ;
op2list.Add("Cu2+ get reduced to form [Cu(CN)4]3−") ;
op3list.Add( "Cu(CN)2") ;
op4list.Add("CuCN") ;
corlist.Add("CuCN") ;

questionlist.Add("If the bond length of CO bond in carbon monoxide is 1.128A, then what is the value of CO bond length in Fe(CO)5");
op1list.Add("1.15A") ;
op2list.Add("1.128A") ;
op3list.Add("1.72A") ;
op4list.Add("1.118A") ;
corlist.Add("1.15A") ;

questionlist.Add("The smallest ketone and its next homologue are reacted with NH2OH to form oxime") ;
op1list.Add("Two different oximes are formed") ; 
op2list.Add("Three different oximes are formed") ;
op3list.Add("Two oximes are optically active") ; 
op4list.Add("All oximes are optically active") ;
corlist.Add("Three different oximes are formed") ;

questionlist.Add("The number of structural isomers for C6H14 is") ;
op1list.Add("3") ;
op2list.Add("4") ;
op3list.Add("5") ;
op4list.Add("6") ;
corlist.Add("5") ;

questionlist.Add("When 20 g of naphthoic acid (C11H8O2) is dissolved in 50 g of benzene (Kf = 1.72 K kg mol−1), a freezing point depression of 2 K is observed. The van’t Hoff factor (i) is");
op1list.Add("0.5") ;
op2list.Add("1") ;
op3list.Add("2") ;
op4list.Add("3") ;
corlist.Add("0.5") ;

questionlist.Add("Among the following, the paramagnetic compound is") ;
op1list.Add("Na2O2") ;
op2list.Add("O3") ;
op3list.Add("N2O") ;
op4list.Add("KO2") ;
corlist.Add("KO2") ;

questionlist.Add("The species having bond order different from that in CO is") ;
op1list.Add("NO-") ;
op2list.Add("NO+") ;
op3list.Add("CN-") ;
op4list.Add("N2") ;
corlist.Add("NO-") ;

questionlist.Add("The percentage of p-character in the orbitals forming P−P bonds in P4 is") ;
op1list.Add("25") ;
op2list.Add("33") ;
op3list.Add("50") ;
op4list.Add("75") ;
corlist.Add("75") ;

questionlist.Add("Extraction of zinc from zinc blende is achieved by") ;
op1list.Add("electrolytic reduction") ;
op2list.Add("roasting followed by reduction with carbon") ;
op3list.Add("roasting followed by reduction with another metal") ;
op4list.Add("roasting followed by self-reduction") ;
corlist.Add("roasting followed by reduction with carbon") ;

questionlist.Add("STATEMENT-1: p-Hydroxybenzoic acid has a lower boiling point than o-hydroxybenzoic acid.\n STATEMENT-2: o-Hydroxybenzoic acid has intramolecular hydrogen bonding") ;
op1list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1 is True, Statement -2 is False") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is False, Statement-2 is True") ;

questionlist.Add("STATEMENT-1: Micelles are formed by surfactant molecules above the critical micellar concentration (CMC).\n STATEMENT-2: The conductivity of a solution having surfactant molecules decreases sharply at the CMC.") ;
op1list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1 is True, Statement-2 is False") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;

questionlist.Add("STATEMENT-1: Boron always forms covalent bond. \n STATEMENT-2: The small size of B3+ favours formation of covalent bond") ;
op1list.Add( "Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1 is True, Statement-2 is True") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;

questionlist.Add("STATEMENT-1: In water, orthoboric acid behaves as a weak monobasic acid. \n STATEMENT-2: In water, orthoboric acid acts as a proton donor") ;
op1list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is a correct explanation for Statement-1") ;
op2list.Add("Statement-1 is True, Statement-2 is True; Statement-2 is NOT a correct explanation for Statement-1") ;
op3list.Add("Statement-1is True, Statement-2 is False") ;
op4list.Add("Statement-1 is False, Statement-2 is True") ;
corlist.Add("Statement-1 is True, Statement-2 is False") ; 

questionlist.Add("In a mixture of H−He+ gas (He+ is singly ionized He atom), H atoms and He+ ions are excited to their respective first excited states. Subsequently, H atoms transfer their total excitation energy to He+ ions (by collisions). Assume that the Bohr model of atom is exactly valid. The quantum number n of the state finally populated in He+ ions is") ;
op1list.Add("2") ;
op2list.Add("3") ;
op3list.Add("4") ;
op4list.Add("5") ;
corlist.Add("4") ;

questionlist.Add("Consider a reaction aG + bH → Products. When concentration of both the reactants G and H is doubled, the rate increases by eight times. However, when concentration of G is doubled keeping the concentration of H fixed, the rate is doubled. The overall order of the reaction is") ;
op1list.Add("0") ;
op2list.Add("1") ;
op3list.Add("2") ;
op4list.Add("3") ;
corlist.Add("3") ;
        }




        public BlankPage5()
        {
            this.InitializeComponent();
            dt.Interval = TimeSpan.FromSeconds(15);
            timedisp.Interval = TimeSpan.FromSeconds(1);
            timedisp.Tick += timedisp_Tick;
            timedisp.Start();
            dt.Tick += dt_Tick;
            generatequestions();
        }
        void timedisp_Tick(object sender, object e)
        {
            time.Text = DateTime.Now.ToString();
        }
       async void dt_Tick(object sender, object e)
        {
            if (_1.IsChecked == false && _2.IsChecked == false && _3.IsChecked == false && _4.IsChecked == false)
            {
                MessageDialog md = new MessageDialog("===choose an option===");
                await md.ShowAsync();
                dt.Stop();
            }
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            showNextques();
        }
        int qno;
        private void start_Click(object sender, RoutedEventArgs e)
        {
            //START QUIZ LOGIC

            
        }
        void showNextques()
        {
            Random r = new Random();
            int q = r.Next(0, questionlist.Count);
            txtbox.Text = questionlist.ElementAt(q);
            _1.Content = op1list.ElementAt(q);
            _2.Content = op2list.ElementAt(q);
            _3.Content = op3list.ElementAt(q);
            _4.Content = op4list.ElementAt(q);
            qno = q;
            dt.Start();

        }

     
        int count = 0;
        int ttl=0;

        async void submitTheQuestion()
        {
            ttl = ttl + 1;
            dt.Stop();
            string ans;
            if (_1.IsChecked == true)
            {
                ans = _1.Content.ToString();
            }
            else if (_2.IsChecked == true)
            {
                ans = _2.Content.ToString();
            }
            else if (_3.IsChecked == true)
            {
                ans = _3.Content.ToString();
            }
            else
            {
                ans = _4.Content.ToString();
            }
           
          
            if (ans.Equals(corlist.ElementAt(qno)))
            {
                count = count + 1;
                MessageDialog md = new MessageDialog("===COrrect answer===");
                await md.ShowAsync();
                showNextques();
            }
          
            else if (_1.IsChecked == false && _2.IsChecked == false && _3.IsChecked == false && _4.IsChecked == false)
            {
                MessageDialog md = new MessageDialog("===choose an option===");
                await md.ShowAsync();
                
            }
            else
            {
                MessageDialog md = new MessageDialog("is correct answer\n\n===Your answer is InCOrrect===", corlist.ElementAt(qno));
                await md.ShowAsync();
                showNextques();
            }
                
                if (_1.IsChecked == true)
                    _1.IsChecked = false;
                if (_2.IsChecked == true)
                    _2.IsChecked = false;
                if (_3.IsChecked == true)
                    _3.IsChecked = false;
                if (_4.IsChecked == true)
                    _4.IsChecked = false;

        }

       
        private void sub_Click_1(object sender, RoutedEventArgs e)
        {
            submitTheQuestion();
        }

       async private void end_Click(object sender, RoutedEventArgs e)
        {
            if (ttl == 0)
            { ttl = 1; }
            string s = count.ToString();
            string k = ttl.ToString();
            dt.Stop();
            MessageDialog md = new MessageDialog(s + " correct answer(s) out of " + k + " questions", "Score card :");
            await md.ShowAsync();
            this.Frame.Navigate(typeof(BlankPage7));
        }

      

        
    }
    
    }


    
       

    