using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NBitcoin;
using QBitNinja;
using QBitNinja.Client;

namespace NBitcoinWallet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


 // Generate Addresses via Private Key

        private void btnPrivateKey_Click(object sender, EventArgs e)
        {
            var privatekey = new Key();          // generate private key locally from our device
            var btcprivatekey = privatekey.GetWif(Network.Main).ToString();     // use main network
            lblprivatekey.Text = btcprivatekey;                 // dispay private key

            // generate public key from our private key
            var btcpublickey = privatekey.PubKey.ToString();

            // generate address from our private key
            var btcaddress1 = privatekey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            lblprivkeyaddress.Text = btcaddress1.ToString();        // display address

            // check balance of Private Key(addresses)
            decimal balance1 = CheckBalance(btcaddress1.ToString());
            lblbalance1.Text = balance1.ToString();
        }

// Generate Addresses via Mnemonic Seed Phrase

        private void btnGenerateSeed_Click(object sender, EventArgs e)
        {
            var mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);       // generate Mnemonic Phrase in English with 12 distinct words
            lblmnemonic.Text = mnemo.ToString();            // display Mnemonic seed

            // generate address
            var hdroot = mnemo.DeriveExtKey();          // derive External Key
            var pkey = hdroot.Derive(new KeyPath("m/84'/0'/0'/0/0'"));      // format used to derive private key using the specified KeyPath

            // generate address from public key
            var address = pkey.PrivateKey.PubKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main).ToString();      // using main network
            lbladdressmnemonic.Text = address.ToString();       // display address

           // check balance of Mnemonic Phrase(addresess)
            decimal balanace2 = CheckBalance(address.ToString());
            lblbalance2.Text = balanace2.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load Form
        }


//  Check Balance of Address


    public Decimal CheckBalance(string address)
        {
            QBitNinjaClient client = new QBitNinjaClient(Network.Main);
            var balancemodel = client.GetBalance(address, false).Result;     // checks if coin has been spent & returns result
            decimal addressbalance=0;

            if (balancemodel.Operations.Count == 0)
            {
                addressbalance = 0;             // Returns 0 if BTC balance is nill
            }
            else
            {
                var unspentcoins = new List<Coin>();
                foreach(var operation in balancemodel.Operations)
                {
                    unspentcoins.AddRange(operation.ReceivedCoins.Select(Coin => Coin as Coin));
                    addressbalance=unspentcoins.Sum(x=>x.Amount.ToDecimal(MoneyUnit.BTC));
                }
            }

            return addressbalance;
        }
    }
}
