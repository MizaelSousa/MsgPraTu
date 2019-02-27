using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgPraTu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void CliqueDoBotao(Object sender, EventArgs e){

            Random random = new Random();

            string[] frases = { "A persistência é o caminho do êxito", 
                                "Lute. Acredite. Conquiste. Perca. Deseje. Espere. Alcance. Invada. Caia. Seja tudo o quiser ser, mas acima de tudo, seja você sempre",
                                "Só existe um êxito: a capacidade de levar a vida que se quer",
                                "A vitalidade é demonstrada não apenas pela persistência, mas pela capacidade de começar de novo",
                                "A coragem não é ausência do medo; é a persistência apesar do medo" };

            int index = random.Next(0, 4);

            label_status.Text = frases[index];

            button_clique.Text = "Novo Botao";


        } 
    }
}
