using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NetMQ;
using NetMQ.Sockets;

namespace GMix {
	public partial class frmMain : Form {
		RequestSocket m_requester = null;
		public frmMain() {
			InitializeComponent();
			m_requester = new RequestSocket();
			m_requester.Connect("tcp://localhost:5555");
		}
	}
}
