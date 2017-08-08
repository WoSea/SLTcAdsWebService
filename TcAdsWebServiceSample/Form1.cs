using System; 
using System.Web.Services.Protocols; // Catches the SoapExceptions

using System.Windows.Forms; 

namespace TcAdsWebServiceSample
{
	public partial class Form1 : Form
	{ 
		#region variables and instances

		// Encodes byte-array to Strings and vice versa
		private System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();

		// Instance of the TcAdsWebService
		//private TcAdsWebService TcWebService = new TcAdsWebService();
		private TcAdsWebService1.TcAdsWebService TcWebService = new TcAdsWebService1.TcAdsWebService();

		//http://192.168.6.19/TcAdsWebService/TcAdsWebService.WSDL
		//private string szWebServiceUrl = "http://192.168.6.19/TcAdsWebService/TcAdsWebService.dll"; http://192.168.6.19/TcAdsWebService/TcAdsWebService.dll
		//private string szWebServiceUrl = "http://192.168.137.169/tcadswebservice/tcadswebservice.dll"; http://192.168.137.169/TcAdsWebService/TcAdsWebService.dll
		private string szWebServiceUrl = "http://localhost/tcadswebservice/tcadswebservice.dll";// http://localhost/TcAdsWebService/TcAdsWebService.dll

		public string szAmsNetId = "192.168.26.2.1.1";
		public int iPort = 851; //TwinCAT Project->PLC->PLC Project->Rightclick, choose Change ADS port
		public uint iIndexGroup = 0x4020;//0x4021;
		//https://infosys.beckhoff.com/english.php?content=../content/1033/tcadsdeviceplc/html/tcadsdeviceplc_indexadsservice.htm&id=
		#endregion
		public Form1()
		{
			InitializeComponent();
			// Links the WebService with its library
		 	TcWebService.Url = szWebServiceUrl;
		 	textBoxUrl.Text = szWebServiceUrl;
		 	textBoxNetId.Text = szAmsNetId;
		 	textBoxPort.Text = iPort.ToString();
			#region 
			//TcWebService.Url = "http://localhost/tcadswebservice/tcadswebservice.dll";

			// Sample 1 : 
			//TcWebService.Url = "http://192.168.6.19/TcAdsWebService/TcAdsWebService.dll";

			// Sample 2 :  
			//TcWebService.Url = "http://CX_xxxxxx/TcAdsWebService/TcAdsWebService.dll";
			#endregion
		}

		private void Read_Click(object sender, EventArgs e)
		{
			// DataBuffer for the incoming data
		 	byte[] abDataBuffer = new byte[84]; //1 byte for "PlcVarBool", 2 bytes for "PlcVarInt" and 81 bytes for "PlcVarString" = 84 bytes
		 
			try
			{
				 TcWebService.Read(szAmsNetId, iPort, iIndexGroup, 0, 84, out abDataBuffer); 
				//TcWebService.Read("192.168.26.2.1.1",851,0x4020,0,84,out abDataBuffer);
				#region Note arguments deteail
				/*
				string netId: String indicating the AMS-Net-Id of the PLC
			   int nPort: Port-number of the Runtime-System
			   System.UInt32 indexGroup: IndexGroup of the variables to read
			   System.UInt32 indexOffset: First byte to read
			   int cblen: Number of bytes to read
			   out System.Byte[] ppData: Byte-array to save the PLC-data into*/
				#endregion
				// Converts the first byte of the buffer to bool
				bool bVarBool = BitConverter.ToBoolean(abDataBuffer, 0);

				// Converts the second and third byte of the buffer to int
				 int iVarInt = BitConverter.ToInt16(abDataBuffer, 1); 

				// Converts the other bytes of the buffer to string
				 string szVarString = encoder.GetString(abDataBuffer, 3, 81); 

				// Writes values into the text-boxes
				textBoxBool.Text = bVarBool.ToString();
				textBoxInt.Text = iVarInt.ToString();
				textBoxString.Text = szVarString; 
			}
			catch (SoapException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Write_Click(object sender, EventArgs e)
		{
			try
			{
				// byte-arrays for the variables
				 	byte[] abDataBool = new byte[1];
				 	byte[] abDataInt = new byte[2];
				 	byte[] abDataString = new byte[81]; 

				// Gets values for the text-boxes
				bool bValueBool = Convert.ToBoolean(textBoxBool.Text);
				int iValueInt = Convert.ToInt16(textBoxInt.Text);
				string szValueString = textBoxString.Text;


				// Converting variables to byte-arrays
				abDataBool = BitConverter.GetBytes(bValueBool);
				abDataInt = BitConverter.GetBytes((Int16)iValueInt);

				encoder.GetBytes(szValueString,     // Source
								0,       // Position of the first character to convert
								encoder.GetByteCount(szValueString),    // Gets the length of the source
								abDataString,              // Byte-array to save the conversion to
									0);              // First byte in the array to save the conversion to


				// Writing values to PLC
				TcWebService.Write(szAmsNetId, iPort, iIndexGroup, 0, abDataBool);
 
				TcWebService.Write(szAmsNetId, iPort, iIndexGroup, 1, abDataInt);
				TcWebService.Write(szAmsNetId, iPort, iIndexGroup, 3, abDataString);  
			}
			catch (SoapException ex)
			{
				MessageBox.Show(ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
