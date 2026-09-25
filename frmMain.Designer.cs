namespace ns0
{
	// Token: 0x02000111 RID: 273
	internal sealed partial class frmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x0000C333 File Offset: 0x0000A533
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000FF9C4 File Offset: 0x000FDBC4
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.frmMain));
			this.statusStrip = new global::System.Windows.Forms.StatusStrip();
			this.lblLocation = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblCharLoc = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.imgBuyHour = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.lblRemainHours = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.pnelLog = new global::System.Windows.Forms.Panel();
			this.btnOpenLog = new global::System.Windows.Forms.Button();
			this.richLog = new global::System.Windows.Forms.RichTextBox();
			this.tabDieuKhien = new global::System.Windows.Forms.TabControl();
			this.tabCoBan = new global::System.Windows.Forms.TabPage();
			this.groupNgaMi = new global::System.Windows.Forms.GroupBox();
			this.label67 = new global::System.Windows.Forms.Label();
			this.numBuffPhamVi = new global::System.Windows.Forms.NumericUpDown();
			this.cboxNMBuffSelectTarget = new global::System.Windows.Forms.CheckBox();
			this.numBuffPartyPercent = new global::System.Windows.Forms.NumericUpDown();
			this.cboxNMUutienboc = new global::System.Windows.Forms.CheckBox();
			this.numNgaMyBuff = new global::System.Windows.Forms.NumericUpDown();
			this.btnPetList = new global::System.Windows.Forms.Button();
			this.cboxPetList = new global::System.Windows.Forms.CheckBox();
			this.cboxNMUutienself = new global::System.Windows.Forms.CheckBox();
			this.cboxNMBuff = new global::System.Windows.Forms.CheckBox();
			this.btnListNMBuff = new global::System.Windows.Forms.Button();
			this.lblNMParty = new global::System.Windows.Forms.Label();
			this.cboxNMBuffQuanDoan = new global::System.Windows.Forms.CheckBox();
			this.cboxNMBuffList = new global::System.Windows.Forms.CheckBox();
			this.lblNMPQSecond = new global::System.Windows.Forms.Label();
			this.numBuffPet = new global::System.Windows.Forms.NumericUpDown();
			this.numPhatQuangDelay = new global::System.Windows.Forms.NumericUpDown();
			this.cboxBuffPet = new global::System.Windows.Forms.CheckBox();
			this.cboxPhatQuangPhoChieu = new global::System.Windows.Forms.CheckBox();
			this.label32 = new global::System.Windows.Forms.Label();
			this.groupPhucHoi = new global::System.Windows.Forms.GroupBox();
			this.cboxAOE = new global::System.Windows.Forms.CheckBox();
			this.cboPetHuyetTe = new global::System.Windows.Forms.ComboBox();
			this.cboPetChien = new global::System.Windows.Forms.ComboBox();
			this.cboxHuyetTe = new global::System.Windows.Forms.CheckBox();
			this.cboPetCongSinh = new global::System.Windows.Forms.ComboBox();
			this.label29 = new global::System.Windows.Forms.Label();
			this.numPetHPPercent = new global::System.Windows.Forms.NumericUpDown();
			this.cboxCongSinh = new global::System.Windows.Forms.CheckBox();
			this.numMPPercent = new global::System.Windows.Forms.NumericUpDown();
			this.numHPPercent = new global::System.Windows.Forms.NumericUpDown();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.groupDanhQuai = new global::System.Windows.Forms.GroupBox();
			this.numGomMode = new global::System.Windows.Forms.NumericUpDown();
			this.btnDanhTheoAi = new global::System.Windows.Forms.Button();
			this.rdioDanhTheoAi = new global::System.Windows.Forms.RadioButton();
			this.rdioDanhTheoKey = new global::System.Windows.Forms.RadioButton();
			this.numDistance = new global::System.Windows.Forms.NumericUpDown();
			this.cboxBanKinh = new global::System.Windows.Forms.CheckBox();
			this.btnQuaiKoDanh = new global::System.Windows.Forms.Button();
			this.cboxNoKS = new global::System.Windows.Forms.CheckBox();
			this.groupTheoSau = new global::System.Windows.Forms.GroupBox();
			this.rdioTheoSauAiDo = new global::System.Windows.Forms.RadioButton();
			this.rdioTheoSauPT = new global::System.Windows.Forms.RadioButton();
			this.numTheoSau = new global::System.Windows.Forms.NumericUpDown();
			this.cboxTheoSau = new global::System.Windows.Forms.CheckBox();
			this.btnDiTheoAi = new global::System.Windows.Forms.Button();
			this.txtTheoSauName = new global::System.Windows.Forms.TextBox();
			this.txtDanhTheoAi = new global::System.Windows.Forms.TextBox();
			this.cboTrainMaps = new global::System.Windows.Forms.ComboBox();
			this.cboxDanhQuai = new global::System.Windows.Forms.CheckBox();
			this.btnHoiSucLenBai = new global::System.Windows.Forms.Button();
			this.rdioGomQuai = new global::System.Windows.Forms.RadioButton();
			this.btnLenBai = new global::System.Windows.Forms.Button();
			this.numRadius = new global::System.Windows.Forms.NumericUpDown();
			this.modeTUNGCON = new global::System.Windows.Forms.RadioButton();
			this.btnGetCurrentPos = new global::System.Windows.Forms.Button();
			this.txtToaDoY = new global::System.Windows.Forms.TextBox();
			this.txtToaDoX = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.cboxOnlyPet = new global::System.Windows.Forms.CheckBox();
			this.tabKyNang = new global::System.Windows.Forms.TabPage();
			this.groupPKSkills = new global::System.Windows.Forms.GroupBox();
			this.btnPhanPKExpand = new global::System.Windows.Forms.Button();
			this.label66 = new global::System.Windows.Forms.Label();
			this.numPKThoatGame = new global::System.Windows.Forms.NumericUpDown();
			this.cboxPKThoatGame = new global::System.Windows.Forms.CheckBox();
			this.cboxNMPKBuff = new global::System.Windows.Forms.CheckBox();
			this.cboxPKTuVe = new global::System.Windows.Forms.CheckBox();
			this.label37 = new global::System.Windows.Forms.Label();
			this.label52 = new global::System.Windows.Forms.Label();
			this.numPKSkill = new global::System.Windows.Forms.NumericUpDown();
			this.cboPKSkills = new global::System.Windows.Forms.ComboBox();
			this.btnPKRemove = new global::System.Windows.Forms.Button();
			this.btnPKEdit = new global::System.Windows.Forms.Button();
			this.btnPKThem = new global::System.Windows.Forms.Button();
			this.lvPKSkills = new global::System.Windows.Forms.ListView();
			this.columnHeader_31 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_32 = new global::System.Windows.Forms.ColumnHeader();
			this.groupSkillBuff = new global::System.Windows.Forms.GroupBox();
			this.btnSkillBuffThem = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.btnSkillBuffExpand = new global::System.Windows.Forms.Button();
			this.numSkillBuffLength = new global::System.Windows.Forms.NumericUpDown();
			this.numSkillBuffDelay = new global::System.Windows.Forms.NumericUpDown();
			this.cboSkillBuff = new global::System.Windows.Forms.ComboBox();
			this.cboxBuffHoTroOnOff = new global::System.Windows.Forms.CheckBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label55 = new global::System.Windows.Forms.Label();
			this.label54 = new global::System.Windows.Forms.Label();
			this.label53 = new global::System.Windows.Forms.Label();
			this.cboxBuffQuanDoan = new global::System.Windows.Forms.CheckBox();
			this.cboxBuffDanhSach = new global::System.Windows.Forms.CheckBox();
			this.cboxBuffDongDoi = new global::System.Windows.Forms.CheckBox();
			this.cboxBuffBanThan = new global::System.Windows.Forms.CheckBox();
			this.label49 = new global::System.Windows.Forms.Label();
			this.label36 = new global::System.Windows.Forms.Label();
			this.btnSkillBuffDelete = new global::System.Windows.Forms.Button();
			this.lvSkillBuff = new global::System.Windows.Forms.ListView();
			this.columnHeader_25 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_26 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_33 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_27 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_28 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_29 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_30 = new global::System.Windows.Forms.ColumnHeader();
			this.groupKyNang = new global::System.Windows.Forms.GroupBox();
			this.btnXepTen1 = new global::System.Windows.Forms.Button();
			this.btnSkillPhaiExpand = new global::System.Windows.Forms.Button();
			this.cboxSkillOnOff = new global::System.Windows.Forms.CheckBox();
			this.label28 = new global::System.Windows.Forms.Label();
			this.label27 = new global::System.Windows.Forms.Label();
			this.numSkillDelay = new global::System.Windows.Forms.NumericUpDown();
			this.cboSkills = new global::System.Windows.Forms.ComboBox();
			this.btnXoaSkillPlayList = new global::System.Windows.Forms.Button();
			this.btnSuaSkillPlayList = new global::System.Windows.Forms.Button();
			this.btnThemSkill = new global::System.Windows.Forms.Button();
			this.lvSkills = new global::System.Windows.Forms.ListView();
			this.columnHeader_23 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_24 = new global::System.Windows.Forms.ColumnHeader();
			this.tabVatPham = new global::System.Windows.Forms.TabPage();
			this.btnCheDoSettings = new global::System.Windows.Forms.Button();
			this.label75 = new global::System.Windows.Forms.Label();
			this.btnCD50acc = new global::System.Windows.Forms.Button();
			this.btnCD5acc = new global::System.Windows.Forms.Button();
			this.btnCD2acc = new global::System.Windows.Forms.Button();
			this.btnSellNow = new global::System.Windows.Forms.Button();
			this.lblCDCount = new global::System.Windows.Forms.Label();
			this.lblCDTime = new global::System.Windows.Forms.Label();
			this.rdioNhatListIgnore = new global::System.Windows.Forms.RadioButton();
			this.btnHuyNow = new global::System.Windows.Forms.Button();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupItemUse = new global::System.Windows.Forms.GroupBox();
			this.btnItemUse = new global::System.Windows.Forms.Button();
			this.btnItemUseExpand = new global::System.Windows.Forms.Button();
			this.label45 = new global::System.Windows.Forms.Label();
			this.lvItemUse = new global::System.Windows.Forms.ListView();
			this.columnHeader_36 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_37 = new global::System.Windows.Forms.ColumnHeader();
			this.numItemUse = new global::System.Windows.Forms.NumericUpDown();
			this.cboItemUse = new global::System.Windows.Forms.ComboBox();
			this.groupMuaDo = new global::System.Windows.Forms.GroupBox();
			this.btnMuaNgay_KNB = new global::System.Windows.Forms.Button();
			this.btnMuaDoExpand = new global::System.Windows.Forms.Button();
			this.btnMuaNgay = new global::System.Windows.Forms.Button();
			this.lvItemMua = new global::System.Windows.Forms.ListView();
			this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_6 = new global::System.Windows.Forms.ColumnHeader();
			this.numItemMua = new global::System.Windows.Forms.NumericUpDown();
			this.btnItemMuaThem = new global::System.Windows.Forms.Button();
			this.cboItemMua = new global::System.Windows.Forms.ComboBox();
			this.cboxGiamDinh = new global::System.Windows.Forms.CheckBox();
			this.cboxIsCheDo = new global::System.Windows.Forms.CheckBox();
			this.numBanKinhNhat = new global::System.Windows.Forms.NumericUpDown();
			this.cboxGiuVuKhi = new global::System.Windows.Forms.CheckBox();
			this.rdioNhatHet = new global::System.Windows.Forms.RadioButton();
			this.numFullThung = new global::System.Windows.Forms.NumericUpDown();
			this.cboxFullStopNhat = new global::System.Windows.Forms.CheckBox();
			this.cboxFullThungVT = new global::System.Windows.Forms.CheckBox();
			this.cboItemTuHuy = new global::System.Windows.Forms.CheckBox();
			this.cboxTuMuaBan = new global::System.Windows.Forms.CheckBox();
			this.numGiuDoDong = new global::System.Windows.Forms.NumericUpDown();
			this.label41 = new global::System.Windows.Forms.Label();
			this.numGiuDoSao = new global::System.Windows.Forms.NumericUpDown();
			this.label40 = new global::System.Windows.Forms.Label();
			this.cboxVutDoKhiFull = new global::System.Windows.Forms.CheckBox();
			this.cboxTuNhatVatPham = new global::System.Windows.Forms.CheckBox();
			this.rdioNhatList = new global::System.Windows.Forms.RadioButton();
			this.btnListNhatIgnore = new global::System.Windows.Forms.Button();
			this.btnItemTuBan = new global::System.Windows.Forms.Button();
			this.btnListTuHuy = new global::System.Windows.Forms.Button();
			this.btnListNhat = new global::System.Windows.Forms.Button();
			this.tabThuongNhan = new global::System.Windows.Forms.TabPage();
			this.groupThuongNhan = new global::System.Windows.Forms.GroupBox();
			this.cboxFixKetThanh = new global::System.Windows.Forms.CheckBox();
			this.rdioTNTheoChiDinh = new global::System.Windows.Forms.RadioButton();
			this.groupTNThanhMinh = new global::System.Windows.Forms.GroupBox();
			this.tboxIDBang = new global::System.Windows.Forms.TextBox();
			this.txtTNMinhGiaHigher = new global::System.Windows.Forms.TextBox();
			this.cboxTNMinhGiaHigher = new global::System.Windows.Forms.CheckBox();
			this.lblTNMinhGia = new global::System.Windows.Forms.Label();
			this.cboTNMinhItem = new global::System.Windows.Forms.ComboBox();
			this.label69 = new global::System.Windows.Forms.Label();
			this.groupTNThanhFriend = new global::System.Windows.Forms.GroupBox();
			this.txtTNFriendGia = new global::System.Windows.Forms.TextBox();
			this.tboxIDFriend = new global::System.Windows.Forms.TextBox();
			this.cboxTNFriendGiaHigher = new global::System.Windows.Forms.CheckBox();
			this.lblTNFriendGia = new global::System.Windows.Forms.Label();
			this.cboTNFriendItem = new global::System.Windows.Forms.ComboBox();
			this.label65 = new global::System.Windows.Forms.Label();
			this.btnXoaDuLieuTN = new global::System.Windows.Forms.Button();
			this.btnChayHuongNao = new global::System.Windows.Forms.Button();
			this.cboxTNTuNhanPhieu = new global::System.Windows.Forms.CheckBox();
			this.lblPath = new global::System.Windows.Forms.Label();
			this.rdioTNAutoMua = new global::System.Windows.Forms.RadioButton();
			this.numTNRounds = new global::System.Windows.Forms.NumericUpDown();
			this.label46 = new global::System.Windows.Forms.Label();
			this.btnTNStop = new global::System.Windows.Forms.Button();
			this.btnTNChayVe = new global::System.Windows.Forms.Button();
			this.btnTNChayDi = new global::System.Windows.Forms.Button();
			this.cboxTNFullAuto = new global::System.Windows.Forms.CheckBox();
			this.tabNhiemVu = new global::System.Windows.Forms.TabPage();
			this.groupYTO = new global::System.Windows.Forms.GroupBox();
			this.lblYTOTimer = new global::System.Windows.Forms.Label();
			this.cboxYTOGiaHan = new global::System.Windows.Forms.CheckBox();
			this.btnYTO3h = new global::System.Windows.Forms.Button();
			this.btnYTO1h = new global::System.Windows.Forms.Button();
			this.btnDiCanTro = new global::System.Windows.Forms.Button();
			this.cboxIsYTO = new global::System.Windows.Forms.CheckBox();
			this.btnYTOExtend = new global::System.Windows.Forms.Button();
			this.groupQ123 = new global::System.Windows.Forms.GroupBox();
			this.cboQ12Xong = new global::System.Windows.Forms.ComboBox();
			this.label44 = new global::System.Windows.Forms.Label();
			this.cboxPTYeu = new global::System.Windows.Forms.CheckBox();
			this.cboxQ12AutoExtend = new global::System.Windows.Forms.CheckBox();
			this.btnQ12Mua3H = new global::System.Windows.Forms.Button();
			this.btnQ12Mua1H = new global::System.Windows.Forms.Button();
			this.lblQ123Timer = new global::System.Windows.Forms.Label();
			this.numQ12Level = new global::System.Windows.Forms.NumericUpDown();
			this.cboxQ12Level = new global::System.Windows.Forms.CheckBox();
			this.label39 = new global::System.Windows.Forms.Label();
			this.cboxTuHuyNV = new global::System.Windows.Forms.CheckBox();
			this.label38 = new global::System.Windows.Forms.Label();
			this.numQ12ChoPT = new global::System.Windows.Forms.NumericUpDown();
			this.cboxHongQPT = new global::System.Windows.Forms.CheckBox();
			this.cboQ1Cau = new global::System.Windows.Forms.ComboBox();
			this.lblQ1Cau = new global::System.Windows.Forms.Label();
			this.cboxIsQ2 = new global::System.Windows.Forms.CheckBox();
			this.cboxIsQ1 = new global::System.Windows.Forms.CheckBox();
			this.btnQ12GroupExpand = new global::System.Windows.Forms.Button();
			this.cboxDiTheoPP = new global::System.Windows.Forms.CheckBox();
			this.groupBaoRuong = new global::System.Windows.Forms.GroupBox();
			this.cboxLLTBNhanh = new global::System.Windows.Forms.CheckBox();
			this.cboxLLTB = new global::System.Windows.Forms.CheckBox();
			this.cboxPMP = new global::System.Windows.Forms.CheckBox();
			this.cboxBRTLC = new global::System.Windows.Forms.CheckBox();
			this.cboxBRXaPhu = new global::System.Windows.Forms.CheckBox();
			this.cboBaoRuongMap = new global::System.Windows.Forms.ComboBox();
			this.label34 = new global::System.Windows.Forms.Label();
			this.cboxNhanHop = new global::System.Windows.Forms.CheckBox();
			this.cboxNhatHop = new global::System.Windows.Forms.CheckBox();
			this.cboxIsDoatBaoRuong = new global::System.Windows.Forms.CheckBox();
			this.btnBaoRuongExpand = new global::System.Windows.Forms.Button();
			this.groupQSM = new global::System.Windows.Forms.GroupBox();
			this.label64 = new global::System.Windows.Forms.Label();
			this.numQSMMax = new global::System.Windows.Forms.NumericUpDown();
			this.cboxDongMon = new global::System.Windows.Forms.CheckBox();
			this.btnQSMDiVe = new global::System.Windows.Forms.Button();
			this.cboxCauNguyen = new global::System.Windows.Forms.CheckBox();
			this.cboxCauPhuc = new global::System.Windows.Forms.CheckBox();
			this.cboxIsQSM = new global::System.Windows.Forms.CheckBox();
			this.btnPHLMExpand = new global::System.Windows.Forms.Button();
			this.groupTKC = new global::System.Windows.Forms.GroupBox();
			this.cboxKyCuocNhanh = new global::System.Windows.Forms.CheckBox();
			this.label33 = new global::System.Windows.Forms.Label();
			this.RightY = new global::System.Windows.Forms.TextBox();
			this.RightX = new global::System.Windows.Forms.TextBox();
			this.label31 = new global::System.Windows.Forms.Label();
			this.leftY = new global::System.Windows.Forms.TextBox();
			this.leftX = new global::System.Windows.Forms.TextBox();
			this.cboxKyCuoc = new global::System.Windows.Forms.CheckBox();
			this.cboxIsTKC = new global::System.Windows.Forms.CheckBox();
			this.cboxIsPHLM = new global::System.Windows.Forms.CheckBox();
			this.cboxTKCNhanh = new global::System.Windows.Forms.CheckBox();
			this.cboTKCMaps = new global::System.Windows.Forms.ComboBox();
			this.btnTKCEx = new global::System.Windows.Forms.Button();
			this.label17 = new global::System.Windows.Forms.Label();
			this.groupTBB = new global::System.Windows.Forms.GroupBox();
			this.cboxHuyNVNhatDo = new global::System.Windows.Forms.CheckBox();
			this.cboxThuHoachHoaChinhMinh = new global::System.Windows.Forms.CheckBox();
			this.cboxBHDThoatKhiXong = new global::System.Windows.Forms.CheckBox();
			this.cboxHuyNVDanhQuai = new global::System.Windows.Forms.CheckBox();
			this.numsoHangTrongHoa = new global::System.Windows.Forms.NumericUpDown();
			this.label56 = new global::System.Windows.Forms.Label();
			this.numBHDBanKinh = new global::System.Windows.Forms.NumericUpDown();
			this.cboxThuHoach = new global::System.Windows.Forms.CheckBox();
			this.cboxBonHoa = new global::System.Windows.Forms.CheckBox();
			this.cboxTrongHoa = new global::System.Windows.Forms.CheckBox();
			this.numBHDMax = new global::System.Windows.Forms.NumericUpDown();
			this.cboxIsBachHoaDuyen = new global::System.Windows.Forms.CheckBox();
			this.cboxIsTuDuongCon = new global::System.Windows.Forms.CheckBox();
			this.label24 = new global::System.Windows.Forms.Label();
			this.cboTuDuongCon = new global::System.Windows.Forms.ComboBox();
			this.btnTBBExpand = new global::System.Windows.Forms.Button();
			this.btnBHDVe = new global::System.Windows.Forms.Button();
			this.groupMuaKNB = new global::System.Windows.Forms.GroupBox();
			this.btnMuaKNBExpand = new global::System.Windows.Forms.Button();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label73 = new global::System.Windows.Forms.Label();
			this.txtKNB500 = new global::System.Windows.Forms.TextBox();
			this.label74 = new global::System.Windows.Forms.Label();
			this.label71 = new global::System.Windows.Forms.Label();
			this.txtKNB200 = new global::System.Windows.Forms.TextBox();
			this.label72 = new global::System.Windows.Forms.Label();
			this.label70 = new global::System.Windows.Forms.Label();
			this.txtKNB50 = new global::System.Windows.Forms.TextBox();
			this.label68 = new global::System.Windows.Forms.Label();
			this.btnMuaKNB = new global::System.Windows.Forms.Button();
			this.groupLuyenKim = new global::System.Windows.Forms.GroupBox();
			this.cboxIsTBB = new global::System.Windows.Forms.CheckBox();
			this.cboxTBBchaynhanh = new global::System.Windows.Forms.CheckBox();
			this.cboxIsXayDung = new global::System.Windows.Forms.CheckBox();
			this.cboTuBaoBon = new global::System.Windows.Forms.ComboBox();
			this.cboxLuyenKim = new global::System.Windows.Forms.CheckBox();
			this.cboxXDXaPhu = new global::System.Windows.Forms.CheckBox();
			this.cboxTBBPhiThuy = new global::System.Windows.Forms.CheckBox();
			this.cboxXayDungPhu = new global::System.Windows.Forms.CheckBox();
			this.lblTBBCounter = new global::System.Windows.Forms.Label();
			this.btnLKExpand = new global::System.Windows.Forms.Button();
			this.cboxXDHoiMau = new global::System.Windows.Forms.CheckBox();
			this.cboxLuyenKimCham = new global::System.Windows.Forms.CheckBox();
			this.cboxLKTuNhanNV = new global::System.Windows.Forms.CheckBox();
			this.groupTrungAc = new global::System.Windows.Forms.GroupBox();
			this.btnTanThu = new global::System.Windows.Forms.Button();
			this.cboxTanThu = new global::System.Windows.Forms.CheckBox();
			this.cboxIsTrungAc = new global::System.Windows.Forms.CheckBox();
			this.cboxBTDXaPhu = new global::System.Windows.Forms.CheckBox();
			this.cboxBTDPhuVe = new global::System.Windows.Forms.CheckBox();
			this.cboxIsBTD = new global::System.Windows.Forms.CheckBox();
			this.cboxTAXaPhu = new global::System.Windows.Forms.CheckBox();
			this.cboxTAPhuLD = new global::System.Windows.Forms.CheckBox();
			this.cboxTAPhuToChau = new global::System.Windows.Forms.CheckBox();
			this.btnTAExpand = new global::System.Windows.Forms.Button();
			this.cboxTANhanNV = new global::System.Windows.Forms.CheckBox();
			this.cboxTAHoiPhuc = new global::System.Windows.Forms.CheckBox();
			this.cboxTAPhuDL = new global::System.Windows.Forms.CheckBox();
			this.groupAcTac = new global::System.Windows.Forms.GroupBox();
			this.cboxATRunPP = new global::System.Windows.Forms.CheckBox();
			this.cboxChoParty = new global::System.Windows.Forms.CheckBox();
			this.cboxABChayTim = new global::System.Windows.Forms.CheckBox();
			this.lblABPhai = new global::System.Windows.Forms.Label();
			this.cboxIsLinhThu = new global::System.Windows.Forms.CheckBox();
			this.cboxIsAcBa = new global::System.Windows.Forms.CheckBox();
			this.cboxIsAcTac = new global::System.Windows.Forms.CheckBox();
			this.cboxLTNhanVN = new global::System.Windows.Forms.CheckBox();
			this.btnATExpand = new global::System.Windows.Forms.Button();
			this.cboATMaps = new global::System.Windows.Forms.ComboBox();
			this.label62 = new global::System.Windows.Forms.Label();
			this.groupDuaHau = new global::System.Windows.Forms.GroupBox();
			this.label63 = new global::System.Windows.Forms.Label();
			this.cboxBuonDuaHau = new global::System.Windows.Forms.CheckBox();
			this.btnDuaHauExpand = new global::System.Windows.Forms.Button();
			this.cboxDuaHauCity = new global::System.Windows.Forms.ComboBox();
			this.cboDHAutoPick = new global::System.Windows.Forms.CheckBox();
			this.cboDHAutoNV = new global::System.Windows.Forms.CheckBox();
			this.cboDHAlertTuu = new global::System.Windows.Forms.CheckBox();
			this.txtDHBangID = new global::System.Windows.Forms.TextBox();
			this.label60 = new global::System.Windows.Forms.Label();
			this.btnDuaHauStart = new global::System.Windows.Forms.Button();
			this.cboxDuaHauMaps = new global::System.Windows.Forms.ComboBox();
			this.label59 = new global::System.Windows.Forms.Label();
			this.cboDHFromCity = new global::System.Windows.Forms.CheckBox();
			this.groupKhaiKhoang = new global::System.Windows.Forms.GroupBox();
			this.cboxNhatTuyetDungIm = new global::System.Windows.Forms.CheckBox();
			this.cboLocDuoc = new global::System.Windows.Forms.ComboBox();
			this.label47 = new global::System.Windows.Forms.Label();
			this.cboxNhatTuyet = new global::System.Windows.Forms.CheckBox();
			this.cboTTThuHoach = new global::System.Windows.Forms.CheckBox();
			this.lblTTCity = new global::System.Windows.Forms.Label();
			this.cboxIsTrongTrot = new global::System.Windows.Forms.CheckBox();
			this.cboxIsKhaiKhoang = new global::System.Windows.Forms.CheckBox();
			this.btnKKExpand = new global::System.Windows.Forms.Button();
			this.lblTTTime = new global::System.Windows.Forms.Label();
			this.btnTTNPC2Add = new global::System.Windows.Forms.Button();
			this.cboKhoangDuocMaps = new global::System.Windows.Forms.ComboBox();
			this.btnTTNPC1Add = new global::System.Windows.Forms.Button();
			this.label6 = new global::System.Windows.Forms.Label();
			this.cboTTTen = new global::System.Windows.Forms.ComboBox();
			this.txtTTNPC2_Y = new global::System.Windows.Forms.TextBox();
			this.cboxHaiDuoc = new global::System.Windows.Forms.CheckBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.txtTTNPC2_X = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.cboxKhaiKhoang = new global::System.Windows.Forms.CheckBox();
			this.cboTTLoai = new global::System.Windows.Forms.ComboBox();
			this.txtTTNPC2_ID = new global::System.Windows.Forms.TextBox();
			this.txtTTNPC1_ID = new global::System.Windows.Forms.TextBox();
			this.txtTTNPC1_Y = new global::System.Windows.Forms.TextBox();
			this.label57 = new global::System.Windows.Forms.Label();
			this.txtTTNPC1_X = new global::System.Windows.Forms.TextBox();
			this.label58 = new global::System.Windows.Forms.Label();
			this.groupPhuBanTuyChinh = new global::System.Windows.Forms.GroupBox();
			this.label30 = new global::System.Windows.Forms.Label();
			this.btnPhuBanRefresh = new global::System.Windows.Forms.Button();
			this.cboxPhuBanTuyChinh = new global::System.Windows.Forms.CheckBox();
			this.btnPhuBanOpen = new global::System.Windows.Forms.Button();
			this.cboPhuBanPP = new global::System.Windows.Forms.ComboBox();
			this.groupScheduler = new global::System.Windows.Forms.GroupBox();
			this.btnAutoPK = new global::System.Windows.Forms.Button();
			this.cboxAutoPK = new global::System.Windows.Forms.CheckBox();
			this.btnNhiemVu2 = new global::System.Windows.Forms.Button();
			this.label50 = new global::System.Windows.Forms.Label();
			this.btnScheduler = new global::System.Windows.Forms.Button();
			this.cboxScheduler = new global::System.Windows.Forms.CheckBox();
			this.tabTienIch = new global::System.Windows.Forms.TabPage();
			this.groupDied = new global::System.Windows.Forms.GroupBox();
			this.numChoHoiSinh = new global::System.Windows.Forms.NumericUpDown();
			this.cboxChoHoiSinh = new global::System.Windows.Forms.CheckBox();
			this.rdioThoatGame = new global::System.Windows.Forms.RadioButton();
			this.rdioUongTra = new global::System.Windows.Forms.RadioButton();
			this.label42 = new global::System.Windows.Forms.Label();
			this.rdioLenDiemTrain = new global::System.Windows.Forms.RadioButton();
			this.groupToDoi = new global::System.Windows.Forms.GroupBox();
			this.btnToDoiExpand = new global::System.Windows.Forms.Button();
			this.btnPTBlacklist = new global::System.Windows.Forms.Button();
			this.label12 = new global::System.Windows.Forms.Label();
			this.numPTLevel = new global::System.Windows.Forms.NumericUpDown();
			this.btnPTChoVao = new global::System.Windows.Forms.Button();
			this.cboxPTChoVao = new global::System.Windows.Forms.CheckBox();
			this.cboxPTLevel = new global::System.Windows.Forms.CheckBox();
			this.btnPTAcceptList = new global::System.Windows.Forms.Button();
			this.cboxTuVaoPT = new global::System.Windows.Forms.CheckBox();
			this.groupVeThanh = new global::System.Windows.Forms.GroupBox();
			this.cboxDuY = new global::System.Windows.Forms.CheckBox();
			this.btnVeThanhExpand = new global::System.Windows.Forms.Button();
			this.cboxVeThanhHetBNM = new global::System.Windows.Forms.CheckBox();
			this.cboPetFoodType = new global::System.Windows.Forms.ComboBox();
			this.cboVeThanh = new global::System.Windows.Forms.CheckBox();
			this.numVeThanhMP = new global::System.Windows.Forms.NumericUpDown();
			this.numVeThanhHP = new global::System.Windows.Forms.NumericUpDown();
			this.cboxVeThanhHetThucAn = new global::System.Windows.Forms.CheckBox();
			this.label21 = new global::System.Windows.Forms.Label();
			this.cboThanhQuayVe = new global::System.Windows.Forms.ComboBox();
			this.label22 = new global::System.Windows.Forms.Label();
			this.label25 = new global::System.Windows.Forms.Label();
			this.groupTocDoTrain = new global::System.Windows.Forms.GroupBox();
			this.btnSpeedExpand = new global::System.Windows.Forms.Button();
			this.lblTrainSpeed4 = new global::System.Windows.Forms.Label();
			this.lblTrainSpeed3 = new global::System.Windows.Forms.Label();
			this.btnTrainExpReset = new global::System.Windows.Forms.Button();
			this.lblTrainSpeed2 = new global::System.Windows.Forms.Label();
			this.lblTrainSpeed = new global::System.Windows.Forms.Label();
			this.cboTrainExpMode = new global::System.Windows.Forms.ComboBox();
			this.groupTuyChon = new global::System.Windows.Forms.GroupBox();
			this.btnShutdown = new global::System.Windows.Forms.Button();
			this.numShutdownM = new global::System.Windows.Forms.NumericUpDown();
			this.label23 = new global::System.Windows.Forms.Label();
			this.label20 = new global::System.Windows.Forms.Label();
			this.numShutdownH = new global::System.Windows.Forms.NumericUpDown();
			this.label19 = new global::System.Windows.Forms.Label();
			this.numUpLevel = new global::System.Windows.Forms.NumericUpDown();
			this.cboxThoLinhChau = new global::System.Windows.Forms.CheckBox();
			this.lblTimeOnline = new global::System.Windows.Forms.Label();
			this.btnTuyChonExpand = new global::System.Windows.Forms.Button();
			this.btnResetGio = new global::System.Windows.Forms.Button();
			this.cboxTuUpLevel = new global::System.Windows.Forms.CheckBox();
			this.label26 = new global::System.Windows.Forms.Label();
			this.cboxSupportLog = new global::System.Windows.Forms.CheckBox();
			this.cboxTuClickYes = new global::System.Windows.Forms.CheckBox();
			this.cboxKhongResetGio = new global::System.Windows.Forms.CheckBox();
			this.cboxAnHienGame = new global::System.Windows.Forms.CheckBox();
			this.txtPassCap2 = new global::System.Windows.Forms.TextBox();
			this.cboxTNAlert = new global::System.Windows.Forms.CheckBox();
			this.cboxPassCap2 = new global::System.Windows.Forms.CheckBox();
			this.cboxTNAlertPK = new global::System.Windows.Forms.CheckBox();
			this.cboxCaptchaReset = new global::System.Windows.Forms.CheckBox();
			this.cboxCanX2 = new global::System.Windows.Forms.CheckBox();
			this.cboxCanX4 = new global::System.Windows.Forms.CheckBox();
			this.cboxChayNhanh = new global::System.Windows.Forms.CheckBox();
			this.groupChat = new global::System.Windows.Forms.GroupBox();
			this.cboxVIPPM = new global::System.Windows.Forms.CheckBox();
			this.numAutoChat = new global::System.Windows.Forms.NumericUpDown();
			this.cboxChatSavedMsg = new global::System.Windows.Forms.CheckBox();
			this.btnChatDelete = new global::System.Windows.Forms.Button();
			this.btnChatRecord = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnChatExpand = new global::System.Windows.Forms.Button();
			this.lblNextChat = new global::System.Windows.Forms.Label();
			this.lbChatTimes = new global::System.Windows.Forms.Label();
			this.cboxAutoChat = new global::System.Windows.Forms.CheckBox();
			this.btnSendChat = new global::System.Windows.Forms.Button();
			this.cboxHelpChat = new global::System.Windows.Forms.CheckBox();
			this.cboKenhChat = new global::System.Windows.Forms.ComboBox();
			this.richChat = new global::System.Windows.Forms.RichTextBox();
			this.tabDebug = new global::System.Windows.Forms.TabPage();
			this.lvQuai = new global::System.Windows.Forms.ListView();
			this.columnHeader_8 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_9 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_10 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_11 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_12 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_13 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_34 = new global::System.Windows.Forms.ColumnHeader();
			this.lblTotalQuai = new global::System.Windows.Forms.Label();
			this.lblDebugInfo = new global::System.Windows.Forms.Label();
			this.tabDebugBoc = new global::System.Windows.Forms.TabPage();
			this.lvItems = new global::System.Windows.Forms.ListView();
			this.columnHeader_14 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_15 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_16 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_17 = new global::System.Windows.Forms.ColumnHeader();
			this.lblTotalBoc = new global::System.Windows.Forms.Label();
			this.lblItems = new global::System.Windows.Forms.Label();
			this.lblActiveBocID = new global::System.Windows.Forms.Label();
			this.lvAllBoc = new global::System.Windows.Forms.ListView();
			this.columnHeader_18 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_19 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_20 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_21 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_22 = new global::System.Windows.Forms.ColumnHeader();
			this.tabPhat = new global::System.Windows.Forms.TabPage();
			this.groupPhat = new global::System.Windows.Forms.GroupBox();
			this.tbXorString = new global::System.Windows.Forms.TextBox();
			this.btnXorString = new global::System.Windows.Forms.Button();
			this.lbTimeOnlineTest = new global::System.Windows.Forms.Label();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.comboBox5 = new global::System.Windows.Forms.ComboBox();
			this.cboxDebugLog = new global::System.Windows.Forms.CheckBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.cboxPhatTest2 = new global::System.Windows.Forms.ComboBox();
			this.cboxTNRunOnly = new global::System.Windows.Forms.CheckBox();
			this.btnPhatTest2 = new global::System.Windows.Forms.Button();
			this.btnSearchNPC = new global::System.Windows.Forms.Button();
			this.cboxPhatTest3 = new global::System.Windows.Forms.ComboBox();
			this.cboxATAB = new global::System.Windows.Forms.CheckBox();
			this.btnPhatTest3 = new global::System.Windows.Forms.Button();
			this.cboxKhoangDuoc = new global::System.Windows.Forms.CheckBox();
			this.btnResetKhoangDuoc = new global::System.Windows.Forms.Button();
			this.AIModes = new global::System.Windows.Forms.ComboBox();
			this.btnMoiDoi = new global::System.Windows.Forms.Button();
			this.btnTrieuTap = new global::System.Windows.Forms.Button();
			this.numGroupID = new global::System.Windows.Forms.NumericUpDown();
			this.label35 = new global::System.Windows.Forms.Label();
			this.mnuMain = new global::System.Windows.Forms.MenuStrip();
			this.itemSystem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemUserInfo = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemRenew = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_39 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.buyHoursBlockToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.itemSysSep2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_38 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_80 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_20 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_23 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_28 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new global::System.Windows.Forms.ToolStripSeparator();
			this.itemExit = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_22 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_69 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_18 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_17 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_15 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_13 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.thuGToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_19 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_24 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_33 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_25 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_26 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_27 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_29 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_30 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_31 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_41 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem18 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_36 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_37 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.autoPKToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_76 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_77 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_78 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_86 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_96 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_97 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_101 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_100 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_102 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_121 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_189 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.testGameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_161 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_34 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_35 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new global::System.Windows.Forms.ToolStripSeparator();
			this.itemHelp = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.facebookFanpageToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_11 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_14 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_32 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_68 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_83 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.notifyIcon_0 = new global::System.Windows.Forms.NotifyIcon(this.icontainer_0);
			this.contextTray = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_5 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.mnuTrayShutdownNoGame = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_99 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextUserList = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_9 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextProcessList = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_42 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_44 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_70 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_71 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_73 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_74 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_72 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_158 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_159 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_160 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_64 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_65 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_66 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_75 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_167 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_85 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_90 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_91 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lamToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_92 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_93 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_94 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_95 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_116 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_152 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_153 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_154 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_169 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_155 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_43 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_59 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_60 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_61 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_104 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_108 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_106 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_107 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_105 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_109 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_110 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_111 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_49 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_50 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_52 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_53 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_54 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_55 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_84 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.lV2840ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_51 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_56 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_57 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_58 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_79 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_132 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_170 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem16 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem17 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_129 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_130 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_131 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_45 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_177 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_180 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_181 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tLCToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_182 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.muaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_183 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_98 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_46 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_81 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_171 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_172 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_47 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_48 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_88 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_89 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_103 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_168 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_179 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_117 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_118 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_119 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_120 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_122 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_123 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_124 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_125 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_126 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_127 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_128 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_133 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_148 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_149 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_145 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_178 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_151 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_144 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_137 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_138 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_147 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_134 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_136 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_135 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_139 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_140 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_141 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_142 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.kimLangToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_190 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_143 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_146 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.theoSauKeyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_150 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_173 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_174 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_175 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_176 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_184 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_185 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_186 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_187 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_188 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_156 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_157 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_62 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_63 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_82 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_12 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_87 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_10 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_21 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_40 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuThoatGameNhanh = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_67 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem_166 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_162 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_163 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_164 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_165 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_112 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_113 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_114 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_115 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pnelFacebook = new global::System.Windows.Forms.Panel();
			this.btnBuyHour = new global::System.Windows.Forms.Button();
			this.btnSkillsOff = new global::System.Windows.Forms.Button();
			this.btnSkills = new global::System.Windows.Forms.Button();
			this.label51 = new global::System.Windows.Forms.Label();
			this.btnTheoSau = new global::System.Windows.Forms.Button();
			this.btnTheoSauOff = new global::System.Windows.Forms.Button();
			this.label18 = new global::System.Windows.Forms.Label();
			this.cboxTuTheo = new global::System.Windows.Forms.CheckBox();
			this.btnDanhTheoTen = new global::System.Windows.Forms.Button();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.btnThuPetOff = new global::System.Windows.Forms.Button();
			this.btnNhatBocOff = new global::System.Windows.Forms.Button();
			this.btnThuPet = new global::System.Windows.Forms.Button();
			this.btnNhatBoc = new global::System.Windows.Forms.Button();
			this.btnDanhTheoKey = new global::System.Windows.Forms.Button();
			this.btnDanhGomQuai = new global::System.Windows.Forms.Button();
			this.btnDanhTungCon = new global::System.Windows.Forms.Button();
			this.numDelay = new global::System.Windows.Forms.NumericUpDown();
			this.label5 = new global::System.Windows.Forms.Label();
			this.btnUpdate = new global::System.Windows.Forms.Button();
			this.btnThuGon = new global::System.Windows.Forms.Button();
			this.btnThuCommonGUI = new global::System.Windows.Forms.Button();
			this.btnFacebook = new global::System.Windows.Forms.Button();
			this.lvAllAccounts = new global::ns0.GClass3();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_7 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_35 = new global::System.Windows.Forms.ColumnHeader();
			this.statusStrip.SuspendLayout();
			this.pnelLog.SuspendLayout();
			this.tabDieuKhien.SuspendLayout();
			this.tabCoBan.SuspendLayout();
			this.groupNgaMi.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numBuffPhamVi).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBuffPartyPercent).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numNgaMyBuff).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBuffPet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numPhatQuangDelay).BeginInit();
			this.groupPhucHoi.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPetHPPercent).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numMPPercent).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numHPPercent).BeginInit();
			this.groupDanhQuai.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numGomMode).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numDistance).BeginInit();
			this.groupTheoSau.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numTheoSau).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numRadius).BeginInit();
			this.tabKyNang.SuspendLayout();
			this.groupPKSkills.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPKThoatGame).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numPKSkill).BeginInit();
			this.groupSkillBuff.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillBuffLength).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillBuffDelay).BeginInit();
			this.groupKyNang.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillDelay).BeginInit();
			this.tabVatPham.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupItemUse.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numItemUse).BeginInit();
			this.groupMuaDo.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numItemMua).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBanKinhNhat).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numFullThung).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numGiuDoDong).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numGiuDoSao).BeginInit();
			this.tabThuongNhan.SuspendLayout();
			this.groupThuongNhan.SuspendLayout();
			this.groupTNThanhMinh.SuspendLayout();
			this.groupTNThanhFriend.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numTNRounds).BeginInit();
			this.tabNhiemVu.SuspendLayout();
			this.groupYTO.SuspendLayout();
			this.groupQ123.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numQ12Level).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numQ12ChoPT).BeginInit();
			this.groupBaoRuong.SuspendLayout();
			this.groupQSM.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numQSMMax).BeginInit();
			this.groupTKC.SuspendLayout();
			this.groupTBB.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numsoHangTrongHoa).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBHDBanKinh).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBHDMax).BeginInit();
			this.groupMuaKNB.SuspendLayout();
			this.groupLuyenKim.SuspendLayout();
			this.groupTrungAc.SuspendLayout();
			this.groupAcTac.SuspendLayout();
			this.groupDuaHau.SuspendLayout();
			this.groupKhaiKhoang.SuspendLayout();
			this.groupPhuBanTuyChinh.SuspendLayout();
			this.groupScheduler.SuspendLayout();
			this.tabTienIch.SuspendLayout();
			this.groupDied.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numChoHoiSinh).BeginInit();
			this.groupToDoi.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPTLevel).BeginInit();
			this.groupVeThanh.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numVeThanhMP).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numVeThanhHP).BeginInit();
			this.groupTocDoTrain.SuspendLayout();
			this.groupTuyChon.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numShutdownM).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numShutdownH).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUpLevel).BeginInit();
			this.groupChat.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numAutoChat).BeginInit();
			this.tabDebug.SuspendLayout();
			this.tabDebugBoc.SuspendLayout();
			this.tabPhat.SuspendLayout();
			this.groupPhat.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numGroupID).BeginInit();
			this.mnuMain.SuspendLayout();
			this.contextTray.SuspendLayout();
			this.contextUserList.SuspendLayout();
			this.contextProcessList.SuspendLayout();
			this.pnelFacebook.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).BeginInit();
			base.SuspendLayout();
			this.statusStrip.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.statusStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.lblLocation,
				this.lblCharLoc,
				this.imgBuyHour,
				this.lblRemainHours
			});
			componentResourceManager.ApplyResources(this.statusStrip, "statusStrip");
			this.statusStrip.Name = "statusStrip";
			this.lblLocation.Name = "lblLocation";
			componentResourceManager.ApplyResources(this.lblLocation, "lblLocation");
			this.lblCharLoc.Name = "lblCharLoc";
			componentResourceManager.ApplyResources(this.lblCharLoc, "lblCharLoc");
			this.lblCharLoc.Spring = true;
			this.imgBuyHour.BackColor = global::System.Drawing.Color.OrangeRed;
			this.imgBuyHour.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			componentResourceManager.ApplyResources(this.imgBuyHour, "imgBuyHour");
			this.imgBuyHour.ForeColor = global::System.Drawing.Color.LavenderBlush;
			this.imgBuyHour.Name = "imgBuyHour";
			this.imgBuyHour.Click += new global::System.EventHandler(this.imgBuyHour_Click);
			this.lblRemainHours.Name = "lblRemainHours";
			componentResourceManager.ApplyResources(this.lblRemainHours, "lblRemainHours");
			this.pnelLog.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnelLog.Controls.Add(this.btnOpenLog);
			this.pnelLog.Controls.Add(this.richLog);
			componentResourceManager.ApplyResources(this.pnelLog, "pnelLog");
			this.pnelLog.Name = "pnelLog";
			this.btnOpenLog.BackColor = global::System.Drawing.Color.LemonChiffon;
			componentResourceManager.ApplyResources(this.btnOpenLog, "btnOpenLog");
			this.btnOpenLog.ForeColor = global::System.Drawing.Color.LemonChiffon;
			this.btnOpenLog.Image = global::ns0.Class212.info;
			this.btnOpenLog.Name = "btnOpenLog";
			this.btnOpenLog.UseVisualStyleBackColor = false;
			this.btnOpenLog.Click += new global::System.EventHandler(this.btnOpenLog_Click);
			this.richLog.BackColor = global::System.Drawing.Color.LemonChiffon;
			this.richLog.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			componentResourceManager.ApplyResources(this.richLog, "richLog");
			this.richLog.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.richLog.Name = "richLog";
			this.richLog.TextChanged += new global::System.EventHandler(this.richLog_TextChanged);
			this.tabDieuKhien.Controls.Add(this.tabCoBan);
			this.tabDieuKhien.Controls.Add(this.tabKyNang);
			this.tabDieuKhien.Controls.Add(this.tabVatPham);
			this.tabDieuKhien.Controls.Add(this.tabThuongNhan);
			this.tabDieuKhien.Controls.Add(this.tabNhiemVu);
			this.tabDieuKhien.Controls.Add(this.tabTienIch);
			this.tabDieuKhien.Controls.Add(this.tabDebug);
			this.tabDieuKhien.Controls.Add(this.tabDebugBoc);
			this.tabDieuKhien.Controls.Add(this.tabPhat);
			componentResourceManager.ApplyResources(this.tabDieuKhien, "tabDieuKhien");
			this.tabDieuKhien.Name = "tabDieuKhien";
			this.tabDieuKhien.SelectedIndex = 0;
			this.tabDieuKhien.SizeMode = global::System.Windows.Forms.TabSizeMode.FillToRight;
			this.tabDieuKhien.DrawItem += new global::System.Windows.Forms.DrawItemEventHandler(this.tabDieuKhien_DrawItem);
			this.tabDieuKhien.SelectedIndexChanged += new global::System.EventHandler(this.tabDieuKhien_SelectedIndexChanged);
			this.tabCoBan.BackColor = global::System.Drawing.Color.Transparent;
			this.tabCoBan.Controls.Add(this.groupNgaMi);
			this.tabCoBan.Controls.Add(this.groupPhucHoi);
			this.tabCoBan.Controls.Add(this.groupDanhQuai);
			componentResourceManager.ApplyResources(this.tabCoBan, "tabCoBan");
			this.tabCoBan.Name = "tabCoBan";
			this.groupNgaMi.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.groupNgaMi.Controls.Add(this.label67);
			this.groupNgaMi.Controls.Add(this.numBuffPhamVi);
			this.groupNgaMi.Controls.Add(this.cboxNMBuffSelectTarget);
			this.groupNgaMi.Controls.Add(this.numBuffPartyPercent);
			this.groupNgaMi.Controls.Add(this.cboxNMUutienboc);
			this.groupNgaMi.Controls.Add(this.numNgaMyBuff);
			this.groupNgaMi.Controls.Add(this.btnPetList);
			this.groupNgaMi.Controls.Add(this.cboxPetList);
			this.groupNgaMi.Controls.Add(this.cboxNMUutienself);
			this.groupNgaMi.Controls.Add(this.cboxNMBuff);
			this.groupNgaMi.Controls.Add(this.btnListNMBuff);
			this.groupNgaMi.Controls.Add(this.lblNMParty);
			this.groupNgaMi.Controls.Add(this.cboxNMBuffQuanDoan);
			this.groupNgaMi.Controls.Add(this.cboxNMBuffList);
			this.groupNgaMi.Controls.Add(this.lblNMPQSecond);
			this.groupNgaMi.Controls.Add(this.numBuffPet);
			this.groupNgaMi.Controls.Add(this.numPhatQuangDelay);
			this.groupNgaMi.Controls.Add(this.cboxBuffPet);
			this.groupNgaMi.Controls.Add(this.cboxPhatQuangPhoChieu);
			this.groupNgaMi.Controls.Add(this.label32);
			componentResourceManager.ApplyResources(this.groupNgaMi, "groupNgaMi");
			this.groupNgaMi.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupNgaMi.Name = "groupNgaMi";
			this.groupNgaMi.TabStop = false;
			componentResourceManager.ApplyResources(this.label67, "label67");
			this.label67.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.label67.Name = "label67";
			this.numBuffPhamVi.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numBuffPhamVi, "numBuffPhamVi");
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numBuffPhamVi;
			int[] array = new int[4];
			array[0] = 50;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numBuffPhamVi;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numBuffPhamVi.Name = "numBuffPhamVi";
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numBuffPhamVi;
			int[] array3 = new int[4];
			array3[0] = 25;
			numericUpDown3.Value = new decimal(array3);
			this.numBuffPhamVi.ValueChanged += new global::System.EventHandler(this.numBuffPhamVi_ValueChanged);
			this.numBuffPhamVi.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numBuffPhamVi_KeyPress);
			componentResourceManager.ApplyResources(this.cboxNMBuffSelectTarget, "cboxNMBuffSelectTarget");
			this.cboxNMBuffSelectTarget.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.cboxNMBuffSelectTarget.Name = "cboxNMBuffSelectTarget";
			this.cboxNMBuffSelectTarget.UseVisualStyleBackColor = true;
			this.cboxNMBuffSelectTarget.CheckedChanged += new global::System.EventHandler(this.cboxNMBuffSelectTarget_CheckedChanged);
			this.numBuffPartyPercent.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numBuffPartyPercent;
			int[] array4 = new int[4];
			array4[0] = 5;
			numericUpDown4.Increment = new decimal(array4);
			componentResourceManager.ApplyResources(this.numBuffPartyPercent, "numBuffPartyPercent");
			this.numBuffPartyPercent.Name = "numBuffPartyPercent";
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numBuffPartyPercent;
			int[] array5 = new int[4];
			array5[0] = 80;
			numericUpDown5.Value = new decimal(array5);
			this.numBuffPartyPercent.ValueChanged += new global::System.EventHandler(this.numBuffPartyPercent_ValueChanged);
			this.numBuffPartyPercent.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numBuffPartyPercent_KeyPress);
			componentResourceManager.ApplyResources(this.cboxNMUutienboc, "cboxNMUutienboc");
			this.cboxNMUutienboc.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxNMUutienboc.Name = "cboxNMUutienboc";
			this.cboxNMUutienboc.UseVisualStyleBackColor = false;
			this.cboxNMUutienboc.CheckedChanged += new global::System.EventHandler(this.cboxNMUutienboc_CheckedChanged);
			this.numNgaMyBuff.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.numNgaMyBuff;
			int[] array6 = new int[4];
			array6[0] = 5;
			numericUpDown6.Increment = new decimal(array6);
			componentResourceManager.ApplyResources(this.numNgaMyBuff, "numNgaMyBuff");
			this.numNgaMyBuff.Name = "numNgaMyBuff";
			global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.numNgaMyBuff;
			int[] array7 = new int[4];
			array7[0] = 80;
			numericUpDown7.Value = new decimal(array7);
			this.numNgaMyBuff.ValueChanged += new global::System.EventHandler(this.numNgaMyBuff_ValueChanged);
			this.numNgaMyBuff.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numNgaMyBuff_KeyPress);
			this.btnPetList.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			componentResourceManager.ApplyResources(this.btnPetList, "btnPetList");
			this.btnPetList.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnPetList.Name = "btnPetList";
			this.btnPetList.UseVisualStyleBackColor = false;
			this.btnPetList.Click += new global::System.EventHandler(this.btnPetList_Click);
			componentResourceManager.ApplyResources(this.cboxPetList, "cboxPetList");
			this.cboxPetList.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxPetList.Name = "cboxPetList";
			this.cboxPetList.UseVisualStyleBackColor = false;
			this.cboxPetList.CheckedChanged += new global::System.EventHandler(this.cboxPetList_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxNMUutienself, "cboxNMUutienself");
			this.cboxNMUutienself.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxNMUutienself.Name = "cboxNMUutienself";
			this.cboxNMUutienself.UseVisualStyleBackColor = false;
			this.cboxNMUutienself.CheckedChanged += new global::System.EventHandler(this.cboxNMUutienself_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxNMBuff, "cboxNMBuff");
			this.cboxNMBuff.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.cboxNMBuff.Name = "cboxNMBuff";
			this.cboxNMBuff.UseVisualStyleBackColor = true;
			this.cboxNMBuff.CheckedChanged += new global::System.EventHandler(this.cboxNMBuff_CheckedChanged);
			this.btnListNMBuff.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			componentResourceManager.ApplyResources(this.btnListNMBuff, "btnListNMBuff");
			this.btnListNMBuff.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnListNMBuff.Name = "btnListNMBuff";
			this.btnListNMBuff.UseVisualStyleBackColor = false;
			this.btnListNMBuff.Click += new global::System.EventHandler(this.btnListNMBuff_Click);
			componentResourceManager.ApplyResources(this.lblNMParty, "lblNMParty");
			this.lblNMParty.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNMParty.Name = "lblNMParty";
			componentResourceManager.ApplyResources(this.cboxNMBuffQuanDoan, "cboxNMBuffQuanDoan");
			this.cboxNMBuffQuanDoan.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxNMBuffQuanDoan.ForeColor = global::System.Drawing.Color.Black;
			this.cboxNMBuffQuanDoan.Name = "cboxNMBuffQuanDoan";
			this.cboxNMBuffQuanDoan.UseVisualStyleBackColor = false;
			this.cboxNMBuffQuanDoan.CheckedChanged += new global::System.EventHandler(this.cboxNMBuffQuanDoan_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxNMBuffList, "cboxNMBuffList");
			this.cboxNMBuffList.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxNMBuffList.ForeColor = global::System.Drawing.Color.Black;
			this.cboxNMBuffList.Name = "cboxNMBuffList";
			this.cboxNMBuffList.UseVisualStyleBackColor = false;
			this.cboxNMBuffList.CheckedChanged += new global::System.EventHandler(this.cboxNMBuffList_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblNMPQSecond, "lblNMPQSecond");
			this.lblNMPQSecond.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNMPQSecond.Name = "lblNMPQSecond";
			this.numBuffPet.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.numBuffPet;
			int[] array8 = new int[4];
			array8[0] = 5;
			numericUpDown8.Increment = new decimal(array8);
			componentResourceManager.ApplyResources(this.numBuffPet, "numBuffPet");
			this.numBuffPet.Name = "numBuffPet";
			global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.numBuffPet;
			int[] array9 = new int[4];
			array9[0] = 65;
			numericUpDown9.Value = new decimal(array9);
			this.numBuffPet.ValueChanged += new global::System.EventHandler(this.numBuffPet_ValueChanged);
			this.numBuffPet.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numBuffPet_KeyPress);
			this.numPhatQuangDelay.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.numPhatQuangDelay;
			int[] array10 = new int[4];
			array10[0] = 5;
			numericUpDown10.Increment = new decimal(array10);
			componentResourceManager.ApplyResources(this.numPhatQuangDelay, "numPhatQuangDelay");
			this.numPhatQuangDelay.Name = "numPhatQuangDelay";
			global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.numPhatQuangDelay;
			int[] array11 = new int[4];
			array11[0] = 80;
			numericUpDown11.Value = new decimal(array11);
			this.numPhatQuangDelay.ValueChanged += new global::System.EventHandler(this.numPhatQuangDelay_ValueChanged);
			this.numPhatQuangDelay.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numPhatQuangDelay_KeyPress);
			componentResourceManager.ApplyResources(this.cboxBuffPet, "cboxBuffPet");
			this.cboxBuffPet.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBuffPet.Name = "cboxBuffPet";
			this.cboxBuffPet.UseVisualStyleBackColor = false;
			this.cboxBuffPet.CheckedChanged += new global::System.EventHandler(this.cboxBuffPet_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxPhatQuangPhoChieu, "cboxPhatQuangPhoChieu");
			this.cboxPhatQuangPhoChieu.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxPhatQuangPhoChieu.Name = "cboxPhatQuangPhoChieu";
			this.cboxPhatQuangPhoChieu.UseVisualStyleBackColor = false;
			this.cboxPhatQuangPhoChieu.CheckedChanged += new global::System.EventHandler(this.cboxPhatQuangPhoChieu_CheckedChanged);
			componentResourceManager.ApplyResources(this.label32, "label32");
			this.label32.Name = "label32";
			this.groupPhucHoi.BackColor = global::System.Drawing.Color.FromArgb(215, 215, 215);
			this.groupPhucHoi.Controls.Add(this.cboxAOE);
			this.groupPhucHoi.Controls.Add(this.cboPetHuyetTe);
			this.groupPhucHoi.Controls.Add(this.cboPetChien);
			this.groupPhucHoi.Controls.Add(this.cboxHuyetTe);
			this.groupPhucHoi.Controls.Add(this.cboPetCongSinh);
			this.groupPhucHoi.Controls.Add(this.label29);
			this.groupPhucHoi.Controls.Add(this.numPetHPPercent);
			this.groupPhucHoi.Controls.Add(this.cboxCongSinh);
			this.groupPhucHoi.Controls.Add(this.numMPPercent);
			this.groupPhucHoi.Controls.Add(this.numHPPercent);
			this.groupPhucHoi.Controls.Add(this.label11);
			this.groupPhucHoi.Controls.Add(this.label9);
			this.groupPhucHoi.Controls.Add(this.label13);
			componentResourceManager.ApplyResources(this.groupPhucHoi, "groupPhucHoi");
			this.groupPhucHoi.Name = "groupPhucHoi";
			this.groupPhucHoi.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxAOE, "cboxAOE");
			this.cboxAOE.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxAOE.Name = "cboxAOE";
			this.cboxAOE.UseVisualStyleBackColor = false;
			this.cboxAOE.CheckedChanged += new global::System.EventHandler(this.cboxAOE_CheckedChanged);
			this.cboPetHuyetTe.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboPetHuyetTe, "cboPetHuyetTe");
			this.cboPetHuyetTe.FormattingEnabled = true;
			this.cboPetHuyetTe.Name = "cboPetHuyetTe";
			this.cboPetHuyetTe.DropDown += new global::System.EventHandler(this.cboPetHuyetTe_DropDown);
			this.cboPetHuyetTe.SelectedIndexChanged += new global::System.EventHandler(this.cboPetHuyetTe_SelectedIndexChanged);
			this.cboPetChien.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboPetChien, "cboPetChien");
			this.cboPetChien.FormattingEnabled = true;
			this.cboPetChien.Name = "cboPetChien";
			this.cboPetChien.DropDown += new global::System.EventHandler(this.cboPetChien_DropDown);
			this.cboPetChien.SelectedIndexChanged += new global::System.EventHandler(this.cboPetChien_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxHuyetTe, "cboxHuyetTe");
			this.cboxHuyetTe.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxHuyetTe.Name = "cboxHuyetTe";
			this.cboxHuyetTe.UseVisualStyleBackColor = false;
			this.cboxHuyetTe.CheckedChanged += new global::System.EventHandler(this.cboxHuyetTe_CheckedChanged);
			this.cboPetCongSinh.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboPetCongSinh, "cboPetCongSinh");
			this.cboPetCongSinh.FormattingEnabled = true;
			this.cboPetCongSinh.Name = "cboPetCongSinh";
			this.cboPetCongSinh.DropDown += new global::System.EventHandler(this.cboPetCongSinh_DropDown);
			this.cboPetCongSinh.SelectedIndexChanged += new global::System.EventHandler(this.cboPetCongSinh_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label29, "label29");
			this.label29.Name = "label29";
			this.numPetHPPercent.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.numPetHPPercent;
			int[] array12 = new int[4];
			array12[0] = 5;
			numericUpDown12.Increment = new decimal(array12);
			componentResourceManager.ApplyResources(this.numPetHPPercent, "numPetHPPercent");
			this.numPetHPPercent.Name = "numPetHPPercent";
			this.numPetHPPercent.ValueChanged += new global::System.EventHandler(this.numPetHPPercent_ValueChanged);
			this.numPetHPPercent.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numPetHPPercent_KeyPress);
			componentResourceManager.ApplyResources(this.cboxCongSinh, "cboxCongSinh");
			this.cboxCongSinh.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxCongSinh.Name = "cboxCongSinh";
			this.cboxCongSinh.UseVisualStyleBackColor = false;
			this.cboxCongSinh.CheckedChanged += new global::System.EventHandler(this.cboxCongSinh_CheckedChanged);
			this.numMPPercent.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.numMPPercent;
			int[] array13 = new int[4];
			array13[0] = 5;
			numericUpDown13.Increment = new decimal(array13);
			componentResourceManager.ApplyResources(this.numMPPercent, "numMPPercent");
			this.numMPPercent.Name = "numMPPercent";
			this.numMPPercent.ValueChanged += new global::System.EventHandler(this.numMPPercent_ValueChanged);
			this.numMPPercent.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numMPPercent_KeyPress);
			this.numHPPercent.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.numHPPercent;
			int[] array14 = new int[4];
			array14[0] = 5;
			numericUpDown14.Increment = new decimal(array14);
			componentResourceManager.ApplyResources(this.numHPPercent, "numHPPercent");
			this.numHPPercent.Name = "numHPPercent";
			this.numHPPercent.ValueChanged += new global::System.EventHandler(this.numHPPercent_ValueChanged);
			this.numHPPercent.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numHPPercent_KeyPress);
			componentResourceManager.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			componentResourceManager.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			componentResourceManager.ApplyResources(this.label13, "label13");
			this.label13.Name = "label13";
			this.groupDanhQuai.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupDanhQuai.Controls.Add(this.numGomMode);
			this.groupDanhQuai.Controls.Add(this.btnDanhTheoAi);
			this.groupDanhQuai.Controls.Add(this.rdioDanhTheoAi);
			this.groupDanhQuai.Controls.Add(this.rdioDanhTheoKey);
			this.groupDanhQuai.Controls.Add(this.numDistance);
			this.groupDanhQuai.Controls.Add(this.cboxBanKinh);
			this.groupDanhQuai.Controls.Add(this.btnQuaiKoDanh);
			this.groupDanhQuai.Controls.Add(this.cboxNoKS);
			this.groupDanhQuai.Controls.Add(this.groupTheoSau);
			this.groupDanhQuai.Controls.Add(this.txtDanhTheoAi);
			this.groupDanhQuai.Controls.Add(this.cboTrainMaps);
			this.groupDanhQuai.Controls.Add(this.cboxDanhQuai);
			this.groupDanhQuai.Controls.Add(this.btnHoiSucLenBai);
			this.groupDanhQuai.Controls.Add(this.rdioGomQuai);
			this.groupDanhQuai.Controls.Add(this.btnLenBai);
			this.groupDanhQuai.Controls.Add(this.numRadius);
			this.groupDanhQuai.Controls.Add(this.modeTUNGCON);
			this.groupDanhQuai.Controls.Add(this.btnGetCurrentPos);
			this.groupDanhQuai.Controls.Add(this.txtToaDoY);
			this.groupDanhQuai.Controls.Add(this.txtToaDoX);
			this.groupDanhQuai.Controls.Add(this.label4);
			this.groupDanhQuai.Controls.Add(this.label2);
			this.groupDanhQuai.Controls.Add(this.cboxOnlyPet);
			componentResourceManager.ApplyResources(this.groupDanhQuai, "groupDanhQuai");
			this.groupDanhQuai.Name = "groupDanhQuai";
			this.groupDanhQuai.TabStop = false;
			this.numGomMode.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numGomMode, "numGomMode");
			global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.numGomMode;
			int[] array15 = new int[4];
			array15[0] = 2;
			numericUpDown15.Maximum = new decimal(array15);
			global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.numGomMode;
			int[] array16 = new int[4];
			array16[0] = 1;
			numericUpDown16.Minimum = new decimal(array16);
			this.numGomMode.Name = "numGomMode";
			global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.numGomMode;
			int[] array17 = new int[4];
			array17[0] = 1;
			numericUpDown17.Value = new decimal(array17);
			this.numGomMode.ValueChanged += new global::System.EventHandler(this.numGomMode_ValueChanged);
			this.numGomMode.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numGomMode_KeyPress);
			this.btnDanhTheoAi.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnDanhTheoAi, "btnDanhTheoAi");
			this.btnDanhTheoAi.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnDanhTheoAi.Name = "btnDanhTheoAi";
			this.btnDanhTheoAi.UseVisualStyleBackColor = false;
			this.btnDanhTheoAi.Click += new global::System.EventHandler(this.btnDanhTheoAi_Click);
			componentResourceManager.ApplyResources(this.rdioDanhTheoAi, "rdioDanhTheoAi");
			this.rdioDanhTheoAi.ForeColor = global::System.Drawing.Color.Black;
			this.rdioDanhTheoAi.Name = "rdioDanhTheoAi";
			this.rdioDanhTheoAi.UseVisualStyleBackColor = true;
			this.rdioDanhTheoAi.CheckedChanged += new global::System.EventHandler(this.rdioDanhTheoAi_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioDanhTheoKey, "rdioDanhTheoKey");
			this.rdioDanhTheoKey.ForeColor = global::System.Drawing.Color.Black;
			this.rdioDanhTheoKey.Name = "rdioDanhTheoKey";
			this.rdioDanhTheoKey.UseVisualStyleBackColor = true;
			this.rdioDanhTheoKey.CheckedChanged += new global::System.EventHandler(this.rdioDanhTheoKey_CheckedChanged);
			this.numDistance.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numDistance, "numDistance");
			this.numDistance.Name = "numDistance";
			this.numDistance.ValueChanged += new global::System.EventHandler(this.numDistance_ValueChanged);
			this.numDistance.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numDistance_KeyPress);
			componentResourceManager.ApplyResources(this.cboxBanKinh, "cboxBanKinh");
			this.cboxBanKinh.Name = "cboxBanKinh";
			this.cboxBanKinh.UseVisualStyleBackColor = true;
			this.cboxBanKinh.CheckedChanged += new global::System.EventHandler(this.cboxBanKinh_CheckedChanged);
			this.btnQuaiKoDanh.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnQuaiKoDanh, "btnQuaiKoDanh");
			this.btnQuaiKoDanh.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnQuaiKoDanh.Name = "btnQuaiKoDanh";
			this.btnQuaiKoDanh.UseVisualStyleBackColor = false;
			this.btnQuaiKoDanh.Click += new global::System.EventHandler(this.btnQuaiKoDanh_Click);
			componentResourceManager.ApplyResources(this.cboxNoKS, "cboxNoKS");
			this.cboxNoKS.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.cboxNoKS.Name = "cboxNoKS";
			this.cboxNoKS.UseVisualStyleBackColor = false;
			this.cboxNoKS.CheckedChanged += new global::System.EventHandler(this.cboxNoKS_CheckedChanged);
			this.groupTheoSau.Controls.Add(this.rdioTheoSauAiDo);
			this.groupTheoSau.Controls.Add(this.rdioTheoSauPT);
			this.groupTheoSau.Controls.Add(this.numTheoSau);
			this.groupTheoSau.Controls.Add(this.cboxTheoSau);
			this.groupTheoSau.Controls.Add(this.btnDiTheoAi);
			this.groupTheoSau.Controls.Add(this.txtTheoSauName);
			componentResourceManager.ApplyResources(this.groupTheoSau, "groupTheoSau");
			this.groupTheoSau.Name = "groupTheoSau";
			this.groupTheoSau.TabStop = false;
			componentResourceManager.ApplyResources(this.rdioTheoSauAiDo, "rdioTheoSauAiDo");
			this.rdioTheoSauAiDo.ForeColor = global::System.Drawing.Color.Black;
			this.rdioTheoSauAiDo.Name = "rdioTheoSauAiDo";
			this.rdioTheoSauAiDo.UseVisualStyleBackColor = true;
			this.rdioTheoSauAiDo.CheckedChanged += new global::System.EventHandler(this.rdioTheoSauAiDo_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioTheoSauPT, "rdioTheoSauPT");
			this.rdioTheoSauPT.Checked = true;
			this.rdioTheoSauPT.Name = "rdioTheoSauPT";
			this.rdioTheoSauPT.TabStop = true;
			this.rdioTheoSauPT.UseVisualStyleBackColor = true;
			this.rdioTheoSauPT.CheckedChanged += new global::System.EventHandler(this.rdioTheoSauPT_CheckedChanged);
			this.numTheoSau.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numTheoSau, "numTheoSau");
			global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.numTheoSau;
			int[] array18 = new int[4];
			array18[0] = 50;
			numericUpDown18.Maximum = new decimal(array18);
			global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.numTheoSau;
			int[] array19 = new int[4];
			array19[0] = 1;
			numericUpDown19.Minimum = new decimal(array19);
			this.numTheoSau.Name = "numTheoSau";
			global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.numTheoSau;
			int[] array20 = new int[4];
			array20[0] = 10;
			numericUpDown20.Value = new decimal(array20);
			this.numTheoSau.ValueChanged += new global::System.EventHandler(this.numTheoSau_ValueChanged);
			this.numTheoSau.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numTheoSau_KeyPress);
			componentResourceManager.ApplyResources(this.cboxTheoSau, "cboxTheoSau");
			this.cboxTheoSau.Name = "cboxTheoSau";
			this.cboxTheoSau.UseVisualStyleBackColor = true;
			this.cboxTheoSau.CheckedChanged += new global::System.EventHandler(this.cboxTheoSau_CheckedChanged);
			this.btnDiTheoAi.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnDiTheoAi, "btnDiTheoAi");
			this.btnDiTheoAi.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnDiTheoAi.Name = "btnDiTheoAi";
			this.btnDiTheoAi.UseVisualStyleBackColor = false;
			this.btnDiTheoAi.Click += new global::System.EventHandler(this.btnDiTheoAi_Click);
			this.txtTheoSauName.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTheoSauName.ForeColor = global::System.Drawing.Color.Maroon;
			componentResourceManager.ApplyResources(this.txtTheoSauName, "txtTheoSauName");
			this.txtTheoSauName.Name = "txtTheoSauName";
			this.txtTheoSauName.TextChanged += new global::System.EventHandler(this.txtTheoSauName_TextChanged);
			this.txtDanhTheoAi.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtDanhTheoAi.ForeColor = global::System.Drawing.Color.Maroon;
			componentResourceManager.ApplyResources(this.txtDanhTheoAi, "txtDanhTheoAi");
			this.txtDanhTheoAi.Name = "txtDanhTheoAi";
			this.txtDanhTheoAi.TextChanged += new global::System.EventHandler(this.txtDanhTheoAi_TextChanged);
			this.cboTrainMaps.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboTrainMaps.DropDownWidth = 186;
			componentResourceManager.ApplyResources(this.cboTrainMaps, "cboTrainMaps");
			this.cboTrainMaps.FormattingEnabled = true;
			this.cboTrainMaps.Name = "cboTrainMaps";
			this.cboTrainMaps.SelectedIndexChanged += new global::System.EventHandler(this.cboTrainMaps_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxDanhQuai, "cboxDanhQuai");
			this.cboxDanhQuai.Checked = true;
			this.cboxDanhQuai.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxDanhQuai.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.cboxDanhQuai.Name = "cboxDanhQuai";
			this.cboxDanhQuai.UseVisualStyleBackColor = true;
			this.cboxDanhQuai.CheckedChanged += new global::System.EventHandler(this.cboxDanhQuai_CheckedChanged);
			this.btnHoiSucLenBai.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnHoiSucLenBai.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnHoiSucLenBai, "btnHoiSucLenBai");
			this.btnHoiSucLenBai.Name = "btnHoiSucLenBai";
			this.btnHoiSucLenBai.UseVisualStyleBackColor = false;
			this.btnHoiSucLenBai.EnabledChanged += new global::System.EventHandler(this.btnHoiSucLenBai_EnabledChanged);
			this.btnHoiSucLenBai.Click += new global::System.EventHandler(this.btnHoiSucLenBai_Click);
			componentResourceManager.ApplyResources(this.rdioGomQuai, "rdioGomQuai");
			this.rdioGomQuai.Name = "rdioGomQuai";
			this.rdioGomQuai.UseVisualStyleBackColor = true;
			this.rdioGomQuai.CheckedChanged += new global::System.EventHandler(this.rdioGomQuai_CheckedChanged);
			this.btnLenBai.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnLenBai.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnLenBai, "btnLenBai");
			this.btnLenBai.Name = "btnLenBai";
			this.btnLenBai.UseVisualStyleBackColor = false;
			this.btnLenBai.Click += new global::System.EventHandler(this.btnLenBai_Click);
			this.numRadius.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numRadius, "numRadius");
			this.numRadius.Name = "numRadius";
			global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.numRadius;
			int[] array21 = new int[4];
			array21[0] = 20;
			numericUpDown21.Value = new decimal(array21);
			this.numRadius.ValueChanged += new global::System.EventHandler(this.numRadius_ValueChanged);
			this.numRadius.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numRadius_KeyPress);
			componentResourceManager.ApplyResources(this.modeTUNGCON, "modeTUNGCON");
			this.modeTUNGCON.Checked = true;
			this.modeTUNGCON.Name = "modeTUNGCON";
			this.modeTUNGCON.TabStop = true;
			this.modeTUNGCON.UseVisualStyleBackColor = true;
			this.modeTUNGCON.CheckedChanged += new global::System.EventHandler(this.modeTUNGCON_CheckedChanged);
			this.btnGetCurrentPos.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnGetCurrentPos.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnGetCurrentPos, "btnGetCurrentPos");
			this.btnGetCurrentPos.Name = "btnGetCurrentPos";
			this.btnGetCurrentPos.UseVisualStyleBackColor = false;
			this.btnGetCurrentPos.Click += new global::System.EventHandler(this.btnGetCurrentPos_Click);
			this.txtToaDoY.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtToaDoY.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtToaDoY, "txtToaDoY");
			this.txtToaDoY.Name = "txtToaDoY";
			this.txtToaDoY.TextChanged += new global::System.EventHandler(this.txtToaDoY_TextChanged);
			this.txtToaDoX.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtToaDoX.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtToaDoX, "txtToaDoX");
			this.txtToaDoX.Name = "txtToaDoX";
			this.txtToaDoX.TextChanged += new global::System.EventHandler(this.txtToaDoX_TextChanged);
			componentResourceManager.ApplyResources(this.label4, "label4");
			this.label4.Name = "label4";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			componentResourceManager.ApplyResources(this.label2, "label2");
			this.label2.Name = "label2";
			componentResourceManager.ApplyResources(this.cboxOnlyPet, "cboxOnlyPet");
			this.cboxOnlyPet.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxOnlyPet.Name = "cboxOnlyPet";
			this.cboxOnlyPet.UseVisualStyleBackColor = false;
			this.cboxOnlyPet.CheckedChanged += new global::System.EventHandler(this.cboxOnlyPet_CheckedChanged);
			this.tabKyNang.BackColor = global::System.Drawing.Color.Transparent;
			this.tabKyNang.Controls.Add(this.groupPKSkills);
			this.tabKyNang.Controls.Add(this.groupSkillBuff);
			this.tabKyNang.Controls.Add(this.groupKyNang);
			componentResourceManager.ApplyResources(this.tabKyNang, "tabKyNang");
			this.tabKyNang.Name = "tabKyNang";
			this.groupPKSkills.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.groupPKSkills.Controls.Add(this.btnPhanPKExpand);
			this.groupPKSkills.Controls.Add(this.label66);
			this.groupPKSkills.Controls.Add(this.numPKThoatGame);
			this.groupPKSkills.Controls.Add(this.cboxPKThoatGame);
			this.groupPKSkills.Controls.Add(this.cboxNMPKBuff);
			this.groupPKSkills.Controls.Add(this.cboxPKTuVe);
			this.groupPKSkills.Controls.Add(this.label37);
			this.groupPKSkills.Controls.Add(this.label52);
			this.groupPKSkills.Controls.Add(this.numPKSkill);
			this.groupPKSkills.Controls.Add(this.cboPKSkills);
			this.groupPKSkills.Controls.Add(this.btnPKRemove);
			this.groupPKSkills.Controls.Add(this.btnPKEdit);
			this.groupPKSkills.Controls.Add(this.btnPKThem);
			this.groupPKSkills.Controls.Add(this.lvPKSkills);
			componentResourceManager.ApplyResources(this.groupPKSkills, "groupPKSkills");
			this.groupPKSkills.Name = "groupPKSkills";
			this.groupPKSkills.TabStop = false;
			this.btnPhanPKExpand.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			componentResourceManager.ApplyResources(this.btnPhanPKExpand, "btnPhanPKExpand");
			this.btnPhanPKExpand.ForeColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnPhanPKExpand.Name = "btnPhanPKExpand";
			this.btnPhanPKExpand.UseVisualStyleBackColor = false;
			this.btnPhanPKExpand.Click += new global::System.EventHandler(this.btnPhanPKExpand_Click);
			componentResourceManager.ApplyResources(this.label66, "label66");
			this.label66.ForeColor = global::System.Drawing.Color.Black;
			this.label66.Name = "label66";
			this.numPKThoatGame.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numPKThoatGame.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.numPKThoatGame.ForeColor = global::System.Drawing.SystemColors.WindowText;
			componentResourceManager.ApplyResources(this.numPKThoatGame, "numPKThoatGame");
			global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.numPKThoatGame;
			int[] array22 = new int[4];
			array22[0] = 10000;
			numericUpDown22.Maximum = new decimal(array22);
			global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.numPKThoatGame;
			int[] array23 = new int[4];
			array23[0] = 1;
			numericUpDown23.Minimum = new decimal(array23);
			this.numPKThoatGame.Name = "numPKThoatGame";
			global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.numPKThoatGame;
			int[] array24 = new int[4];
			array24[0] = 1;
			numericUpDown24.Value = new decimal(array24);
			this.numPKThoatGame.ValueChanged += new global::System.EventHandler(this.numPKThoatGame_ValueChanged);
			this.numPKThoatGame.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numPKThoatGame_KeyPress);
			componentResourceManager.ApplyResources(this.cboxPKThoatGame, "cboxPKThoatGame");
			this.cboxPKThoatGame.ForeColor = global::System.Drawing.Color.Black;
			this.cboxPKThoatGame.Name = "cboxPKThoatGame";
			this.cboxPKThoatGame.UseVisualStyleBackColor = true;
			this.cboxPKThoatGame.CheckedChanged += new global::System.EventHandler(this.cboxPKThoatGame_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxNMPKBuff, "cboxNMPKBuff");
			this.cboxNMPKBuff.Name = "cboxNMPKBuff";
			this.cboxNMPKBuff.UseVisualStyleBackColor = true;
			this.cboxNMPKBuff.CheckedChanged += new global::System.EventHandler(this.cboxNMPKBuff_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxPKTuVe, "cboxPKTuVe");
			this.cboxPKTuVe.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.cboxPKTuVe.Name = "cboxPKTuVe";
			this.cboxPKTuVe.UseVisualStyleBackColor = true;
			this.cboxPKTuVe.CheckedChanged += new global::System.EventHandler(this.cboxPKTuVe_CheckedChanged);
			componentResourceManager.ApplyResources(this.label37, "label37");
			this.label37.Name = "label37";
			componentResourceManager.ApplyResources(this.label52, "label52");
			this.label52.Name = "label52";
			this.numPKSkill.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numPKSkill.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.numPKSkill, "numPKSkill");
			global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.numPKSkill;
			int[] array25 = new int[4];
			array25[0] = 30000;
			numericUpDown25.Maximum = new decimal(array25);
			global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.numPKSkill;
			int[] array26 = new int[4];
			array26[0] = 1;
			numericUpDown26.Minimum = new decimal(array26);
			this.numPKSkill.Name = "numPKSkill";
			global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.numPKSkill;
			int[] array27 = new int[4];
			array27[0] = 1;
			numericUpDown27.Value = new decimal(array27);
			this.numPKSkill.ValueChanged += new global::System.EventHandler(this.numPKSkill_ValueChanged);
			this.cboPKSkills.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboPKSkills.DropDownWidth = 200;
			componentResourceManager.ApplyResources(this.cboPKSkills, "cboPKSkills");
			this.cboPKSkills.ForeColor = global::System.Drawing.Color.Black;
			this.cboPKSkills.FormattingEnabled = true;
			this.cboPKSkills.Name = "cboPKSkills";
			this.cboPKSkills.DropDown += new global::System.EventHandler(this.cboPKSkills_DropDown);
			this.btnPKRemove.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			componentResourceManager.ApplyResources(this.btnPKRemove, "btnPKRemove");
			this.btnPKRemove.ForeColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnPKRemove.Name = "btnPKRemove";
			this.btnPKRemove.UseVisualStyleBackColor = false;
			this.btnPKRemove.Click += new global::System.EventHandler(this.btnPKRemove_Click);
			this.btnPKEdit.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			componentResourceManager.ApplyResources(this.btnPKEdit, "btnPKEdit");
			this.btnPKEdit.ForeColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnPKEdit.Name = "btnPKEdit";
			this.btnPKEdit.UseVisualStyleBackColor = false;
			this.btnPKEdit.Click += new global::System.EventHandler(this.btnPKEdit_Click);
			this.btnPKThem.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			componentResourceManager.ApplyResources(this.btnPKThem, "btnPKThem");
			this.btnPKThem.ForeColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnPKThem.Name = "btnPKThem";
			this.btnPKThem.UseVisualStyleBackColor = false;
			this.btnPKThem.Click += new global::System.EventHandler(this.btnPKThem_Click);
			this.lvPKSkills.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 165);
			this.lvPKSkills.CheckBoxes = true;
			this.lvPKSkills.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_31,
				this.columnHeader_32
			});
			componentResourceManager.ApplyResources(this.lvPKSkills, "lvPKSkills");
			this.lvPKSkills.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvPKSkills.FullRowSelect = true;
			this.lvPKSkills.GridLines = true;
			this.lvPKSkills.HideSelection = false;
			this.lvPKSkills.MultiSelect = false;
			this.lvPKSkills.Name = "lvPKSkills";
			this.lvPKSkills.UseCompatibleStateImageBehavior = false;
			this.lvPKSkills.View = global::System.Windows.Forms.View.Details;
			this.lvPKSkills.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.lvPKSkills_ItemCheck);
			componentResourceManager.ApplyResources(this.columnHeader_31, "columnHeader27");
			componentResourceManager.ApplyResources(this.columnHeader_32, "columnHeader28");
			this.groupSkillBuff.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.groupSkillBuff.Controls.Add(this.btnSkillBuffThem);
			this.groupSkillBuff.Controls.Add(this.button3);
			this.groupSkillBuff.Controls.Add(this.btnSkillBuffExpand);
			this.groupSkillBuff.Controls.Add(this.numSkillBuffLength);
			this.groupSkillBuff.Controls.Add(this.numSkillBuffDelay);
			this.groupSkillBuff.Controls.Add(this.cboSkillBuff);
			this.groupSkillBuff.Controls.Add(this.cboxBuffHoTroOnOff);
			this.groupSkillBuff.Controls.Add(this.button1);
			this.groupSkillBuff.Controls.Add(this.label55);
			this.groupSkillBuff.Controls.Add(this.label54);
			this.groupSkillBuff.Controls.Add(this.label53);
			this.groupSkillBuff.Controls.Add(this.cboxBuffQuanDoan);
			this.groupSkillBuff.Controls.Add(this.cboxBuffDanhSach);
			this.groupSkillBuff.Controls.Add(this.cboxBuffDongDoi);
			this.groupSkillBuff.Controls.Add(this.cboxBuffBanThan);
			this.groupSkillBuff.Controls.Add(this.label49);
			this.groupSkillBuff.Controls.Add(this.label36);
			this.groupSkillBuff.Controls.Add(this.btnSkillBuffDelete);
			this.groupSkillBuff.Controls.Add(this.lvSkillBuff);
			componentResourceManager.ApplyResources(this.groupSkillBuff, "groupSkillBuff");
			this.groupSkillBuff.Name = "groupSkillBuff";
			this.groupSkillBuff.TabStop = false;
			this.btnSkillBuffThem.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnSkillBuffThem, "btnSkillBuffThem");
			this.btnSkillBuffThem.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnSkillBuffThem.Name = "btnSkillBuffThem";
			this.btnSkillBuffThem.UseVisualStyleBackColor = false;
			this.btnSkillBuffThem.Click += new global::System.EventHandler(this.btnSkillBuffThem_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.button3.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.button3, "button3");
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = false;
			this.btnSkillBuffExpand.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnSkillBuffExpand, "btnSkillBuffExpand");
			this.btnSkillBuffExpand.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnSkillBuffExpand.Name = "btnSkillBuffExpand";
			this.btnSkillBuffExpand.UseVisualStyleBackColor = false;
			this.btnSkillBuffExpand.Click += new global::System.EventHandler(this.btnSkillBuffExpand_Click);
			this.numSkillBuffLength.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numSkillBuffLength.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.numSkillBuffLength, "numSkillBuffLength");
			global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.numSkillBuffLength;
			int[] array28 = new int[4];
			array28[0] = 10000;
			numericUpDown28.Maximum = new decimal(array28);
			global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.numSkillBuffLength;
			int[] array29 = new int[4];
			array29[0] = 1;
			numericUpDown29.Minimum = new decimal(array29);
			this.numSkillBuffLength.Name = "numSkillBuffLength";
			global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.numSkillBuffLength;
			int[] array30 = new int[4];
			array30[0] = 10;
			numericUpDown30.Value = new decimal(array30);
			this.numSkillBuffLength.ValueChanged += new global::System.EventHandler(this.numSkillBuffLength_ValueChanged);
			this.numSkillBuffDelay.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numSkillBuffDelay.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.numSkillBuffDelay, "numSkillBuffDelay");
			global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.numSkillBuffDelay;
			int[] array31 = new int[4];
			array31[0] = 30000;
			numericUpDown31.Maximum = new decimal(array31);
			global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.numSkillBuffDelay;
			int[] array32 = new int[4];
			array32[0] = 1;
			numericUpDown32.Minimum = new decimal(array32);
			this.numSkillBuffDelay.Name = "numSkillBuffDelay";
			global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.numSkillBuffDelay;
			int[] array33 = new int[4];
			array33[0] = 1;
			numericUpDown33.Value = new decimal(array33);
			this.numSkillBuffDelay.ValueChanged += new global::System.EventHandler(this.numSkillBuffDelay_ValueChanged);
			this.cboSkillBuff.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboSkillBuff.DropDownWidth = 200;
			componentResourceManager.ApplyResources(this.cboSkillBuff, "cboSkillBuff");
			this.cboSkillBuff.FormattingEnabled = true;
			this.cboSkillBuff.Name = "cboSkillBuff";
			this.cboSkillBuff.DropDown += new global::System.EventHandler(this.cboSkillBuff_DropDown);
			this.cboSkillBuff.SelectedIndexChanged += new global::System.EventHandler(this.cboSkillBuff_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxBuffHoTroOnOff, "cboxBuffHoTroOnOff");
			this.cboxBuffHoTroOnOff.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBuffHoTroOnOff.Checked = true;
			this.cboxBuffHoTroOnOff.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxBuffHoTroOnOff.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.cboxBuffHoTroOnOff.Name = "cboxBuffHoTroOnOff";
			this.cboxBuffHoTroOnOff.UseVisualStyleBackColor = false;
			this.cboxBuffHoTroOnOff.CheckedChanged += new global::System.EventHandler(this.cboxBuffHoTroOnOff_CheckedChanged);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.button1, "button1");
			this.button1.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			componentResourceManager.ApplyResources(this.label55, "label55");
			this.label55.Name = "label55";
			componentResourceManager.ApplyResources(this.label54, "label54");
			this.label54.Name = "label54";
			componentResourceManager.ApplyResources(this.label53, "label53");
			this.label53.Name = "label53";
			componentResourceManager.ApplyResources(this.cboxBuffQuanDoan, "cboxBuffQuanDoan");
			this.cboxBuffQuanDoan.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBuffQuanDoan.ForeColor = global::System.Drawing.Color.Black;
			this.cboxBuffQuanDoan.Name = "cboxBuffQuanDoan";
			this.cboxBuffQuanDoan.UseVisualStyleBackColor = false;
			this.cboxBuffQuanDoan.CheckedChanged += new global::System.EventHandler(this.cboxBuffQuanDoan_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBuffDanhSach, "cboxBuffDanhSach");
			this.cboxBuffDanhSach.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBuffDanhSach.Name = "cboxBuffDanhSach";
			this.cboxBuffDanhSach.UseVisualStyleBackColor = false;
			componentResourceManager.ApplyResources(this.cboxBuffDongDoi, "cboxBuffDongDoi");
			this.cboxBuffDongDoi.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBuffDongDoi.Name = "cboxBuffDongDoi";
			this.cboxBuffDongDoi.UseVisualStyleBackColor = false;
			this.cboxBuffDongDoi.CheckedChanged += new global::System.EventHandler(this.cboxBuffDongDoi_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBuffBanThan, "cboxBuffBanThan");
			this.cboxBuffBanThan.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBuffBanThan.Checked = true;
			this.cboxBuffBanThan.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxBuffBanThan.Name = "cboxBuffBanThan";
			this.cboxBuffBanThan.UseVisualStyleBackColor = false;
			this.cboxBuffBanThan.CheckedChanged += new global::System.EventHandler(this.cboxBuffBanThan_CheckedChanged);
			componentResourceManager.ApplyResources(this.label49, "label49");
			this.label49.Name = "label49";
			componentResourceManager.ApplyResources(this.label36, "label36");
			this.label36.Name = "label36";
			this.btnSkillBuffDelete.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnSkillBuffDelete, "btnSkillBuffDelete");
			this.btnSkillBuffDelete.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnSkillBuffDelete.Name = "btnSkillBuffDelete";
			this.btnSkillBuffDelete.UseVisualStyleBackColor = false;
			this.btnSkillBuffDelete.Click += new global::System.EventHandler(this.btnSkillBuffDelete_Click);
			this.lvSkillBuff.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 225);
			this.lvSkillBuff.CheckBoxes = true;
			this.lvSkillBuff.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_25,
				this.columnHeader_26,
				this.columnHeader_33,
				this.columnHeader_27,
				this.columnHeader_28,
				this.columnHeader_29,
				this.columnHeader_30
			});
			componentResourceManager.ApplyResources(this.lvSkillBuff, "lvSkillBuff");
			this.lvSkillBuff.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvSkillBuff.FullRowSelect = true;
			this.lvSkillBuff.GridLines = true;
			this.lvSkillBuff.HideSelection = false;
			this.lvSkillBuff.MultiSelect = false;
			this.lvSkillBuff.Name = "lvSkillBuff";
			this.lvSkillBuff.UseCompatibleStateImageBehavior = false;
			this.lvSkillBuff.View = global::System.Windows.Forms.View.Details;
			this.lvSkillBuff.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.lvSkillBuff_ItemCheck);
			this.lvSkillBuff.SelectedIndexChanged += new global::System.EventHandler(this.lvSkillBuff_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.columnHeader_25, "columnHeader22");
			componentResourceManager.ApplyResources(this.columnHeader_26, "columnHeader23");
			componentResourceManager.ApplyResources(this.columnHeader_33, "columnHeader29");
			componentResourceManager.ApplyResources(this.columnHeader_27, "columnHeader24");
			componentResourceManager.ApplyResources(this.columnHeader_28, "columnHeader25");
			componentResourceManager.ApplyResources(this.columnHeader_29, "columnHeader26");
			componentResourceManager.ApplyResources(this.columnHeader_30, "columnHeader21");
			this.groupKyNang.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.groupKyNang.Controls.Add(this.btnXepTen1);
			this.groupKyNang.Controls.Add(this.btnSkillPhaiExpand);
			this.groupKyNang.Controls.Add(this.cboxSkillOnOff);
			this.groupKyNang.Controls.Add(this.label28);
			this.groupKyNang.Controls.Add(this.label27);
			this.groupKyNang.Controls.Add(this.numSkillDelay);
			this.groupKyNang.Controls.Add(this.cboSkills);
			this.groupKyNang.Controls.Add(this.btnXoaSkillPlayList);
			this.groupKyNang.Controls.Add(this.btnSuaSkillPlayList);
			this.groupKyNang.Controls.Add(this.btnThemSkill);
			this.groupKyNang.Controls.Add(this.lvSkills);
			componentResourceManager.ApplyResources(this.groupKyNang, "groupKyNang");
			this.groupKyNang.Name = "groupKyNang";
			this.groupKyNang.TabStop = false;
			this.btnXepTen1.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnXepTen1.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnXepTen1, "btnXepTen1");
			this.btnXepTen1.Name = "btnXepTen1";
			this.btnXepTen1.UseVisualStyleBackColor = false;
			this.btnXepTen1.Click += new global::System.EventHandler(this.btnXepTen1_Click);
			this.btnSkillPhaiExpand.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			componentResourceManager.ApplyResources(this.btnSkillPhaiExpand, "btnSkillPhaiExpand");
			this.btnSkillPhaiExpand.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnSkillPhaiExpand.Name = "btnSkillPhaiExpand";
			this.btnSkillPhaiExpand.UseVisualStyleBackColor = false;
			this.btnSkillPhaiExpand.Click += new global::System.EventHandler(this.btnSkillPhaiExpand_Click);
			componentResourceManager.ApplyResources(this.cboxSkillOnOff, "cboxSkillOnOff");
			this.cboxSkillOnOff.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxSkillOnOff.Checked = true;
			this.cboxSkillOnOff.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxSkillOnOff.ForeColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.cboxSkillOnOff.Name = "cboxSkillOnOff";
			this.cboxSkillOnOff.UseVisualStyleBackColor = false;
			this.cboxSkillOnOff.CheckedChanged += new global::System.EventHandler(this.cboxSkillOnOff_CheckedChanged);
			componentResourceManager.ApplyResources(this.label28, "label28");
			this.label28.Name = "label28";
			componentResourceManager.ApplyResources(this.label27, "label27");
			this.label27.Name = "label27";
			this.numSkillDelay.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numSkillDelay.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.numSkillDelay, "numSkillDelay");
			global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.numSkillDelay;
			int[] array34 = new int[4];
			array34[0] = 30000;
			numericUpDown34.Maximum = new decimal(array34);
			global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.numSkillDelay;
			int[] array35 = new int[4];
			array35[0] = 1;
			numericUpDown35.Minimum = new decimal(array35);
			this.numSkillDelay.Name = "numSkillDelay";
			global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.numSkillDelay;
			int[] array36 = new int[4];
			array36[0] = 1;
			numericUpDown36.Value = new decimal(array36);
			this.cboSkills.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboSkills.DropDownWidth = 200;
			componentResourceManager.ApplyResources(this.cboSkills, "cboSkills");
			this.cboSkills.FormattingEnabled = true;
			this.cboSkills.Name = "cboSkills";
			this.cboSkills.DropDown += new global::System.EventHandler(this.cboSkills_DropDown);
			componentResourceManager.ApplyResources(this.btnXoaSkillPlayList, "btnXoaSkillPlayList");
			this.btnXoaSkillPlayList.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnXoaSkillPlayList.Name = "btnXoaSkillPlayList";
			this.btnXoaSkillPlayList.UseVisualStyleBackColor = true;
			this.btnXoaSkillPlayList.Click += new global::System.EventHandler(this.btnXoaSkillPlayList_Click);
			componentResourceManager.ApplyResources(this.btnSuaSkillPlayList, "btnSuaSkillPlayList");
			this.btnSuaSkillPlayList.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnSuaSkillPlayList.Name = "btnSuaSkillPlayList";
			this.btnSuaSkillPlayList.UseVisualStyleBackColor = true;
			this.btnSuaSkillPlayList.Click += new global::System.EventHandler(this.btnSuaSkillPlayList_Click);
			componentResourceManager.ApplyResources(this.btnThemSkill, "btnThemSkill");
			this.btnThemSkill.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnThemSkill.Name = "btnThemSkill";
			this.btnThemSkill.UseVisualStyleBackColor = true;
			this.btnThemSkill.Click += new global::System.EventHandler(this.btnThemSkill_Click);
			this.lvSkills.BackColor = global::System.Drawing.Color.Lavender;
			this.lvSkills.CheckBoxes = true;
			this.lvSkills.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_23,
				this.columnHeader_24
			});
			componentResourceManager.ApplyResources(this.lvSkills, "lvSkills");
			this.lvSkills.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvSkills.FullRowSelect = true;
			this.lvSkills.GridLines = true;
			this.lvSkills.HideSelection = false;
			this.lvSkills.MultiSelect = false;
			this.lvSkills.Name = "lvSkills";
			this.lvSkills.UseCompatibleStateImageBehavior = false;
			this.lvSkills.View = global::System.Windows.Forms.View.Details;
			this.lvSkills.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.lvSkills_ItemCheck);
			componentResourceManager.ApplyResources(this.columnHeader_23, "colSkillName");
			componentResourceManager.ApplyResources(this.columnHeader_24, "colDelay");
			this.tabVatPham.BackColor = global::System.Drawing.Color.Transparent;
			this.tabVatPham.Controls.Add(this.btnCheDoSettings);
			this.tabVatPham.Controls.Add(this.label75);
			this.tabVatPham.Controls.Add(this.btnCD50acc);
			this.tabVatPham.Controls.Add(this.btnCD5acc);
			this.tabVatPham.Controls.Add(this.btnCD2acc);
			this.tabVatPham.Controls.Add(this.btnSellNow);
			this.tabVatPham.Controls.Add(this.lblCDCount);
			this.tabVatPham.Controls.Add(this.lblCDTime);
			this.tabVatPham.Controls.Add(this.rdioNhatListIgnore);
			this.tabVatPham.Controls.Add(this.btnHuyNow);
			this.tabVatPham.Controls.Add(this.groupBox2);
			this.tabVatPham.Controls.Add(this.cboxGiamDinh);
			this.tabVatPham.Controls.Add(this.cboxIsCheDo);
			this.tabVatPham.Controls.Add(this.numBanKinhNhat);
			this.tabVatPham.Controls.Add(this.cboxGiuVuKhi);
			this.tabVatPham.Controls.Add(this.rdioNhatHet);
			this.tabVatPham.Controls.Add(this.numFullThung);
			this.tabVatPham.Controls.Add(this.cboxFullStopNhat);
			this.tabVatPham.Controls.Add(this.cboxFullThungVT);
			this.tabVatPham.Controls.Add(this.cboItemTuHuy);
			this.tabVatPham.Controls.Add(this.cboxTuMuaBan);
			this.tabVatPham.Controls.Add(this.numGiuDoDong);
			this.tabVatPham.Controls.Add(this.label41);
			this.tabVatPham.Controls.Add(this.numGiuDoSao);
			this.tabVatPham.Controls.Add(this.label40);
			this.tabVatPham.Controls.Add(this.cboxVutDoKhiFull);
			this.tabVatPham.Controls.Add(this.cboxTuNhatVatPham);
			this.tabVatPham.Controls.Add(this.rdioNhatList);
			this.tabVatPham.Controls.Add(this.btnListNhatIgnore);
			this.tabVatPham.Controls.Add(this.btnItemTuBan);
			this.tabVatPham.Controls.Add(this.btnListTuHuy);
			this.tabVatPham.Controls.Add(this.btnListNhat);
			componentResourceManager.ApplyResources(this.tabVatPham, "tabVatPham");
			this.tabVatPham.Name = "tabVatPham";
			this.btnCheDoSettings.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnCheDoSettings, "btnCheDoSettings");
			this.btnCheDoSettings.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnCheDoSettings.Image = global::ns0.Class212.setting;
			this.btnCheDoSettings.Name = "btnCheDoSettings";
			this.btnCheDoSettings.UseVisualStyleBackColor = false;
			this.btnCheDoSettings.Click += new global::System.EventHandler(this.btnCheDoSettings_Click);
			componentResourceManager.ApplyResources(this.label75, "label75");
			this.label75.Name = "label75";
			this.label75.Click += new global::System.EventHandler(this.label75_Click);
			this.btnCD50acc.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnCD50acc.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnCD50acc, "btnCD50acc");
			this.btnCD50acc.Name = "btnCD50acc";
			this.btnCD50acc.UseVisualStyleBackColor = false;
			this.btnCD50acc.Click += new global::System.EventHandler(this.btnCD50acc_Click);
			this.btnCD5acc.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnCD5acc.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnCD5acc, "btnCD5acc");
			this.btnCD5acc.Name = "btnCD5acc";
			this.btnCD5acc.UseVisualStyleBackColor = false;
			this.btnCD5acc.Click += new global::System.EventHandler(this.btnCD5acc_Click);
			this.btnCD2acc.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnCD2acc.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnCD2acc, "btnCD2acc");
			this.btnCD2acc.Name = "btnCD2acc";
			this.btnCD2acc.UseVisualStyleBackColor = false;
			this.btnCD2acc.Click += new global::System.EventHandler(this.btnCD2acc_Click);
			this.btnSellNow.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnSellNow.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnSellNow, "btnSellNow");
			this.btnSellNow.Name = "btnSellNow";
			this.btnSellNow.UseVisualStyleBackColor = false;
			this.btnSellNow.Click += new global::System.EventHandler(this.btnSellNow_Click);
			componentResourceManager.ApplyResources(this.lblCDCount, "lblCDCount");
			this.lblCDCount.Name = "lblCDCount";
			componentResourceManager.ApplyResources(this.lblCDTime, "lblCDTime");
			this.lblCDTime.Name = "lblCDTime";
			this.lblCDTime.Click += new global::System.EventHandler(this.lblCDTime_Click);
			componentResourceManager.ApplyResources(this.rdioNhatListIgnore, "rdioNhatListIgnore");
			this.rdioNhatListIgnore.Name = "rdioNhatListIgnore";
			this.rdioNhatListIgnore.UseVisualStyleBackColor = true;
			this.rdioNhatListIgnore.CheckedChanged += new global::System.EventHandler(this.rdioNhatListIgnore_CheckedChanged);
			this.btnHuyNow.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnHuyNow.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnHuyNow, "btnHuyNow");
			this.btnHuyNow.Name = "btnHuyNow";
			this.btnHuyNow.UseVisualStyleBackColor = false;
			this.btnHuyNow.Click += new global::System.EventHandler(this.btnHuyNow_Click);
			this.groupBox2.Controls.Add(this.groupItemUse);
			this.groupBox2.Controls.Add(this.groupMuaDo);
			componentResourceManager.ApplyResources(this.groupBox2, "groupBox2");
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.TabStop = false;
			this.groupBox2.Enter += new global::System.EventHandler(this.groupBox2_Enter);
			this.groupItemUse.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupItemUse.Controls.Add(this.btnItemUse);
			this.groupItemUse.Controls.Add(this.btnItemUseExpand);
			this.groupItemUse.Controls.Add(this.label45);
			this.groupItemUse.Controls.Add(this.lvItemUse);
			this.groupItemUse.Controls.Add(this.numItemUse);
			this.groupItemUse.Controls.Add(this.cboItemUse);
			componentResourceManager.ApplyResources(this.groupItemUse, "groupItemUse");
			this.groupItemUse.Name = "groupItemUse";
			this.groupItemUse.TabStop = false;
			this.btnItemUse.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnItemUse.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnItemUse, "btnItemUse");
			this.btnItemUse.Name = "btnItemUse";
			this.btnItemUse.UseVisualStyleBackColor = false;
			this.btnItemUse.Click += new global::System.EventHandler(this.btnItemUse_Click);
			this.btnItemUseExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnItemUseExpand, "btnItemUseExpand");
			this.btnItemUseExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnItemUseExpand.Name = "btnItemUseExpand";
			this.btnItemUseExpand.UseVisualStyleBackColor = false;
			this.btnItemUseExpand.Click += new global::System.EventHandler(this.btnItemUseExpand_Click);
			componentResourceManager.ApplyResources(this.label45, "label45");
			this.label45.BackColor = global::System.Drawing.Color.Transparent;
			this.label45.Name = "label45";
			this.lvItemUse.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvItemUse.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvItemUse.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_36,
				this.columnHeader_37
			});
			this.lvItemUse.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvItemUse.FullRowSelect = true;
			this.lvItemUse.GridLines = true;
			this.lvItemUse.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvItemUse.HideSelection = false;
			componentResourceManager.ApplyResources(this.lvItemUse, "lvItemUse");
			this.lvItemUse.Name = "lvItemUse";
			this.lvItemUse.UseCompatibleStateImageBehavior = false;
			this.lvItemUse.View = global::System.Windows.Forms.View.Details;
			this.lvItemUse.SelectedIndexChanged += new global::System.EventHandler(this.lvItemUse_SelectedIndexChanged);
			this.lvItemUse.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvItemUse_MouseDoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_36, "columnHeader4");
			componentResourceManager.ApplyResources(this.columnHeader_37, "columnHeader16");
			this.numItemUse.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numItemUse.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.numItemUse, "numItemUse");
			global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.numItemUse;
			int[] array37 = new int[4];
			array37[0] = 90000;
			numericUpDown37.Maximum = new decimal(array37);
			this.numItemUse.Name = "numItemUse";
			global::System.Windows.Forms.NumericUpDown numericUpDown38 = this.numItemUse;
			int[] array38 = new int[4];
			array38[0] = 20;
			numericUpDown38.Value = new decimal(array38);
			this.cboItemUse.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboItemUse.DropDownWidth = 120;
			componentResourceManager.ApplyResources(this.cboItemUse, "cboItemUse");
			this.cboItemUse.FormattingEnabled = true;
			this.cboItemUse.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboItemUse.Items"),
				componentResourceManager.GetString("cboItemUse.Items1"),
				componentResourceManager.GetString("cboItemUse.Items2"),
				componentResourceManager.GetString("cboItemUse.Items3")
			});
			this.cboItemUse.Name = "cboItemUse";
			this.cboItemUse.DropDown += new global::System.EventHandler(this.cboItemUse_DropDown);
			this.cboItemUse.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.cboItemUse_MouseDoubleClick);
			this.groupMuaDo.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupMuaDo.Controls.Add(this.btnMuaNgay_KNB);
			this.groupMuaDo.Controls.Add(this.btnMuaDoExpand);
			this.groupMuaDo.Controls.Add(this.btnMuaNgay);
			this.groupMuaDo.Controls.Add(this.lvItemMua);
			this.groupMuaDo.Controls.Add(this.numItemMua);
			this.groupMuaDo.Controls.Add(this.btnItemMuaThem);
			this.groupMuaDo.Controls.Add(this.cboItemMua);
			componentResourceManager.ApplyResources(this.groupMuaDo, "groupMuaDo");
			this.groupMuaDo.Name = "groupMuaDo";
			this.groupMuaDo.TabStop = false;
			this.btnMuaNgay_KNB.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnMuaNgay_KNB, "btnMuaNgay_KNB");
			this.btnMuaNgay_KNB.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnMuaNgay_KNB.Name = "btnMuaNgay_KNB";
			this.btnMuaNgay_KNB.UseVisualStyleBackColor = false;
			this.btnMuaNgay_KNB.Click += new global::System.EventHandler(this.btnMuaNgay_KNB_Click);
			this.btnMuaDoExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnMuaDoExpand, "btnMuaDoExpand");
			this.btnMuaDoExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnMuaDoExpand.Name = "btnMuaDoExpand";
			this.btnMuaDoExpand.UseVisualStyleBackColor = false;
			this.btnMuaDoExpand.Click += new global::System.EventHandler(this.btnMuaDoExpand_Click);
			this.btnMuaNgay.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			componentResourceManager.ApplyResources(this.btnMuaNgay, "btnMuaNgay");
			this.btnMuaNgay.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnMuaNgay.Name = "btnMuaNgay";
			this.btnMuaNgay.UseVisualStyleBackColor = false;
			this.btnMuaNgay.Click += new global::System.EventHandler(this.btnMuaNgay_Click);
			this.lvItemMua.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvItemMua.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvItemMua.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_5,
				this.columnHeader_6
			});
			this.lvItemMua.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvItemMua.FullRowSelect = true;
			this.lvItemMua.GridLines = true;
			this.lvItemMua.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvItemMua.HideSelection = false;
			componentResourceManager.ApplyResources(this.lvItemMua, "lvItemMua");
			this.lvItemMua.Name = "lvItemMua";
			this.lvItemMua.UseCompatibleStateImageBehavior = false;
			this.lvItemMua.View = global::System.Windows.Forms.View.Details;
			this.lvItemMua.SelectedIndexChanged += new global::System.EventHandler(this.lvItemMua_SelectedIndexChanged);
			this.lvItemMua.DoubleClick += new global::System.EventHandler(this.lvItemMua_DoubleClick);
			componentResourceManager.ApplyResources(this.columnHeader_5, "columnHeader2");
			componentResourceManager.ApplyResources(this.columnHeader_6, "columnHeader3");
			this.numItemMua.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.numItemMua.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.numItemMua, "numItemMua");
			global::System.Windows.Forms.NumericUpDown numericUpDown39 = this.numItemMua;
			int[] array39 = new int[4];
			array39[0] = 500;
			numericUpDown39.Maximum = new decimal(array39);
			this.numItemMua.Name = "numItemMua";
			global::System.Windows.Forms.NumericUpDown numericUpDown40 = this.numItemMua;
			int[] array40 = new int[4];
			array40[0] = 1;
			numericUpDown40.Value = new decimal(array40);
			this.numItemMua.ValueChanged += new global::System.EventHandler(this.numItemMua_ValueChanged);
			this.btnItemMuaThem.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnItemMuaThem.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnItemMuaThem, "btnItemMuaThem");
			this.btnItemMuaThem.Name = "btnItemMuaThem";
			this.btnItemMuaThem.UseVisualStyleBackColor = false;
			this.btnItemMuaThem.Click += new global::System.EventHandler(this.btnItemMuaThem_Click);
			this.cboItemMua.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboItemMua.DropDownWidth = 180;
			componentResourceManager.ApplyResources(this.cboItemMua, "cboItemMua");
			this.cboItemMua.FormattingEnabled = true;
			this.cboItemMua.Name = "cboItemMua";
			this.cboItemMua.SelectedIndexChanged += new global::System.EventHandler(this.cboItemMua_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxGiamDinh, "cboxGiamDinh");
			this.cboxGiamDinh.Name = "cboxGiamDinh";
			this.cboxGiamDinh.UseVisualStyleBackColor = true;
			this.cboxGiamDinh.CheckedChanged += new global::System.EventHandler(this.cboxGiamDinh_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsCheDo, "cboxIsCheDo");
			this.cboxIsCheDo.ForeColor = global::System.Drawing.Color.OrangeRed;
			this.cboxIsCheDo.Name = "cboxIsCheDo";
			this.cboxIsCheDo.UseVisualStyleBackColor = true;
			this.cboxIsCheDo.CheckedChanged += new global::System.EventHandler(this.cboxIsCheDo_CheckedChanged);
			this.numBanKinhNhat.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numBanKinhNhat, "numBanKinhNhat");
			global::System.Windows.Forms.NumericUpDown numericUpDown41 = this.numBanKinhNhat;
			int[] array41 = new int[4];
			array41[0] = 40;
			numericUpDown41.Maximum = new decimal(array41);
			global::System.Windows.Forms.NumericUpDown numericUpDown42 = this.numBanKinhNhat;
			int[] array42 = new int[4];
			array42[0] = 1;
			numericUpDown42.Minimum = new decimal(array42);
			this.numBanKinhNhat.Name = "numBanKinhNhat";
			global::System.Windows.Forms.NumericUpDown numericUpDown43 = this.numBanKinhNhat;
			int[] array43 = new int[4];
			array43[0] = 30;
			numericUpDown43.Value = new decimal(array43);
			this.numBanKinhNhat.ValueChanged += new global::System.EventHandler(this.numBanKinhNhat_ValueChanged);
			this.numBanKinhNhat.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numBanKinhNhat_KeyPress);
			componentResourceManager.ApplyResources(this.cboxGiuVuKhi, "cboxGiuVuKhi");
			this.cboxGiuVuKhi.ForeColor = global::System.Drawing.Color.Black;
			this.cboxGiuVuKhi.Name = "cboxGiuVuKhi";
			this.cboxGiuVuKhi.UseVisualStyleBackColor = true;
			this.cboxGiuVuKhi.CheckedChanged += new global::System.EventHandler(this.cboxGiuVuKhi_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioNhatHet, "rdioNhatHet");
			this.rdioNhatHet.Checked = true;
			this.rdioNhatHet.Name = "rdioNhatHet";
			this.rdioNhatHet.TabStop = true;
			this.rdioNhatHet.UseVisualStyleBackColor = true;
			this.rdioNhatHet.CheckedChanged += new global::System.EventHandler(this.rdioNhatHet_CheckedChanged);
			this.numFullThung.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numFullThung, "numFullThung");
			global::System.Windows.Forms.NumericUpDown numericUpDown44 = this.numFullThung;
			int[] array44 = new int[4];
			array44[0] = 20;
			numericUpDown44.Maximum = new decimal(array44);
			global::System.Windows.Forms.NumericUpDown numericUpDown45 = this.numFullThung;
			int[] array45 = new int[4];
			array45[0] = 1;
			numericUpDown45.Minimum = new decimal(array45);
			this.numFullThung.Name = "numFullThung";
			global::System.Windows.Forms.NumericUpDown numericUpDown46 = this.numFullThung;
			int[] array46 = new int[4];
			array46[0] = 1;
			numericUpDown46.Value = new decimal(array46);
			this.numFullThung.ValueChanged += new global::System.EventHandler(this.numFullThung_ValueChanged);
			this.numFullThung.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numFullThung_KeyPress);
			componentResourceManager.ApplyResources(this.cboxFullStopNhat, "cboxFullStopNhat");
			this.cboxFullStopNhat.Name = "cboxFullStopNhat";
			this.cboxFullStopNhat.UseVisualStyleBackColor = true;
			this.cboxFullStopNhat.CheckedChanged += new global::System.EventHandler(this.cboxFullStopNhat_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxFullThungVT, "cboxFullThungVT");
			this.cboxFullThungVT.Name = "cboxFullThungVT";
			this.cboxFullThungVT.UseVisualStyleBackColor = true;
			this.cboxFullThungVT.CheckedChanged += new global::System.EventHandler(this.cboxFullThungVT_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboItemTuHuy, "cboItemTuHuy");
			this.cboItemTuHuy.Name = "cboItemTuHuy";
			this.cboItemTuHuy.UseVisualStyleBackColor = true;
			this.cboItemTuHuy.CheckedChanged += new global::System.EventHandler(this.cboItemTuHuy_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTuMuaBan, "cboxTuMuaBan");
			this.cboxTuMuaBan.Name = "cboxTuMuaBan";
			this.cboxTuMuaBan.UseVisualStyleBackColor = true;
			this.cboxTuMuaBan.CheckedChanged += new global::System.EventHandler(this.cboxTuMuaBan_CheckedChanged);
			componentResourceManager.ApplyResources(this.numGiuDoDong, "numGiuDoDong");
			global::System.Windows.Forms.NumericUpDown numericUpDown47 = this.numGiuDoDong;
			int[] array47 = new int[4];
			array47[0] = 20;
			numericUpDown47.Maximum = new decimal(array47);
			global::System.Windows.Forms.NumericUpDown numericUpDown48 = this.numGiuDoDong;
			int[] array48 = new int[4];
			array48[0] = 1;
			numericUpDown48.Minimum = new decimal(array48);
			this.numGiuDoDong.Name = "numGiuDoDong";
			global::System.Windows.Forms.NumericUpDown numericUpDown49 = this.numGiuDoDong;
			int[] array49 = new int[4];
			array49[0] = 10;
			numericUpDown49.Value = new decimal(array49);
			this.numGiuDoDong.ValueChanged += new global::System.EventHandler(this.numGiuDoDong_ValueChanged);
			this.numGiuDoDong.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numGiuDoDong_KeyPress);
			componentResourceManager.ApplyResources(this.label41, "label41");
			this.label41.Name = "label41";
			componentResourceManager.ApplyResources(this.numGiuDoSao, "numGiuDoSao");
			global::System.Windows.Forms.NumericUpDown numericUpDown50 = this.numGiuDoSao;
			int[] array50 = new int[4];
			array50[0] = 20;
			numericUpDown50.Maximum = new decimal(array50);
			global::System.Windows.Forms.NumericUpDown numericUpDown51 = this.numGiuDoSao;
			int[] array51 = new int[4];
			array51[0] = 1;
			numericUpDown51.Minimum = new decimal(array51);
			this.numGiuDoSao.Name = "numGiuDoSao";
			global::System.Windows.Forms.NumericUpDown numericUpDown52 = this.numGiuDoSao;
			int[] array52 = new int[4];
			array52[0] = 4;
			numericUpDown52.Value = new decimal(array52);
			this.numGiuDoSao.ValueChanged += new global::System.EventHandler(this.numGiuDoSao_ValueChanged);
			this.numGiuDoSao.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numGiuDoSao_KeyPress);
			componentResourceManager.ApplyResources(this.label40, "label40");
			this.label40.Name = "label40";
			componentResourceManager.ApplyResources(this.cboxVutDoKhiFull, "cboxVutDoKhiFull");
			this.cboxVutDoKhiFull.ForeColor = global::System.Drawing.Color.Black;
			this.cboxVutDoKhiFull.Name = "cboxVutDoKhiFull";
			this.cboxVutDoKhiFull.UseVisualStyleBackColor = true;
			this.cboxVutDoKhiFull.CheckedChanged += new global::System.EventHandler(this.cboxVutDoKhiFull_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTuNhatVatPham, "cboxTuNhatVatPham");
			this.cboxTuNhatVatPham.Name = "cboxTuNhatVatPham";
			this.cboxTuNhatVatPham.UseVisualStyleBackColor = true;
			this.cboxTuNhatVatPham.CheckedChanged += new global::System.EventHandler(this.cboxTuNhatVatPham_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioNhatList, "rdioNhatList");
			this.rdioNhatList.Name = "rdioNhatList";
			this.rdioNhatList.UseVisualStyleBackColor = true;
			this.rdioNhatList.CheckedChanged += new global::System.EventHandler(this.rdioNhatList_CheckedChanged);
			this.btnListNhatIgnore.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnListNhatIgnore, "btnListNhatIgnore");
			this.btnListNhatIgnore.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnListNhatIgnore.Name = "btnListNhatIgnore";
			this.btnListNhatIgnore.UseVisualStyleBackColor = false;
			this.btnListNhatIgnore.Click += new global::System.EventHandler(this.btnListNhatIgnore_Click);
			this.btnItemTuBan.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnItemTuBan, "btnItemTuBan");
			this.btnItemTuBan.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnItemTuBan.Name = "btnItemTuBan";
			this.btnItemTuBan.UseVisualStyleBackColor = false;
			this.btnItemTuBan.Click += new global::System.EventHandler(this.btnItemTuBan_Click);
			this.btnListTuHuy.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnListTuHuy, "btnListTuHuy");
			this.btnListTuHuy.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnListTuHuy.Name = "btnListTuHuy";
			this.btnListTuHuy.UseVisualStyleBackColor = false;
			this.btnListTuHuy.Click += new global::System.EventHandler(this.btnListTuHuy_Click);
			this.btnListNhat.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnListNhat, "btnListNhat");
			this.btnListNhat.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.btnListNhat.Name = "btnListNhat";
			this.btnListNhat.UseVisualStyleBackColor = false;
			this.btnListNhat.Click += new global::System.EventHandler(this.btnListNhat_Click);
			this.tabThuongNhan.BackColor = global::System.Drawing.Color.Transparent;
			this.tabThuongNhan.Controls.Add(this.groupThuongNhan);
			componentResourceManager.ApplyResources(this.tabThuongNhan, "tabThuongNhan");
			this.tabThuongNhan.Name = "tabThuongNhan";
			this.groupThuongNhan.BackColor = global::System.Drawing.Color.LightCyan;
			this.groupThuongNhan.Controls.Add(this.cboxFixKetThanh);
			this.groupThuongNhan.Controls.Add(this.rdioTNTheoChiDinh);
			this.groupThuongNhan.Controls.Add(this.groupTNThanhMinh);
			this.groupThuongNhan.Controls.Add(this.groupTNThanhFriend);
			this.groupThuongNhan.Controls.Add(this.btnXoaDuLieuTN);
			this.groupThuongNhan.Controls.Add(this.btnChayHuongNao);
			this.groupThuongNhan.Controls.Add(this.cboxTNTuNhanPhieu);
			this.groupThuongNhan.Controls.Add(this.lblPath);
			this.groupThuongNhan.Controls.Add(this.rdioTNAutoMua);
			this.groupThuongNhan.Controls.Add(this.numTNRounds);
			this.groupThuongNhan.Controls.Add(this.label46);
			this.groupThuongNhan.Controls.Add(this.btnTNStop);
			this.groupThuongNhan.Controls.Add(this.btnTNChayVe);
			this.groupThuongNhan.Controls.Add(this.btnTNChayDi);
			this.groupThuongNhan.Controls.Add(this.cboxTNFullAuto);
			componentResourceManager.ApplyResources(this.groupThuongNhan, "groupThuongNhan");
			this.groupThuongNhan.Name = "groupThuongNhan";
			this.groupThuongNhan.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxFixKetThanh, "cboxFixKetThanh");
			this.cboxFixKetThanh.Name = "cboxFixKetThanh";
			this.cboxFixKetThanh.UseVisualStyleBackColor = true;
			this.cboxFixKetThanh.CheckedChanged += new global::System.EventHandler(this.cboxFixKetThanh_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioTNTheoChiDinh, "rdioTNTheoChiDinh");
			this.rdioTNTheoChiDinh.Name = "rdioTNTheoChiDinh";
			this.rdioTNTheoChiDinh.UseVisualStyleBackColor = true;
			this.rdioTNTheoChiDinh.CheckedChanged += new global::System.EventHandler(this.rdioTNTheoChiDinh_CheckedChanged);
			this.groupTNThanhMinh.BackColor = global::System.Drawing.Color.FromArgb(255, 224, 192);
			this.groupTNThanhMinh.Controls.Add(this.tboxIDBang);
			this.groupTNThanhMinh.Controls.Add(this.txtTNMinhGiaHigher);
			this.groupTNThanhMinh.Controls.Add(this.cboxTNMinhGiaHigher);
			this.groupTNThanhMinh.Controls.Add(this.lblTNMinhGia);
			this.groupTNThanhMinh.Controls.Add(this.cboTNMinhItem);
			this.groupTNThanhMinh.Controls.Add(this.label69);
			componentResourceManager.ApplyResources(this.groupTNThanhMinh, "groupTNThanhMinh");
			this.groupTNThanhMinh.Name = "groupTNThanhMinh";
			this.groupTNThanhMinh.TabStop = false;
			this.tboxIDBang.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.tboxIDBang, "tboxIDBang");
			this.tboxIDBang.Name = "tboxIDBang";
			this.tboxIDBang.TextChanged += new global::System.EventHandler(this.tboxIDBang_TextChanged);
			this.txtTNMinhGiaHigher.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTNMinhGiaHigher, "txtTNMinhGiaHigher");
			this.txtTNMinhGiaHigher.Name = "txtTNMinhGiaHigher";
			this.txtTNMinhGiaHigher.TextChanged += new global::System.EventHandler(this.txtTNMinhGiaHigher_TextChanged);
			componentResourceManager.ApplyResources(this.cboxTNMinhGiaHigher, "cboxTNMinhGiaHigher");
			this.cboxTNMinhGiaHigher.Name = "cboxTNMinhGiaHigher";
			this.cboxTNMinhGiaHigher.UseVisualStyleBackColor = true;
			this.cboxTNMinhGiaHigher.CheckedChanged += new global::System.EventHandler(this.cboxTNMinhGiaHigher_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblTNMinhGia, "lblTNMinhGia");
			this.lblTNMinhGia.Name = "lblTNMinhGia";
			componentResourceManager.ApplyResources(this.cboTNMinhItem, "cboTNMinhItem");
			this.cboTNMinhItem.FormattingEnabled = true;
			this.cboTNMinhItem.Name = "cboTNMinhItem";
			this.cboTNMinhItem.SelectedIndexChanged += new global::System.EventHandler(this.cboTNMinhItem_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label69, "label69");
			this.label69.Name = "label69";
			this.groupTNThanhFriend.BackColor = global::System.Drawing.Color.FromArgb(255, 224, 192);
			this.groupTNThanhFriend.Controls.Add(this.txtTNFriendGia);
			this.groupTNThanhFriend.Controls.Add(this.tboxIDFriend);
			this.groupTNThanhFriend.Controls.Add(this.cboxTNFriendGiaHigher);
			this.groupTNThanhFriend.Controls.Add(this.lblTNFriendGia);
			this.groupTNThanhFriend.Controls.Add(this.cboTNFriendItem);
			this.groupTNThanhFriend.Controls.Add(this.label65);
			componentResourceManager.ApplyResources(this.groupTNThanhFriend, "groupTNThanhFriend");
			this.groupTNThanhFriend.Name = "groupTNThanhFriend";
			this.groupTNThanhFriend.TabStop = false;
			this.txtTNFriendGia.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTNFriendGia, "txtTNFriendGia");
			this.txtTNFriendGia.Name = "txtTNFriendGia";
			this.txtTNFriendGia.TextChanged += new global::System.EventHandler(this.txtTNFriendGia_TextChanged);
			this.tboxIDFriend.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.tboxIDFriend, "tboxIDFriend");
			this.tboxIDFriend.Name = "tboxIDFriend";
			this.tboxIDFriend.TextChanged += new global::System.EventHandler(this.tboxIDFriend_TextChanged);
			componentResourceManager.ApplyResources(this.cboxTNFriendGiaHigher, "cboxTNFriendGiaHigher");
			this.cboxTNFriendGiaHigher.Name = "cboxTNFriendGiaHigher";
			this.cboxTNFriendGiaHigher.UseVisualStyleBackColor = true;
			this.cboxTNFriendGiaHigher.CheckedChanged += new global::System.EventHandler(this.cboxTNFriendGiaHigher_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblTNFriendGia, "lblTNFriendGia");
			this.lblTNFriendGia.Name = "lblTNFriendGia";
			componentResourceManager.ApplyResources(this.cboTNFriendItem, "cboTNFriendItem");
			this.cboTNFriendItem.FormattingEnabled = true;
			this.cboTNFriendItem.Name = "cboTNFriendItem";
			this.cboTNFriendItem.SelectedIndexChanged += new global::System.EventHandler(this.cboTNFriendItem_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label65, "label65");
			this.label65.Name = "label65";
			componentResourceManager.ApplyResources(this.btnXoaDuLieuTN, "btnXoaDuLieuTN");
			this.btnXoaDuLieuTN.Name = "btnXoaDuLieuTN";
			this.btnXoaDuLieuTN.UseVisualStyleBackColor = true;
			this.btnXoaDuLieuTN.Click += new global::System.EventHandler(this.btnXoaDuLieuTN_Click);
			componentResourceManager.ApplyResources(this.btnChayHuongNao, "btnChayHuongNao");
			this.btnChayHuongNao.Name = "btnChayHuongNao";
			this.btnChayHuongNao.UseVisualStyleBackColor = true;
			this.btnChayHuongNao.Click += new global::System.EventHandler(this.btnChayHuongNao_Click);
			componentResourceManager.ApplyResources(this.cboxTNTuNhanPhieu, "cboxTNTuNhanPhieu");
			this.cboxTNTuNhanPhieu.Name = "cboxTNTuNhanPhieu";
			this.cboxTNTuNhanPhieu.UseVisualStyleBackColor = true;
			this.cboxTNTuNhanPhieu.CheckedChanged += new global::System.EventHandler(this.cboxTNTuNhanPhieu_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblPath, "lblPath");
			this.lblPath.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.lblPath.Name = "lblPath";
			componentResourceManager.ApplyResources(this.rdioTNAutoMua, "rdioTNAutoMua");
			this.rdioTNAutoMua.Checked = true;
			this.rdioTNAutoMua.Name = "rdioTNAutoMua";
			this.rdioTNAutoMua.TabStop = true;
			this.rdioTNAutoMua.UseVisualStyleBackColor = true;
			this.rdioTNAutoMua.CheckedChanged += new global::System.EventHandler(this.rdioTNAutoMua_CheckedChanged);
			componentResourceManager.ApplyResources(this.numTNRounds, "numTNRounds");
			this.numTNRounds.Name = "numTNRounds";
			global::System.Windows.Forms.NumericUpDown numericUpDown53 = this.numTNRounds;
			int[] array53 = new int[4];
			array53[0] = 8;
			numericUpDown53.Value = new decimal(array53);
			this.numTNRounds.ValueChanged += new global::System.EventHandler(this.numTNRounds_ValueChanged);
			this.numTNRounds.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numTNRounds_KeyPress);
			componentResourceManager.ApplyResources(this.label46, "label46");
			this.label46.Name = "label46";
			this.label46.Click += new global::System.EventHandler(this.label46_Click);
			this.btnTNStop.BackColor = global::System.Drawing.Color.OrangeRed;
			componentResourceManager.ApplyResources(this.btnTNStop, "btnTNStop");
			this.btnTNStop.ForeColor = global::System.Drawing.Color.White;
			this.btnTNStop.Name = "btnTNStop";
			this.btnTNStop.UseVisualStyleBackColor = false;
			this.btnTNStop.Click += new global::System.EventHandler(this.btnTNStop_Click);
			this.btnTNChayVe.BackColor = global::System.Drawing.Color.LightGreen;
			componentResourceManager.ApplyResources(this.btnTNChayVe, "btnTNChayVe");
			this.btnTNChayVe.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnTNChayVe.Name = "btnTNChayVe";
			this.btnTNChayVe.UseVisualStyleBackColor = false;
			this.btnTNChayVe.Click += new global::System.EventHandler(this.btnTNChayVe_Click);
			this.btnTNChayDi.BackColor = global::System.Drawing.Color.LightGreen;
			componentResourceManager.ApplyResources(this.btnTNChayDi, "btnTNChayDi");
			this.btnTNChayDi.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.btnTNChayDi.Name = "btnTNChayDi";
			this.btnTNChayDi.UseVisualStyleBackColor = false;
			this.btnTNChayDi.Click += new global::System.EventHandler(this.btnTNChayDi_Click);
			componentResourceManager.ApplyResources(this.cboxTNFullAuto, "cboxTNFullAuto");
			this.cboxTNFullAuto.Name = "cboxTNFullAuto";
			this.cboxTNFullAuto.UseVisualStyleBackColor = true;
			this.cboxTNFullAuto.CheckedChanged += new global::System.EventHandler(this.cboxTNFullAuto_CheckedChanged);
			this.tabNhiemVu.Controls.Add(this.groupYTO);
			this.tabNhiemVu.Controls.Add(this.groupQ123);
			this.tabNhiemVu.Controls.Add(this.groupBaoRuong);
			this.tabNhiemVu.Controls.Add(this.groupQSM);
			this.tabNhiemVu.Controls.Add(this.groupTKC);
			this.tabNhiemVu.Controls.Add(this.groupTBB);
			this.tabNhiemVu.Controls.Add(this.groupMuaKNB);
			this.tabNhiemVu.Controls.Add(this.groupLuyenKim);
			this.tabNhiemVu.Controls.Add(this.groupTrungAc);
			this.tabNhiemVu.Controls.Add(this.groupAcTac);
			this.tabNhiemVu.Controls.Add(this.groupDuaHau);
			this.tabNhiemVu.Controls.Add(this.groupKhaiKhoang);
			this.tabNhiemVu.Controls.Add(this.groupPhuBanTuyChinh);
			this.tabNhiemVu.Controls.Add(this.groupScheduler);
			componentResourceManager.ApplyResources(this.tabNhiemVu, "tabNhiemVu");
			this.tabNhiemVu.Name = "tabNhiemVu";
			this.tabNhiemVu.UseVisualStyleBackColor = true;
			this.groupYTO.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.groupYTO.Controls.Add(this.lblYTOTimer);
			this.groupYTO.Controls.Add(this.cboxYTOGiaHan);
			this.groupYTO.Controls.Add(this.btnYTO3h);
			this.groupYTO.Controls.Add(this.btnYTO1h);
			this.groupYTO.Controls.Add(this.btnDiCanTro);
			this.groupYTO.Controls.Add(this.cboxIsYTO);
			this.groupYTO.Controls.Add(this.btnYTOExtend);
			componentResourceManager.ApplyResources(this.groupYTO, "groupYTO");
			this.groupYTO.Name = "groupYTO";
			this.groupYTO.TabStop = false;
			componentResourceManager.ApplyResources(this.lblYTOTimer, "lblYTOTimer");
			this.lblYTOTimer.Name = "lblYTOTimer";
			this.lblYTOTimer.Click += new global::System.EventHandler(this.lblYTOTimer_Click);
			componentResourceManager.ApplyResources(this.cboxYTOGiaHan, "cboxYTOGiaHan");
			this.cboxYTOGiaHan.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxYTOGiaHan.Name = "cboxYTOGiaHan";
			this.cboxYTOGiaHan.UseVisualStyleBackColor = false;
			this.cboxYTOGiaHan.CheckedChanged += new global::System.EventHandler(this.cboxYTOGiaHan_CheckedChanged);
			this.btnYTO3h.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnYTO3h.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnYTO3h, "btnYTO3h");
			this.btnYTO3h.Name = "btnYTO3h";
			this.btnYTO3h.UseVisualStyleBackColor = false;
			this.btnYTO3h.Click += new global::System.EventHandler(this.btnYTO3h_Click);
			this.btnYTO1h.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnYTO1h.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnYTO1h, "btnYTO1h");
			this.btnYTO1h.Name = "btnYTO1h";
			this.btnYTO1h.UseVisualStyleBackColor = false;
			this.btnYTO1h.Click += new global::System.EventHandler(this.btnYTO1h_Click);
			this.btnDiCanTro.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnDiCanTro.ForeColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			componentResourceManager.ApplyResources(this.btnDiCanTro, "btnDiCanTro");
			this.btnDiCanTro.Name = "btnDiCanTro";
			this.btnDiCanTro.UseVisualStyleBackColor = false;
			this.btnDiCanTro.Click += new global::System.EventHandler(this.btnDiCanTro_Click);
			componentResourceManager.ApplyResources(this.cboxIsYTO, "cboxIsYTO");
			this.cboxIsYTO.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxIsYTO.ForeColor = global::System.Drawing.Color.OrangeRed;
			this.cboxIsYTO.Name = "cboxIsYTO";
			this.cboxIsYTO.UseVisualStyleBackColor = false;
			this.cboxIsYTO.CheckedChanged += new global::System.EventHandler(this.cboxIsYTO_CheckedChanged);
			this.btnYTOExtend.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			componentResourceManager.ApplyResources(this.btnYTOExtend, "btnYTOExtend");
			this.btnYTOExtend.ForeColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.btnYTOExtend.Name = "btnYTOExtend";
			this.btnYTOExtend.UseVisualStyleBackColor = false;
			this.btnYTOExtend.Click += new global::System.EventHandler(this.btnYTOExtend_Click);
			this.groupQ123.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.groupQ123.Controls.Add(this.cboQ12Xong);
			this.groupQ123.Controls.Add(this.label44);
			this.groupQ123.Controls.Add(this.cboxPTYeu);
			this.groupQ123.Controls.Add(this.cboxQ12AutoExtend);
			this.groupQ123.Controls.Add(this.btnQ12Mua3H);
			this.groupQ123.Controls.Add(this.btnQ12Mua1H);
			this.groupQ123.Controls.Add(this.lblQ123Timer);
			this.groupQ123.Controls.Add(this.numQ12Level);
			this.groupQ123.Controls.Add(this.cboxQ12Level);
			this.groupQ123.Controls.Add(this.label39);
			this.groupQ123.Controls.Add(this.cboxTuHuyNV);
			this.groupQ123.Controls.Add(this.label38);
			this.groupQ123.Controls.Add(this.numQ12ChoPT);
			this.groupQ123.Controls.Add(this.cboxHongQPT);
			this.groupQ123.Controls.Add(this.cboQ1Cau);
			this.groupQ123.Controls.Add(this.lblQ1Cau);
			this.groupQ123.Controls.Add(this.cboxIsQ2);
			this.groupQ123.Controls.Add(this.cboxIsQ1);
			this.groupQ123.Controls.Add(this.btnQ12GroupExpand);
			this.groupQ123.Controls.Add(this.cboxDiTheoPP);
			componentResourceManager.ApplyResources(this.groupQ123, "groupQ123");
			this.groupQ123.Name = "groupQ123";
			this.groupQ123.TabStop = false;
			this.cboQ12Xong.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboQ12Xong, "cboQ12Xong");
			this.cboQ12Xong.FormattingEnabled = true;
			this.cboQ12Xong.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboQ12Xong.Items"),
				componentResourceManager.GetString("cboQ12Xong.Items1"),
				componentResourceManager.GetString("cboQ12Xong.Items2"),
				componentResourceManager.GetString("cboQ12Xong.Items3")
			});
			this.cboQ12Xong.Name = "cboQ12Xong";
			this.cboQ12Xong.SelectedIndexChanged += new global::System.EventHandler(this.cboQ12Xong_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label44, "label44");
			this.label44.Name = "label44";
			componentResourceManager.ApplyResources(this.cboxPTYeu, "cboxPTYeu");
			this.cboxPTYeu.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxPTYeu.Name = "cboxPTYeu";
			this.cboxPTYeu.UseVisualStyleBackColor = false;
			this.cboxPTYeu.CheckedChanged += new global::System.EventHandler(this.cboxPTYeu_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxQ12AutoExtend, "cboxQ12AutoExtend");
			this.cboxQ12AutoExtend.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxQ12AutoExtend.Name = "cboxQ12AutoExtend";
			this.cboxQ12AutoExtend.UseVisualStyleBackColor = false;
			this.cboxQ12AutoExtend.CheckedChanged += new global::System.EventHandler(this.cboxQ12AutoExtend_CheckedChanged);
			this.btnQ12Mua3H.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnQ12Mua3H.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnQ12Mua3H, "btnQ12Mua3H");
			this.btnQ12Mua3H.Name = "btnQ12Mua3H";
			this.btnQ12Mua3H.UseVisualStyleBackColor = false;
			this.btnQ12Mua3H.Click += new global::System.EventHandler(this.btnQ12Mua3H_Click);
			this.btnQ12Mua1H.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnQ12Mua1H.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnQ12Mua1H, "btnQ12Mua1H");
			this.btnQ12Mua1H.Name = "btnQ12Mua1H";
			this.btnQ12Mua1H.UseVisualStyleBackColor = false;
			this.btnQ12Mua1H.Click += new global::System.EventHandler(this.btnQ12Mua1H_Click);
			componentResourceManager.ApplyResources(this.lblQ123Timer, "lblQ123Timer");
			this.lblQ123Timer.Name = "lblQ123Timer";
			this.lblQ123Timer.Click += new global::System.EventHandler(this.lblQ123Timer_Click);
			this.numQ12Level.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numQ12Level, "numQ12Level");
			global::System.Windows.Forms.NumericUpDown numericUpDown54 = this.numQ12Level;
			int[] array54 = new int[4];
			array54[0] = 999;
			numericUpDown54.Maximum = new decimal(array54);
			global::System.Windows.Forms.NumericUpDown numericUpDown55 = this.numQ12Level;
			int[] array55 = new int[4];
			array55[0] = 1;
			numericUpDown55.Minimum = new decimal(array55);
			this.numQ12Level.Name = "numQ12Level";
			global::System.Windows.Forms.NumericUpDown numericUpDown56 = this.numQ12Level;
			int[] array56 = new int[4];
			array56[0] = 120;
			numericUpDown56.Value = new decimal(array56);
			this.numQ12Level.ValueChanged += new global::System.EventHandler(this.numQ12Level_ValueChanged);
			this.numQ12Level.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numQ12Level_KeyPress);
			componentResourceManager.ApplyResources(this.cboxQ12Level, "cboxQ12Level");
			this.cboxQ12Level.Name = "cboxQ12Level";
			this.cboxQ12Level.UseVisualStyleBackColor = true;
			this.cboxQ12Level.CheckedChanged += new global::System.EventHandler(this.cboxQ12Level_CheckedChanged);
			componentResourceManager.ApplyResources(this.label39, "label39");
			this.label39.Name = "label39";
			componentResourceManager.ApplyResources(this.cboxTuHuyNV, "cboxTuHuyNV");
			this.cboxTuHuyNV.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxTuHuyNV.Name = "cboxTuHuyNV";
			this.cboxTuHuyNV.UseVisualStyleBackColor = false;
			this.cboxTuHuyNV.CheckedChanged += new global::System.EventHandler(this.cboxTuHuyNV_CheckedChanged);
			componentResourceManager.ApplyResources(this.label38, "label38");
			this.label38.Name = "label38";
			this.numQ12ChoPT.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numQ12ChoPT, "numQ12ChoPT");
			global::System.Windows.Forms.NumericUpDown numericUpDown57 = this.numQ12ChoPT;
			int[] array57 = new int[4];
			array57[0] = 6;
			numericUpDown57.Maximum = new decimal(array57);
			global::System.Windows.Forms.NumericUpDown numericUpDown58 = this.numQ12ChoPT;
			int[] array58 = new int[4];
			array58[0] = 3;
			numericUpDown58.Minimum = new decimal(array58);
			this.numQ12ChoPT.Name = "numQ12ChoPT";
			global::System.Windows.Forms.NumericUpDown numericUpDown59 = this.numQ12ChoPT;
			int[] array59 = new int[4];
			array59[0] = 6;
			numericUpDown59.Value = new decimal(array59);
			this.numQ12ChoPT.ValueChanged += new global::System.EventHandler(this.numQ12ChoPT_ValueChanged);
			this.numQ12ChoPT.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numQ12ChoPT_KeyPress);
			componentResourceManager.ApplyResources(this.cboxHongQPT, "cboxHongQPT");
			this.cboxHongQPT.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxHongQPT.Name = "cboxHongQPT";
			this.cboxHongQPT.UseVisualStyleBackColor = false;
			this.cboxHongQPT.CheckedChanged += new global::System.EventHandler(this.cboxHongQPT_CheckedChanged);
			this.cboQ1Cau.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboQ1Cau, "cboQ1Cau");
			this.cboQ1Cau.FormattingEnabled = true;
			this.cboQ1Cau.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboQ1Cau.Items"),
				componentResourceManager.GetString("cboQ1Cau.Items1")
			});
			this.cboQ1Cau.Name = "cboQ1Cau";
			this.cboQ1Cau.SelectedIndexChanged += new global::System.EventHandler(this.cboQ1Cau_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.lblQ1Cau, "lblQ1Cau");
			this.lblQ1Cau.Name = "lblQ1Cau";
			componentResourceManager.ApplyResources(this.cboxIsQ2, "cboxIsQ2");
			this.cboxIsQ2.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxIsQ2.ForeColor = global::System.Drawing.Color.OrangeRed;
			this.cboxIsQ2.Name = "cboxIsQ2";
			this.cboxIsQ2.UseVisualStyleBackColor = false;
			this.cboxIsQ2.CheckedChanged += new global::System.EventHandler(this.cboxIsQ2_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsQ1, "cboxIsQ1");
			this.cboxIsQ1.ForeColor = global::System.Drawing.Color.OrangeRed;
			this.cboxIsQ1.Name = "cboxIsQ1";
			this.cboxIsQ1.UseVisualStyleBackColor = true;
			this.cboxIsQ1.CheckedChanged += new global::System.EventHandler(this.cboxIsQ1_CheckedChanged);
			this.btnQ12GroupExpand.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			componentResourceManager.ApplyResources(this.btnQ12GroupExpand, "btnQ12GroupExpand");
			this.btnQ12GroupExpand.ForeColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.btnQ12GroupExpand.Name = "btnQ12GroupExpand";
			this.btnQ12GroupExpand.UseVisualStyleBackColor = false;
			this.btnQ12GroupExpand.Click += new global::System.EventHandler(this.btnQ12GroupExpand_Click);
			componentResourceManager.ApplyResources(this.cboxDiTheoPP, "cboxDiTheoPP");
			this.cboxDiTheoPP.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.cboxDiTheoPP.Name = "cboxDiTheoPP";
			this.cboxDiTheoPP.UseVisualStyleBackColor = false;
			this.cboxDiTheoPP.CheckedChanged += new global::System.EventHandler(this.cboxDiTheoPP_CheckedChanged);
			this.groupBaoRuong.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.groupBaoRuong.Controls.Add(this.cboxLLTBNhanh);
			this.groupBaoRuong.Controls.Add(this.cboxLLTB);
			this.groupBaoRuong.Controls.Add(this.cboxPMP);
			this.groupBaoRuong.Controls.Add(this.cboxBRTLC);
			this.groupBaoRuong.Controls.Add(this.cboxBRXaPhu);
			this.groupBaoRuong.Controls.Add(this.cboBaoRuongMap);
			this.groupBaoRuong.Controls.Add(this.label34);
			this.groupBaoRuong.Controls.Add(this.cboxNhanHop);
			this.groupBaoRuong.Controls.Add(this.cboxNhatHop);
			this.groupBaoRuong.Controls.Add(this.cboxIsDoatBaoRuong);
			this.groupBaoRuong.Controls.Add(this.btnBaoRuongExpand);
			componentResourceManager.ApplyResources(this.groupBaoRuong, "groupBaoRuong");
			this.groupBaoRuong.Name = "groupBaoRuong";
			this.groupBaoRuong.TabStop = false;
			this.groupBaoRuong.Enter += new global::System.EventHandler(this.groupBaoRuong_Enter);
			componentResourceManager.ApplyResources(this.cboxLLTBNhanh, "cboxLLTBNhanh");
			this.cboxLLTBNhanh.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxLLTBNhanh.Name = "cboxLLTBNhanh";
			this.cboxLLTBNhanh.UseVisualStyleBackColor = false;
			this.cboxLLTBNhanh.CheckedChanged += new global::System.EventHandler(this.cboxLLTBNhanh_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxLLTB, "cboxLLTB");
			this.cboxLLTB.Name = "cboxLLTB";
			this.cboxLLTB.UseVisualStyleBackColor = true;
			this.cboxLLTB.CheckedChanged += new global::System.EventHandler(this.cboxLLTB_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxPMP, "cboxPMP");
			this.cboxPMP.Name = "cboxPMP";
			this.cboxPMP.UseVisualStyleBackColor = true;
			this.cboxPMP.CheckedChanged += new global::System.EventHandler(this.cboxPMP_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBRTLC, "cboxBRTLC");
			this.cboxBRTLC.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBRTLC.Name = "cboxBRTLC";
			this.cboxBRTLC.UseVisualStyleBackColor = false;
			this.cboxBRTLC.CheckedChanged += new global::System.EventHandler(this.cboxBRTLC_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBRXaPhu, "cboxBRXaPhu");
			this.cboxBRXaPhu.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxBRXaPhu.Name = "cboxBRXaPhu";
			this.cboxBRXaPhu.UseVisualStyleBackColor = false;
			this.cboxBRXaPhu.CheckedChanged += new global::System.EventHandler(this.cboxBRXaPhu_CheckedChanged);
			this.cboBaoRuongMap.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboBaoRuongMap, "cboBaoRuongMap");
			this.cboBaoRuongMap.FormattingEnabled = true;
			this.cboBaoRuongMap.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboBaoRuongMap.Items"),
				componentResourceManager.GetString("cboBaoRuongMap.Items1"),
				componentResourceManager.GetString("cboBaoRuongMap.Items2"),
				componentResourceManager.GetString("cboBaoRuongMap.Items3"),
				componentResourceManager.GetString("cboBaoRuongMap.Items4")
			});
			this.cboBaoRuongMap.Name = "cboBaoRuongMap";
			this.cboBaoRuongMap.SelectedIndexChanged += new global::System.EventHandler(this.cboBaoRuongMap_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label34, "label34");
			this.label34.Name = "label34";
			componentResourceManager.ApplyResources(this.cboxNhanHop, "cboxNhanHop");
			this.cboxNhanHop.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxNhanHop.Name = "cboxNhanHop";
			this.cboxNhanHop.UseVisualStyleBackColor = false;
			this.cboxNhanHop.CheckedChanged += new global::System.EventHandler(this.cboxNhanHop_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxNhatHop, "cboxNhatHop");
			this.cboxNhatHop.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxNhatHop.Name = "cboxNhatHop";
			this.cboxNhatHop.UseVisualStyleBackColor = false;
			this.cboxNhatHop.CheckedChanged += new global::System.EventHandler(this.cboxNhatHop_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsDoatBaoRuong, "cboxIsDoatBaoRuong");
			this.cboxIsDoatBaoRuong.Name = "cboxIsDoatBaoRuong";
			this.cboxIsDoatBaoRuong.UseVisualStyleBackColor = true;
			this.cboxIsDoatBaoRuong.CheckedChanged += new global::System.EventHandler(this.cboxIsDoatBaoRuong_CheckedChanged);
			this.btnBaoRuongExpand.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			componentResourceManager.ApplyResources(this.btnBaoRuongExpand, "btnBaoRuongExpand");
			this.btnBaoRuongExpand.ForeColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.btnBaoRuongExpand.Name = "btnBaoRuongExpand";
			this.btnBaoRuongExpand.UseVisualStyleBackColor = false;
			this.btnBaoRuongExpand.Click += new global::System.EventHandler(this.btnBaoRuongExpand_Click);
			this.groupQSM.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.groupQSM.Controls.Add(this.label64);
			this.groupQSM.Controls.Add(this.numQSMMax);
			this.groupQSM.Controls.Add(this.cboxDongMon);
			this.groupQSM.Controls.Add(this.btnQSMDiVe);
			this.groupQSM.Controls.Add(this.cboxCauNguyen);
			this.groupQSM.Controls.Add(this.cboxCauPhuc);
			this.groupQSM.Controls.Add(this.cboxIsQSM);
			this.groupQSM.Controls.Add(this.btnPHLMExpand);
			componentResourceManager.ApplyResources(this.groupQSM, "groupQSM");
			this.groupQSM.Name = "groupQSM";
			this.groupQSM.TabStop = false;
			componentResourceManager.ApplyResources(this.label64, "label64");
			this.label64.Name = "label64";
			this.numQSMMax.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numQSMMax, "numQSMMax");
			global::System.Windows.Forms.NumericUpDown numericUpDown60 = this.numQSMMax;
			int[] array60 = new int[4];
			array60[0] = 200;
			numericUpDown60.Maximum = new decimal(array60);
			global::System.Windows.Forms.NumericUpDown numericUpDown61 = this.numQSMMax;
			int[] array61 = new int[4];
			array61[0] = 1;
			numericUpDown61.Minimum = new decimal(array61);
			this.numQSMMax.Name = "numQSMMax";
			global::System.Windows.Forms.NumericUpDown numericUpDown62 = this.numQSMMax;
			int[] array62 = new int[4];
			array62[0] = 1;
			numericUpDown62.Value = new decimal(array62);
			this.numQSMMax.ValueChanged += new global::System.EventHandler(this.numQSMMax_ValueChanged);
			this.numQSMMax.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numQSMMax_KeyPress);
			componentResourceManager.ApplyResources(this.cboxDongMon, "cboxDongMon");
			this.cboxDongMon.Name = "cboxDongMon";
			this.cboxDongMon.UseVisualStyleBackColor = true;
			this.cboxDongMon.CheckedChanged += new global::System.EventHandler(this.cboxDongMon_CheckedChanged);
			this.btnQSMDiVe.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnQSMDiVe.ForeColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			componentResourceManager.ApplyResources(this.btnQSMDiVe, "btnQSMDiVe");
			this.btnQSMDiVe.Name = "btnQSMDiVe";
			this.btnQSMDiVe.UseVisualStyleBackColor = false;
			this.btnQSMDiVe.Click += new global::System.EventHandler(this.btnQSMDiVe_Click);
			componentResourceManager.ApplyResources(this.cboxCauNguyen, "cboxCauNguyen");
			this.cboxCauNguyen.Name = "cboxCauNguyen";
			this.cboxCauNguyen.UseVisualStyleBackColor = true;
			this.cboxCauNguyen.CheckedChanged += new global::System.EventHandler(this.cboxCauNguyen_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxCauPhuc, "cboxCauPhuc");
			this.cboxCauPhuc.Name = "cboxCauPhuc";
			this.cboxCauPhuc.UseVisualStyleBackColor = true;
			this.cboxCauPhuc.CheckedChanged += new global::System.EventHandler(this.cboxCauPhuc_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsQSM, "cboxIsQSM");
			this.cboxIsQSM.Name = "cboxIsQSM";
			this.cboxIsQSM.UseVisualStyleBackColor = true;
			this.cboxIsQSM.CheckedChanged += new global::System.EventHandler(this.cboxIsQSM_CheckedChanged);
			this.btnPHLMExpand.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			componentResourceManager.ApplyResources(this.btnPHLMExpand, "btnPHLMExpand");
			this.btnPHLMExpand.ForeColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.btnPHLMExpand.Name = "btnPHLMExpand";
			this.btnPHLMExpand.UseVisualStyleBackColor = false;
			this.btnPHLMExpand.Click += new global::System.EventHandler(this.btnPHLMExpand_Click);
			this.groupTKC.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.groupTKC.Controls.Add(this.cboxKyCuocNhanh);
			this.groupTKC.Controls.Add(this.label33);
			this.groupTKC.Controls.Add(this.RightY);
			this.groupTKC.Controls.Add(this.RightX);
			this.groupTKC.Controls.Add(this.label31);
			this.groupTKC.Controls.Add(this.leftY);
			this.groupTKC.Controls.Add(this.leftX);
			this.groupTKC.Controls.Add(this.cboxKyCuoc);
			this.groupTKC.Controls.Add(this.cboxIsTKC);
			this.groupTKC.Controls.Add(this.cboxIsPHLM);
			this.groupTKC.Controls.Add(this.cboxTKCNhanh);
			this.groupTKC.Controls.Add(this.cboTKCMaps);
			this.groupTKC.Controls.Add(this.btnTKCEx);
			this.groupTKC.Controls.Add(this.label17);
			componentResourceManager.ApplyResources(this.groupTKC, "groupTKC");
			this.groupTKC.Name = "groupTKC";
			this.groupTKC.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxKyCuocNhanh, "cboxKyCuocNhanh");
			this.cboxKyCuocNhanh.Name = "cboxKyCuocNhanh";
			this.cboxKyCuocNhanh.UseVisualStyleBackColor = true;
			this.cboxKyCuocNhanh.CheckedChanged += new global::System.EventHandler(this.cboxKyCuocNhanh_CheckedChanged);
			componentResourceManager.ApplyResources(this.label33, "label33");
			this.label33.Name = "label33";
			this.RightY.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.RightY.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.RightY, "RightY");
			this.RightY.Name = "RightY";
			this.RightY.TextChanged += new global::System.EventHandler(this.RightY_TextChanged);
			this.RightX.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.RightX.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.RightX, "RightX");
			this.RightX.Name = "RightX";
			this.RightX.TextChanged += new global::System.EventHandler(this.RightX_TextChanged);
			componentResourceManager.ApplyResources(this.label31, "label31");
			this.label31.Name = "label31";
			this.leftY.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.leftY.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.leftY, "leftY");
			this.leftY.Name = "leftY";
			this.leftY.TextChanged += new global::System.EventHandler(this.leftY_TextChanged);
			this.leftY.Enter += new global::System.EventHandler(this.leftY_Enter);
			this.leftX.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.leftX.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.leftX, "leftX");
			this.leftX.Name = "leftX";
			this.leftX.TextChanged += new global::System.EventHandler(this.leftX_TextChanged);
			componentResourceManager.ApplyResources(this.cboxKyCuoc, "cboxKyCuoc");
			this.cboxKyCuoc.Name = "cboxKyCuoc";
			this.cboxKyCuoc.UseVisualStyleBackColor = true;
			this.cboxKyCuoc.CheckedChanged += new global::System.EventHandler(this.cboxKyCuoc_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsTKC, "cboxIsTKC");
			this.cboxIsTKC.Name = "cboxIsTKC";
			this.cboxIsTKC.UseVisualStyleBackColor = true;
			this.cboxIsTKC.CheckedChanged += new global::System.EventHandler(this.cboxIsTKC_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsPHLM, "cboxIsPHLM");
			this.cboxIsPHLM.Name = "cboxIsPHLM";
			this.cboxIsPHLM.UseVisualStyleBackColor = true;
			this.cboxIsPHLM.CheckedChanged += new global::System.EventHandler(this.cboxIsPHLM_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTKCNhanh, "cboxTKCNhanh");
			this.cboxTKCNhanh.Name = "cboxTKCNhanh";
			this.cboxTKCNhanh.UseVisualStyleBackColor = true;
			this.cboxTKCNhanh.CheckedChanged += new global::System.EventHandler(this.cboxTKCNhanh_CheckedChanged);
			this.cboTKCMaps.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboTKCMaps, "cboTKCMaps");
			this.cboTKCMaps.FormattingEnabled = true;
			this.cboTKCMaps.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboTKCMaps.Items"),
				componentResourceManager.GetString("cboTKCMaps.Items1"),
				componentResourceManager.GetString("cboTKCMaps.Items2"),
				componentResourceManager.GetString("cboTKCMaps.Items3")
			});
			this.cboTKCMaps.Name = "cboTKCMaps";
			this.cboTKCMaps.SelectedIndexChanged += new global::System.EventHandler(this.cboTKCMaps_SelectedIndexChanged);
			this.btnTKCEx.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			componentResourceManager.ApplyResources(this.btnTKCEx, "btnTKCEx");
			this.btnTKCEx.ForeColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.btnTKCEx.Name = "btnTKCEx";
			this.btnTKCEx.UseVisualStyleBackColor = false;
			this.btnTKCEx.Click += new global::System.EventHandler(this.btnTKCEx_Click);
			componentResourceManager.ApplyResources(this.label17, "label17");
			this.label17.Name = "label17";
			this.groupTBB.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.groupTBB.Controls.Add(this.cboxHuyNVNhatDo);
			this.groupTBB.Controls.Add(this.cboxThuHoachHoaChinhMinh);
			this.groupTBB.Controls.Add(this.cboxBHDThoatKhiXong);
			this.groupTBB.Controls.Add(this.cboxHuyNVDanhQuai);
			this.groupTBB.Controls.Add(this.numsoHangTrongHoa);
			this.groupTBB.Controls.Add(this.label56);
			this.groupTBB.Controls.Add(this.numBHDBanKinh);
			this.groupTBB.Controls.Add(this.cboxThuHoach);
			this.groupTBB.Controls.Add(this.cboxBonHoa);
			this.groupTBB.Controls.Add(this.cboxTrongHoa);
			this.groupTBB.Controls.Add(this.numBHDMax);
			this.groupTBB.Controls.Add(this.cboxIsBachHoaDuyen);
			this.groupTBB.Controls.Add(this.cboxIsTuDuongCon);
			this.groupTBB.Controls.Add(this.label24);
			this.groupTBB.Controls.Add(this.cboTuDuongCon);
			this.groupTBB.Controls.Add(this.btnTBBExpand);
			this.groupTBB.Controls.Add(this.btnBHDVe);
			componentResourceManager.ApplyResources(this.groupTBB, "groupTBB");
			this.groupTBB.Name = "groupTBB";
			this.groupTBB.TabStop = false;
			this.groupTBB.Enter += new global::System.EventHandler(this.groupTBB_Enter);
			componentResourceManager.ApplyResources(this.cboxHuyNVNhatDo, "cboxHuyNVNhatDo");
			this.cboxHuyNVNhatDo.ForeColor = global::System.Drawing.Color.Black;
			this.cboxHuyNVNhatDo.Name = "cboxHuyNVNhatDo";
			this.cboxHuyNVNhatDo.UseVisualStyleBackColor = true;
			this.cboxHuyNVNhatDo.CheckedChanged += new global::System.EventHandler(this.cboxHuyNVNhatDo_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxThuHoachHoaChinhMinh, "cboxThuHoachHoaChinhMinh");
			this.cboxThuHoachHoaChinhMinh.ForeColor = global::System.Drawing.Color.Black;
			this.cboxThuHoachHoaChinhMinh.Name = "cboxThuHoachHoaChinhMinh";
			this.cboxThuHoachHoaChinhMinh.UseVisualStyleBackColor = true;
			this.cboxThuHoachHoaChinhMinh.CheckedChanged += new global::System.EventHandler(this.cboxThuHoachHoaChinhMinh_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBHDThoatKhiXong, "cboxBHDThoatKhiXong");
			this.cboxBHDThoatKhiXong.ForeColor = global::System.Drawing.Color.Black;
			this.cboxBHDThoatKhiXong.Name = "cboxBHDThoatKhiXong";
			this.cboxBHDThoatKhiXong.UseVisualStyleBackColor = true;
			this.cboxBHDThoatKhiXong.CheckedChanged += new global::System.EventHandler(this.cboxBHDThoatKhiXong_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxHuyNVDanhQuai, "cboxHuyNVDanhQuai");
			this.cboxHuyNVDanhQuai.ForeColor = global::System.Drawing.Color.Black;
			this.cboxHuyNVDanhQuai.Name = "cboxHuyNVDanhQuai";
			this.cboxHuyNVDanhQuai.UseVisualStyleBackColor = true;
			this.cboxHuyNVDanhQuai.CheckedChanged += new global::System.EventHandler(this.cboxHuyNVDanhQuai_CheckedChanged);
			this.numsoHangTrongHoa.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numsoHangTrongHoa, "numsoHangTrongHoa");
			global::System.Windows.Forms.NumericUpDown numericUpDown63 = this.numsoHangTrongHoa;
			int[] array63 = new int[4];
			array63[0] = 10;
			numericUpDown63.Maximum = new decimal(array63);
			global::System.Windows.Forms.NumericUpDown numericUpDown64 = this.numsoHangTrongHoa;
			int[] array64 = new int[4];
			array64[0] = 2;
			numericUpDown64.Minimum = new decimal(array64);
			this.numsoHangTrongHoa.Name = "numsoHangTrongHoa";
			global::System.Windows.Forms.NumericUpDown numericUpDown65 = this.numsoHangTrongHoa;
			int[] array65 = new int[4];
			array65[0] = 4;
			numericUpDown65.Value = new decimal(array65);
			this.numsoHangTrongHoa.ValueChanged += new global::System.EventHandler(this.numsoHangTrongHoa_ValueChanged);
			this.numsoHangTrongHoa.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numsoHangTrongHoa_KeyPress);
			componentResourceManager.ApplyResources(this.label56, "label56");
			this.label56.Name = "label56";
			this.numBHDBanKinh.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown66 = this.numBHDBanKinh;
			int[] array66 = new int[4];
			array66[0] = 5;
			numericUpDown66.Increment = new decimal(array66);
			componentResourceManager.ApplyResources(this.numBHDBanKinh, "numBHDBanKinh");
			this.numBHDBanKinh.Name = "numBHDBanKinh";
			this.numBHDBanKinh.ValueChanged += new global::System.EventHandler(this.numBHDBanKinh_ValueChanged);
			componentResourceManager.ApplyResources(this.cboxThuHoach, "cboxThuHoach");
			this.cboxThuHoach.ForeColor = global::System.Drawing.Color.Black;
			this.cboxThuHoach.Name = "cboxThuHoach";
			this.cboxThuHoach.UseVisualStyleBackColor = true;
			this.cboxThuHoach.CheckedChanged += new global::System.EventHandler(this.cboxThuHoach_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBonHoa, "cboxBonHoa");
			this.cboxBonHoa.ForeColor = global::System.Drawing.Color.Black;
			this.cboxBonHoa.Name = "cboxBonHoa";
			this.cboxBonHoa.UseVisualStyleBackColor = true;
			this.cboxBonHoa.CheckedChanged += new global::System.EventHandler(this.cboxBonHoa_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTrongHoa, "cboxTrongHoa");
			this.cboxTrongHoa.ForeColor = global::System.Drawing.Color.Black;
			this.cboxTrongHoa.Name = "cboxTrongHoa";
			this.cboxTrongHoa.UseVisualStyleBackColor = true;
			this.cboxTrongHoa.CheckedChanged += new global::System.EventHandler(this.cboxTrongHoa_CheckedChanged);
			this.numBHDMax.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numBHDMax, "numBHDMax");
			global::System.Windows.Forms.NumericUpDown numericUpDown67 = this.numBHDMax;
			int[] array67 = new int[4];
			array67[0] = 200;
			numericUpDown67.Maximum = new decimal(array67);
			this.numBHDMax.Name = "numBHDMax";
			global::System.Windows.Forms.NumericUpDown numericUpDown68 = this.numBHDMax;
			int[] array68 = new int[4];
			array68[0] = 1;
			numericUpDown68.Value = new decimal(array68);
			this.numBHDMax.ValueChanged += new global::System.EventHandler(this.numBHDMax_ValueChanged);
			this.numBHDMax.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numBHDMax_KeyPress);
			componentResourceManager.ApplyResources(this.cboxIsBachHoaDuyen, "cboxIsBachHoaDuyen");
			this.cboxIsBachHoaDuyen.Name = "cboxIsBachHoaDuyen";
			this.cboxIsBachHoaDuyen.UseVisualStyleBackColor = true;
			this.cboxIsBachHoaDuyen.CheckedChanged += new global::System.EventHandler(this.cboxIsBachHoaDuyen_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsTuDuongCon, "cboxIsTuDuongCon");
			this.cboxIsTuDuongCon.Name = "cboxIsTuDuongCon";
			this.cboxIsTuDuongCon.UseVisualStyleBackColor = true;
			this.cboxIsTuDuongCon.CheckedChanged += new global::System.EventHandler(this.cboxIsTuDuongCon_CheckedChanged);
			componentResourceManager.ApplyResources(this.label24, "label24");
			this.label24.Name = "label24";
			this.cboTuDuongCon.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboTuDuongCon, "cboTuDuongCon");
			this.cboTuDuongCon.FormattingEnabled = true;
			this.cboTuDuongCon.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboTuDuongCon.Items"),
				componentResourceManager.GetString("cboTuDuongCon.Items1"),
				componentResourceManager.GetString("cboTuDuongCon.Items2"),
				componentResourceManager.GetString("cboTuDuongCon.Items3"),
				componentResourceManager.GetString("cboTuDuongCon.Items4")
			});
			this.cboTuDuongCon.Name = "cboTuDuongCon";
			this.cboTuDuongCon.SelectedIndexChanged += new global::System.EventHandler(this.cboTuDuongCon_SelectedIndexChanged);
			this.btnTBBExpand.BackColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			componentResourceManager.ApplyResources(this.btnTBBExpand, "btnTBBExpand");
			this.btnTBBExpand.ForeColor = global::System.Drawing.Color.FromArgb(175, 175, 175);
			this.btnTBBExpand.Name = "btnTBBExpand";
			this.btnTBBExpand.UseVisualStyleBackColor = false;
			this.btnTBBExpand.Click += new global::System.EventHandler(this.btnTBBExpand_Click);
			this.btnBHDVe.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnBHDVe.ForeColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			componentResourceManager.ApplyResources(this.btnBHDVe, "btnBHDVe");
			this.btnBHDVe.Name = "btnBHDVe";
			this.btnBHDVe.UseVisualStyleBackColor = false;
			this.btnBHDVe.Click += new global::System.EventHandler(this.btnBHDVe_Click);
			this.groupMuaKNB.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.groupMuaKNB.Controls.Add(this.btnMuaKNBExpand);
			this.groupMuaKNB.Controls.Add(this.label10);
			this.groupMuaKNB.Controls.Add(this.label73);
			this.groupMuaKNB.Controls.Add(this.txtKNB500);
			this.groupMuaKNB.Controls.Add(this.label74);
			this.groupMuaKNB.Controls.Add(this.label71);
			this.groupMuaKNB.Controls.Add(this.txtKNB200);
			this.groupMuaKNB.Controls.Add(this.label72);
			this.groupMuaKNB.Controls.Add(this.label70);
			this.groupMuaKNB.Controls.Add(this.txtKNB50);
			this.groupMuaKNB.Controls.Add(this.label68);
			this.groupMuaKNB.Controls.Add(this.btnMuaKNB);
			componentResourceManager.ApplyResources(this.groupMuaKNB, "groupMuaKNB");
			this.groupMuaKNB.Name = "groupMuaKNB";
			this.groupMuaKNB.TabStop = false;
			this.btnMuaKNBExpand.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			componentResourceManager.ApplyResources(this.btnMuaKNBExpand, "btnMuaKNBExpand");
			this.btnMuaKNBExpand.ForeColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnMuaKNBExpand.Name = "btnMuaKNBExpand";
			this.btnMuaKNBExpand.UseVisualStyleBackColor = false;
			this.btnMuaKNBExpand.Click += new global::System.EventHandler(this.btnMuaKNBExpand_Click);
			componentResourceManager.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			componentResourceManager.ApplyResources(this.label73, "label73");
			this.label73.Name = "label73";
			this.txtKNB500.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtKNB500.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtKNB500, "txtKNB500");
			this.txtKNB500.Name = "txtKNB500";
			this.txtKNB500.TextChanged += new global::System.EventHandler(this.txtKNB500_TextChanged);
			componentResourceManager.ApplyResources(this.label74, "label74");
			this.label74.Name = "label74";
			componentResourceManager.ApplyResources(this.label71, "label71");
			this.label71.Name = "label71";
			this.txtKNB200.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtKNB200.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtKNB200, "txtKNB200");
			this.txtKNB200.Name = "txtKNB200";
			this.txtKNB200.TextChanged += new global::System.EventHandler(this.txtKNB200_TextChanged);
			componentResourceManager.ApplyResources(this.label72, "label72");
			this.label72.Name = "label72";
			componentResourceManager.ApplyResources(this.label70, "label70");
			this.label70.Name = "label70";
			this.txtKNB50.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtKNB50.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtKNB50, "txtKNB50");
			this.txtKNB50.Name = "txtKNB50";
			this.txtKNB50.TextChanged += new global::System.EventHandler(this.txtKNB50_TextChanged);
			componentResourceManager.ApplyResources(this.label68, "label68");
			this.label68.Name = "label68";
			componentResourceManager.ApplyResources(this.btnMuaKNB, "btnMuaKNB");
			this.btnMuaKNB.BackColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnMuaKNB.ForeColor = global::System.Drawing.Color.FromArgb(185, 185, 185);
			this.btnMuaKNB.Name = "btnMuaKNB";
			this.btnMuaKNB.UseVisualStyleBackColor = false;
			this.btnMuaKNB.Click += new global::System.EventHandler(this.btnMuaKNB_Click);
			this.groupLuyenKim.BackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.groupLuyenKim.Controls.Add(this.cboxIsTBB);
			this.groupLuyenKim.Controls.Add(this.cboxTBBchaynhanh);
			this.groupLuyenKim.Controls.Add(this.cboxIsXayDung);
			this.groupLuyenKim.Controls.Add(this.cboTuBaoBon);
			this.groupLuyenKim.Controls.Add(this.cboxLuyenKim);
			this.groupLuyenKim.Controls.Add(this.cboxXDXaPhu);
			this.groupLuyenKim.Controls.Add(this.cboxTBBPhiThuy);
			this.groupLuyenKim.Controls.Add(this.cboxXayDungPhu);
			this.groupLuyenKim.Controls.Add(this.lblTBBCounter);
			this.groupLuyenKim.Controls.Add(this.btnLKExpand);
			this.groupLuyenKim.Controls.Add(this.cboxXDHoiMau);
			this.groupLuyenKim.Controls.Add(this.cboxLuyenKimCham);
			this.groupLuyenKim.Controls.Add(this.cboxLKTuNhanNV);
			componentResourceManager.ApplyResources(this.groupLuyenKim, "groupLuyenKim");
			this.groupLuyenKim.Name = "groupLuyenKim";
			this.groupLuyenKim.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxIsTBB, "cboxIsTBB");
			this.cboxIsTBB.Name = "cboxIsTBB";
			this.cboxIsTBB.UseVisualStyleBackColor = true;
			this.cboxIsTBB.CheckedChanged += new global::System.EventHandler(this.cboxIsTBB_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTBBchaynhanh, "cboxTBBchaynhanh");
			this.cboxTBBchaynhanh.Name = "cboxTBBchaynhanh";
			this.cboxTBBchaynhanh.UseVisualStyleBackColor = true;
			this.cboxTBBchaynhanh.CheckedChanged += new global::System.EventHandler(this.cboxTBBchaynhanh_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsXayDung, "cboxIsXayDung");
			this.cboxIsXayDung.Name = "cboxIsXayDung";
			this.cboxIsXayDung.UseVisualStyleBackColor = true;
			this.cboxIsXayDung.CheckedChanged += new global::System.EventHandler(this.cboxIsXayDung_CheckedChanged);
			this.cboTuBaoBon.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboTuBaoBon, "cboTuBaoBon");
			this.cboTuBaoBon.FormattingEnabled = true;
			this.cboTuBaoBon.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboTuBaoBon.Items"),
				componentResourceManager.GetString("cboTuBaoBon.Items1"),
				componentResourceManager.GetString("cboTuBaoBon.Items2")
			});
			this.cboTuBaoBon.Name = "cboTuBaoBon";
			this.cboTuBaoBon.SelectedIndexChanged += new global::System.EventHandler(this.cboTuBaoBon_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboxLuyenKim, "cboxLuyenKim");
			this.cboxLuyenKim.Name = "cboxLuyenKim";
			this.cboxLuyenKim.UseVisualStyleBackColor = true;
			this.cboxLuyenKim.CheckedChanged += new global::System.EventHandler(this.cboxLuyenKim_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxXDXaPhu, "cboxXDXaPhu");
			this.cboxXDXaPhu.Name = "cboxXDXaPhu";
			this.cboxXDXaPhu.UseVisualStyleBackColor = true;
			this.cboxXDXaPhu.CheckedChanged += new global::System.EventHandler(this.cboxXDXaPhu_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTBBPhiThuy, "cboxTBBPhiThuy");
			this.cboxTBBPhiThuy.Name = "cboxTBBPhiThuy";
			this.cboxTBBPhiThuy.UseVisualStyleBackColor = true;
			this.cboxTBBPhiThuy.CheckedChanged += new global::System.EventHandler(this.cboxTBBPhiThuy_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxXayDungPhu, "cboxXayDungPhu");
			this.cboxXayDungPhu.Name = "cboxXayDungPhu";
			this.cboxXayDungPhu.UseVisualStyleBackColor = true;
			this.cboxXayDungPhu.CheckedChanged += new global::System.EventHandler(this.cboxXayDungPhu_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblTBBCounter, "lblTBBCounter");
			this.lblTBBCounter.Name = "lblTBBCounter";
			this.btnLKExpand.BackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			componentResourceManager.ApplyResources(this.btnLKExpand, "btnLKExpand");
			this.btnLKExpand.ForeColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.btnLKExpand.Name = "btnLKExpand";
			this.btnLKExpand.UseVisualStyleBackColor = false;
			this.btnLKExpand.Click += new global::System.EventHandler(this.btnLKExpand_Click);
			componentResourceManager.ApplyResources(this.cboxXDHoiMau, "cboxXDHoiMau");
			this.cboxXDHoiMau.Name = "cboxXDHoiMau";
			this.cboxXDHoiMau.UseVisualStyleBackColor = true;
			this.cboxXDHoiMau.CheckedChanged += new global::System.EventHandler(this.cboxXDHoiMau_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxLuyenKimCham, "cboxLuyenKimCham");
			this.cboxLuyenKimCham.Name = "cboxLuyenKimCham";
			this.cboxLuyenKimCham.UseVisualStyleBackColor = true;
			this.cboxLuyenKimCham.CheckedChanged += new global::System.EventHandler(this.cboxLuyenKimCham_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxLKTuNhanNV, "cboxLKTuNhanNV");
			this.cboxLKTuNhanNV.Name = "cboxLKTuNhanNV";
			this.cboxLKTuNhanNV.UseVisualStyleBackColor = true;
			this.cboxLKTuNhanNV.CheckedChanged += new global::System.EventHandler(this.cboxLKTuNhanNV_CheckedChanged);
			this.groupTrungAc.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.groupTrungAc.Controls.Add(this.btnTanThu);
			this.groupTrungAc.Controls.Add(this.cboxTanThu);
			this.groupTrungAc.Controls.Add(this.cboxIsTrungAc);
			this.groupTrungAc.Controls.Add(this.cboxBTDXaPhu);
			this.groupTrungAc.Controls.Add(this.cboxBTDPhuVe);
			this.groupTrungAc.Controls.Add(this.cboxIsBTD);
			this.groupTrungAc.Controls.Add(this.cboxTAXaPhu);
			this.groupTrungAc.Controls.Add(this.cboxTAPhuLD);
			this.groupTrungAc.Controls.Add(this.cboxTAPhuToChau);
			this.groupTrungAc.Controls.Add(this.btnTAExpand);
			this.groupTrungAc.Controls.Add(this.cboxTANhanNV);
			this.groupTrungAc.Controls.Add(this.cboxTAHoiPhuc);
			this.groupTrungAc.Controls.Add(this.cboxTAPhuDL);
			componentResourceManager.ApplyResources(this.groupTrungAc, "groupTrungAc");
			this.groupTrungAc.Name = "groupTrungAc";
			this.groupTrungAc.TabStop = false;
			this.groupTrungAc.Enter += new global::System.EventHandler(this.groupTrungAc_Enter);
			this.btnTanThu.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnTanThu, "btnTanThu");
			this.btnTanThu.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnTanThu.Image = global::ns0.Class212.setting;
			this.btnTanThu.Name = "btnTanThu";
			this.btnTanThu.UseVisualStyleBackColor = false;
			this.btnTanThu.Click += new global::System.EventHandler(this.btnTanThu_Click);
			componentResourceManager.ApplyResources(this.cboxTanThu, "cboxTanThu");
			this.cboxTanThu.Name = "cboxTanThu";
			this.cboxTanThu.UseVisualStyleBackColor = true;
			this.cboxTanThu.CheckedChanged += new global::System.EventHandler(this.cboxTanThu_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsTrungAc, "cboxIsTrungAc");
			this.cboxIsTrungAc.Name = "cboxIsTrungAc";
			this.cboxIsTrungAc.UseVisualStyleBackColor = true;
			this.cboxIsTrungAc.CheckedChanged += new global::System.EventHandler(this.cboxIsTrungAc_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBTDXaPhu, "cboxBTDXaPhu");
			this.cboxBTDXaPhu.Name = "cboxBTDXaPhu";
			this.cboxBTDXaPhu.UseVisualStyleBackColor = true;
			this.cboxBTDXaPhu.CheckedChanged += new global::System.EventHandler(this.cboxBTDXaPhu_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxBTDPhuVe, "cboxBTDPhuVe");
			this.cboxBTDPhuVe.Name = "cboxBTDPhuVe";
			this.cboxBTDPhuVe.UseVisualStyleBackColor = true;
			this.cboxBTDPhuVe.CheckedChanged += new global::System.EventHandler(this.cboxBTDPhuVe_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsBTD, "cboxIsBTD");
			this.cboxIsBTD.Name = "cboxIsBTD";
			this.cboxIsBTD.UseVisualStyleBackColor = true;
			this.cboxIsBTD.CheckedChanged += new global::System.EventHandler(this.cboxIsBTD_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTAXaPhu, "cboxTAXaPhu");
			this.cboxTAXaPhu.Name = "cboxTAXaPhu";
			this.cboxTAXaPhu.UseVisualStyleBackColor = true;
			this.cboxTAXaPhu.CheckedChanged += new global::System.EventHandler(this.cboxTAXaPhu_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTAPhuLD, "cboxTAPhuLD");
			this.cboxTAPhuLD.Name = "cboxTAPhuLD";
			this.cboxTAPhuLD.UseVisualStyleBackColor = true;
			this.cboxTAPhuLD.CheckedChanged += new global::System.EventHandler(this.cboxTAPhuLD_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTAPhuToChau, "cboxTAPhuToChau");
			this.cboxTAPhuToChau.Name = "cboxTAPhuToChau";
			this.cboxTAPhuToChau.UseVisualStyleBackColor = true;
			this.cboxTAPhuToChau.CheckedChanged += new global::System.EventHandler(this.cboxTAPhuToChau_CheckedChanged);
			this.btnTAExpand.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnTAExpand, "btnTAExpand");
			this.btnTAExpand.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnTAExpand.Name = "btnTAExpand";
			this.btnTAExpand.UseVisualStyleBackColor = false;
			this.btnTAExpand.Click += new global::System.EventHandler(this.btnTAExpand_Click);
			componentResourceManager.ApplyResources(this.cboxTANhanNV, "cboxTANhanNV");
			this.cboxTANhanNV.Name = "cboxTANhanNV";
			this.cboxTANhanNV.UseVisualStyleBackColor = true;
			this.cboxTANhanNV.CheckedChanged += new global::System.EventHandler(this.cboxTANhanNV_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTAHoiPhuc, "cboxTAHoiPhuc");
			this.cboxTAHoiPhuc.Name = "cboxTAHoiPhuc";
			this.cboxTAHoiPhuc.UseVisualStyleBackColor = true;
			this.cboxTAHoiPhuc.CheckedChanged += new global::System.EventHandler(this.cboxTAHoiPhuc_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTAPhuDL, "cboxTAPhuDL");
			this.cboxTAPhuDL.Name = "cboxTAPhuDL";
			this.cboxTAPhuDL.UseVisualStyleBackColor = true;
			this.cboxTAPhuDL.CheckedChanged += new global::System.EventHandler(this.cboxTAPhuDL_CheckedChanged);
			this.groupAcTac.BackColor = global::System.Drawing.Color.FromArgb(215, 215, 215);
			this.groupAcTac.Controls.Add(this.cboxATRunPP);
			this.groupAcTac.Controls.Add(this.cboxChoParty);
			this.groupAcTac.Controls.Add(this.cboxABChayTim);
			this.groupAcTac.Controls.Add(this.lblABPhai);
			this.groupAcTac.Controls.Add(this.cboxIsLinhThu);
			this.groupAcTac.Controls.Add(this.cboxIsAcBa);
			this.groupAcTac.Controls.Add(this.cboxIsAcTac);
			this.groupAcTac.Controls.Add(this.cboxLTNhanVN);
			this.groupAcTac.Controls.Add(this.btnATExpand);
			this.groupAcTac.Controls.Add(this.cboATMaps);
			this.groupAcTac.Controls.Add(this.label62);
			componentResourceManager.ApplyResources(this.groupAcTac, "groupAcTac");
			this.groupAcTac.Name = "groupAcTac";
			this.groupAcTac.TabStop = false;
			this.groupAcTac.Enter += new global::System.EventHandler(this.groupAcTac_Enter);
			componentResourceManager.ApplyResources(this.cboxATRunPP, "cboxATRunPP");
			this.cboxATRunPP.Name = "cboxATRunPP";
			this.cboxATRunPP.UseVisualStyleBackColor = true;
			this.cboxATRunPP.CheckedChanged += new global::System.EventHandler(this.cboxATRunPP_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxChoParty, "cboxChoParty");
			this.cboxChoParty.Name = "cboxChoParty";
			this.cboxChoParty.UseVisualStyleBackColor = true;
			this.cboxChoParty.CheckedChanged += new global::System.EventHandler(this.cboxChoParty_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxABChayTim, "cboxABChayTim");
			this.cboxABChayTim.Name = "cboxABChayTim";
			this.cboxABChayTim.UseVisualStyleBackColor = true;
			this.cboxABChayTim.CheckedChanged += new global::System.EventHandler(this.cboxABChayTim_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblABPhai, "lblABPhai");
			this.lblABPhai.Name = "lblABPhai";
			componentResourceManager.ApplyResources(this.cboxIsLinhThu, "cboxIsLinhThu");
			this.cboxIsLinhThu.Name = "cboxIsLinhThu";
			this.cboxIsLinhThu.UseVisualStyleBackColor = true;
			this.cboxIsLinhThu.CheckedChanged += new global::System.EventHandler(this.cboxIsLinhThu_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsAcBa, "cboxIsAcBa");
			this.cboxIsAcBa.Name = "cboxIsAcBa";
			this.cboxIsAcBa.UseVisualStyleBackColor = true;
			this.cboxIsAcBa.CheckedChanged += new global::System.EventHandler(this.cboxIsAcBa_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsAcTac, "cboxIsAcTac");
			this.cboxIsAcTac.Name = "cboxIsAcTac";
			this.cboxIsAcTac.UseVisualStyleBackColor = true;
			this.cboxIsAcTac.CheckedChanged += new global::System.EventHandler(this.cboxIsAcTac_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxLTNhanVN, "cboxLTNhanVN");
			this.cboxLTNhanVN.Name = "cboxLTNhanVN";
			this.cboxLTNhanVN.UseVisualStyleBackColor = true;
			this.cboxLTNhanVN.CheckedChanged += new global::System.EventHandler(this.cboxLTNhanVN_CheckedChanged);
			this.btnATExpand.BackColor = global::System.Drawing.Color.FromArgb(215, 215, 215);
			componentResourceManager.ApplyResources(this.btnATExpand, "btnATExpand");
			this.btnATExpand.ForeColor = global::System.Drawing.Color.FromArgb(215, 215, 215);
			this.btnATExpand.Name = "btnATExpand";
			this.btnATExpand.UseVisualStyleBackColor = false;
			this.btnATExpand.Click += new global::System.EventHandler(this.btnATExpand_Click);
			this.cboATMaps.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboATMaps, "cboATMaps");
			this.cboATMaps.FormattingEnabled = true;
			this.cboATMaps.Name = "cboATMaps";
			this.cboATMaps.SelectedIndexChanged += new global::System.EventHandler(this.cboATMaps_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label62, "label62");
			this.label62.Name = "label62";
			this.groupDuaHau.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.groupDuaHau.Controls.Add(this.label63);
			this.groupDuaHau.Controls.Add(this.cboxBuonDuaHau);
			this.groupDuaHau.Controls.Add(this.btnDuaHauExpand);
			this.groupDuaHau.Controls.Add(this.cboxDuaHauCity);
			this.groupDuaHau.Controls.Add(this.cboDHAutoPick);
			this.groupDuaHau.Controls.Add(this.cboDHAutoNV);
			this.groupDuaHau.Controls.Add(this.cboDHAlertTuu);
			this.groupDuaHau.Controls.Add(this.txtDHBangID);
			this.groupDuaHau.Controls.Add(this.label60);
			this.groupDuaHau.Controls.Add(this.btnDuaHauStart);
			this.groupDuaHau.Controls.Add(this.cboxDuaHauMaps);
			this.groupDuaHau.Controls.Add(this.label59);
			this.groupDuaHau.Controls.Add(this.cboDHFromCity);
			componentResourceManager.ApplyResources(this.groupDuaHau, "groupDuaHau");
			this.groupDuaHau.Name = "groupDuaHau";
			this.groupDuaHau.TabStop = false;
			this.groupDuaHau.Enter += new global::System.EventHandler(this.groupDuaHau_Enter);
			componentResourceManager.ApplyResources(this.label63, "label63");
			this.label63.Name = "label63";
			componentResourceManager.ApplyResources(this.cboxBuonDuaHau, "cboxBuonDuaHau");
			this.cboxBuonDuaHau.Name = "cboxBuonDuaHau";
			this.cboxBuonDuaHau.UseVisualStyleBackColor = true;
			this.cboxBuonDuaHau.CheckedChanged += new global::System.EventHandler(this.cboxBuonDuaHau_CheckedChanged);
			this.btnDuaHauExpand.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			componentResourceManager.ApplyResources(this.btnDuaHauExpand, "btnDuaHauExpand");
			this.btnDuaHauExpand.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnDuaHauExpand.Name = "btnDuaHauExpand";
			this.btnDuaHauExpand.UseVisualStyleBackColor = false;
			this.btnDuaHauExpand.Click += new global::System.EventHandler(this.btnDuaHauExpand_Click);
			this.cboxDuaHauCity.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboxDuaHauCity.DropDownWidth = 70;
			componentResourceManager.ApplyResources(this.cboxDuaHauCity, "cboxDuaHauCity");
			this.cboxDuaHauCity.FormattingEnabled = true;
			this.cboxDuaHauCity.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboxDuaHauCity.Items"),
				componentResourceManager.GetString("cboxDuaHauCity.Items1"),
				componentResourceManager.GetString("cboxDuaHauCity.Items2"),
				componentResourceManager.GetString("cboxDuaHauCity.Items3")
			});
			this.cboxDuaHauCity.Name = "cboxDuaHauCity";
			this.cboxDuaHauCity.SelectedIndexChanged += new global::System.EventHandler(this.cboxDuaHauCity_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboDHAutoPick, "cboDHAutoPick");
			this.cboDHAutoPick.Name = "cboDHAutoPick";
			this.cboDHAutoPick.UseVisualStyleBackColor = true;
			this.cboDHAutoPick.CheckedChanged += new global::System.EventHandler(this.cboDHAutoPick_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboDHAutoNV, "cboDHAutoNV");
			this.cboDHAutoNV.Name = "cboDHAutoNV";
			this.cboDHAutoNV.UseVisualStyleBackColor = true;
			this.cboDHAutoNV.CheckedChanged += new global::System.EventHandler(this.cboDHAutoNV_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboDHAlertTuu, "cboDHAlertTuu");
			this.cboDHAlertTuu.Name = "cboDHAlertTuu";
			this.cboDHAlertTuu.UseVisualStyleBackColor = true;
			this.cboDHAlertTuu.CheckedChanged += new global::System.EventHandler(this.cboDHAlertTuu_CheckedChanged);
			this.txtDHBangID.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtDHBangID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtDHBangID, "txtDHBangID");
			this.txtDHBangID.Name = "txtDHBangID";
			this.txtDHBangID.TextChanged += new global::System.EventHandler(this.txtDHBangID_TextChanged);
			componentResourceManager.ApplyResources(this.label60, "label60");
			this.label60.Name = "label60";
			componentResourceManager.ApplyResources(this.btnDuaHauStart, "btnDuaHauStart");
			this.btnDuaHauStart.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnDuaHauStart.Name = "btnDuaHauStart";
			this.btnDuaHauStart.UseVisualStyleBackColor = true;
			this.btnDuaHauStart.Click += new global::System.EventHandler(this.btnDuaHauStart_Click);
			this.cboxDuaHauMaps.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboxDuaHauMaps.DropDownWidth = 70;
			componentResourceManager.ApplyResources(this.cboxDuaHauMaps, "cboxDuaHauMaps");
			this.cboxDuaHauMaps.FormattingEnabled = true;
			this.cboxDuaHauMaps.Name = "cboxDuaHauMaps";
			this.cboxDuaHauMaps.SelectedIndexChanged += new global::System.EventHandler(this.cboxDuaHauMaps_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label59, "label59");
			this.label59.Name = "label59";
			componentResourceManager.ApplyResources(this.cboDHFromCity, "cboDHFromCity");
			this.cboDHFromCity.Name = "cboDHFromCity";
			this.cboDHFromCity.UseVisualStyleBackColor = true;
			this.cboDHFromCity.CheckedChanged += new global::System.EventHandler(this.cboDHFromCity_CheckedChanged);
			this.groupKhaiKhoang.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupKhaiKhoang.Controls.Add(this.cboxNhatTuyetDungIm);
			this.groupKhaiKhoang.Controls.Add(this.cboLocDuoc);
			this.groupKhaiKhoang.Controls.Add(this.label47);
			this.groupKhaiKhoang.Controls.Add(this.cboxNhatTuyet);
			this.groupKhaiKhoang.Controls.Add(this.cboTTThuHoach);
			this.groupKhaiKhoang.Controls.Add(this.lblTTCity);
			this.groupKhaiKhoang.Controls.Add(this.cboxIsTrongTrot);
			this.groupKhaiKhoang.Controls.Add(this.cboxIsKhaiKhoang);
			this.groupKhaiKhoang.Controls.Add(this.btnKKExpand);
			this.groupKhaiKhoang.Controls.Add(this.lblTTTime);
			this.groupKhaiKhoang.Controls.Add(this.btnTTNPC2Add);
			this.groupKhaiKhoang.Controls.Add(this.cboKhoangDuocMaps);
			this.groupKhaiKhoang.Controls.Add(this.btnTTNPC1Add);
			this.groupKhaiKhoang.Controls.Add(this.label6);
			this.groupKhaiKhoang.Controls.Add(this.cboTTTen);
			this.groupKhaiKhoang.Controls.Add(this.txtTTNPC2_Y);
			this.groupKhaiKhoang.Controls.Add(this.cboxHaiDuoc);
			this.groupKhaiKhoang.Controls.Add(this.label8);
			this.groupKhaiKhoang.Controls.Add(this.txtTTNPC2_X);
			this.groupKhaiKhoang.Controls.Add(this.label7);
			this.groupKhaiKhoang.Controls.Add(this.cboxKhaiKhoang);
			this.groupKhaiKhoang.Controls.Add(this.cboTTLoai);
			this.groupKhaiKhoang.Controls.Add(this.txtTTNPC2_ID);
			this.groupKhaiKhoang.Controls.Add(this.txtTTNPC1_ID);
			this.groupKhaiKhoang.Controls.Add(this.txtTTNPC1_Y);
			this.groupKhaiKhoang.Controls.Add(this.label57);
			this.groupKhaiKhoang.Controls.Add(this.txtTTNPC1_X);
			this.groupKhaiKhoang.Controls.Add(this.label58);
			componentResourceManager.ApplyResources(this.groupKhaiKhoang, "groupKhaiKhoang");
			this.groupKhaiKhoang.Name = "groupKhaiKhoang";
			this.groupKhaiKhoang.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxNhatTuyetDungIm, "cboxNhatTuyetDungIm");
			this.cboxNhatTuyetDungIm.Name = "cboxNhatTuyetDungIm";
			this.cboxNhatTuyetDungIm.UseVisualStyleBackColor = true;
			this.cboxNhatTuyetDungIm.CheckedChanged += new global::System.EventHandler(this.cboxNhatTuyetDungIm_CheckedChanged);
			this.cboLocDuoc.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboLocDuoc.DropDownWidth = 110;
			componentResourceManager.ApplyResources(this.cboLocDuoc, "cboLocDuoc");
			this.cboLocDuoc.FormattingEnabled = true;
			this.cboLocDuoc.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboLocDuoc.Items"),
				componentResourceManager.GetString("cboLocDuoc.Items1"),
				componentResourceManager.GetString("cboLocDuoc.Items2"),
				componentResourceManager.GetString("cboLocDuoc.Items3"),
				componentResourceManager.GetString("cboLocDuoc.Items4")
			});
			this.cboLocDuoc.Name = "cboLocDuoc";
			this.cboLocDuoc.SelectedIndexChanged += new global::System.EventHandler(this.cboLocDuoc_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label47, "label47");
			this.label47.Name = "label47";
			componentResourceManager.ApplyResources(this.cboxNhatTuyet, "cboxNhatTuyet");
			this.cboxNhatTuyet.Name = "cboxNhatTuyet";
			this.cboxNhatTuyet.UseVisualStyleBackColor = true;
			this.cboxNhatTuyet.CheckedChanged += new global::System.EventHandler(this.cboxNhatTuyet_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboTTThuHoach, "cboTTThuHoach");
			this.cboTTThuHoach.Name = "cboTTThuHoach";
			this.cboTTThuHoach.UseVisualStyleBackColor = true;
			this.cboTTThuHoach.CheckedChanged += new global::System.EventHandler(this.cboTTThuHoach_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblTTCity, "lblTTCity");
			this.lblTTCity.Name = "lblTTCity";
			componentResourceManager.ApplyResources(this.cboxIsTrongTrot, "cboxIsTrongTrot");
			this.cboxIsTrongTrot.Name = "cboxIsTrongTrot";
			this.cboxIsTrongTrot.UseVisualStyleBackColor = true;
			this.cboxIsTrongTrot.CheckedChanged += new global::System.EventHandler(this.cboxIsTrongTrot_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxIsKhaiKhoang, "cboxIsKhaiKhoang");
			this.cboxIsKhaiKhoang.Name = "cboxIsKhaiKhoang";
			this.cboxIsKhaiKhoang.UseVisualStyleBackColor = true;
			this.cboxIsKhaiKhoang.CheckedChanged += new global::System.EventHandler(this.cboxIsKhaiKhoang_CheckedChanged);
			this.btnKKExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnKKExpand, "btnKKExpand");
			this.btnKKExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnKKExpand.Name = "btnKKExpand";
			this.btnKKExpand.UseVisualStyleBackColor = false;
			this.btnKKExpand.Click += new global::System.EventHandler(this.btnKKExpand_Click);
			componentResourceManager.ApplyResources(this.lblTTTime, "lblTTTime");
			this.lblTTTime.Name = "lblTTTime";
			this.btnTTNPC2Add.BackColor = global::System.Drawing.Color.FromArgb(235, 235, 235);
			componentResourceManager.ApplyResources(this.btnTTNPC2Add, "btnTTNPC2Add");
			this.btnTTNPC2Add.ForeColor = global::System.Drawing.Color.FromArgb(235, 235, 235);
			this.btnTTNPC2Add.Name = "btnTTNPC2Add";
			this.btnTTNPC2Add.UseVisualStyleBackColor = false;
			this.btnTTNPC2Add.Click += new global::System.EventHandler(this.btnTTNPC2Add_Click);
			this.cboKhoangDuocMaps.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboKhoangDuocMaps.DropDownWidth = 110;
			componentResourceManager.ApplyResources(this.cboKhoangDuocMaps, "cboKhoangDuocMaps");
			this.cboKhoangDuocMaps.FormattingEnabled = true;
			this.cboKhoangDuocMaps.Name = "cboKhoangDuocMaps";
			this.cboKhoangDuocMaps.SelectedIndexChanged += new global::System.EventHandler(this.cboKhoangDuocMaps_SelectedIndexChanged);
			this.btnTTNPC1Add.BackColor = global::System.Drawing.Color.FromArgb(235, 235, 235);
			componentResourceManager.ApplyResources(this.btnTTNPC1Add, "btnTTNPC1Add");
			this.btnTTNPC1Add.ForeColor = global::System.Drawing.Color.FromArgb(235, 235, 235);
			this.btnTTNPC1Add.Name = "btnTTNPC1Add";
			this.btnTTNPC1Add.UseVisualStyleBackColor = false;
			this.btnTTNPC1Add.Click += new global::System.EventHandler(this.btnTTNPC1Add_Click);
			componentResourceManager.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			this.cboTTTen.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.cboTTTen.DropDownWidth = 90;
			componentResourceManager.ApplyResources(this.cboTTTen, "cboTTTen");
			this.cboTTTen.FormattingEnabled = true;
			this.cboTTTen.Name = "cboTTTen";
			this.cboTTTen.SelectedIndexChanged += new global::System.EventHandler(this.cboTTTen_SelectedIndexChanged);
			this.txtTTNPC2_Y.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTTNPC2_Y.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTTNPC2_Y, "txtTTNPC2_Y");
			this.txtTTNPC2_Y.Name = "txtTTNPC2_Y";
			this.txtTTNPC2_Y.TextChanged += new global::System.EventHandler(this.txtTTNPC2_Y_TextChanged);
			componentResourceManager.ApplyResources(this.cboxHaiDuoc, "cboxHaiDuoc");
			this.cboxHaiDuoc.Name = "cboxHaiDuoc";
			this.cboxHaiDuoc.UseVisualStyleBackColor = true;
			this.cboxHaiDuoc.CheckedChanged += new global::System.EventHandler(this.cboxHaiDuoc_CheckedChanged);
			componentResourceManager.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			this.txtTTNPC2_X.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTTNPC2_X.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTTNPC2_X, "txtTTNPC2_X");
			this.txtTTNPC2_X.Name = "txtTTNPC2_X";
			this.txtTTNPC2_X.TextChanged += new global::System.EventHandler(this.txtTTNPC2_X_TextChanged);
			componentResourceManager.ApplyResources(this.label7, "label7");
			this.label7.Name = "label7";
			componentResourceManager.ApplyResources(this.cboxKhaiKhoang, "cboxKhaiKhoang");
			this.cboxKhaiKhoang.Name = "cboxKhaiKhoang";
			this.cboxKhaiKhoang.UseVisualStyleBackColor = true;
			this.cboxKhaiKhoang.CheckedChanged += new global::System.EventHandler(this.cboxKhaiKhoang_CheckedChanged);
			this.cboTTLoai.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboTTLoai, "cboTTLoai");
			this.cboTTLoai.FormattingEnabled = true;
			this.cboTTLoai.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboTTLoai.Items"),
				componentResourceManager.GetString("cboTTLoai.Items1")
			});
			this.cboTTLoai.Name = "cboTTLoai";
			this.cboTTLoai.SelectedIndexChanged += new global::System.EventHandler(this.cboTTLoai_SelectedIndexChanged);
			this.txtTTNPC2_ID.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTTNPC2_ID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTTNPC2_ID, "txtTTNPC2_ID");
			this.txtTTNPC2_ID.Name = "txtTTNPC2_ID";
			this.txtTTNPC2_ID.TextChanged += new global::System.EventHandler(this.txtTTNPC2_ID_TextChanged);
			this.txtTTNPC1_ID.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTTNPC1_ID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTTNPC1_ID, "txtTTNPC1_ID");
			this.txtTTNPC1_ID.Name = "txtTTNPC1_ID";
			this.txtTTNPC1_ID.TextChanged += new global::System.EventHandler(this.txtTTNPC1_ID_TextChanged);
			this.txtTTNPC1_Y.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTTNPC1_Y.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTTNPC1_Y, "txtTTNPC1_Y");
			this.txtTTNPC1_Y.Name = "txtTTNPC1_Y";
			this.txtTTNPC1_Y.TextChanged += new global::System.EventHandler(this.txtTTNPC1_Y_TextChanged);
			componentResourceManager.ApplyResources(this.label57, "label57");
			this.label57.Name = "label57";
			this.txtTTNPC1_X.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtTTNPC1_X.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.txtTTNPC1_X, "txtTTNPC1_X");
			this.txtTTNPC1_X.Name = "txtTTNPC1_X";
			this.txtTTNPC1_X.TextChanged += new global::System.EventHandler(this.txtTTNPC1_X_TextChanged);
			componentResourceManager.ApplyResources(this.label58, "label58");
			this.label58.Name = "label58";
			this.groupPhuBanTuyChinh.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupPhuBanTuyChinh.Controls.Add(this.label30);
			this.groupPhuBanTuyChinh.Controls.Add(this.btnPhuBanRefresh);
			this.groupPhuBanTuyChinh.Controls.Add(this.cboxPhuBanTuyChinh);
			this.groupPhuBanTuyChinh.Controls.Add(this.btnPhuBanOpen);
			this.groupPhuBanTuyChinh.Controls.Add(this.cboPhuBanPP);
			componentResourceManager.ApplyResources(this.groupPhuBanTuyChinh, "groupPhuBanTuyChinh");
			this.groupPhuBanTuyChinh.Name = "groupPhuBanTuyChinh";
			this.groupPhuBanTuyChinh.TabStop = false;
			componentResourceManager.ApplyResources(this.label30, "label30");
			this.label30.Name = "label30";
			this.label30.Click += new global::System.EventHandler(this.label30_Click);
			this.btnPhuBanRefresh.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnPhuBanRefresh, "btnPhuBanRefresh");
			this.btnPhuBanRefresh.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnPhuBanRefresh.Image = global::ns0.Class212.refresh2;
			this.btnPhuBanRefresh.Name = "btnPhuBanRefresh";
			this.btnPhuBanRefresh.UseVisualStyleBackColor = false;
			this.btnPhuBanRefresh.Click += new global::System.EventHandler(this.btnPhuBanRefresh_Click);
			componentResourceManager.ApplyResources(this.cboxPhuBanTuyChinh, "cboxPhuBanTuyChinh");
			this.cboxPhuBanTuyChinh.Name = "cboxPhuBanTuyChinh";
			this.cboxPhuBanTuyChinh.UseVisualStyleBackColor = true;
			this.cboxPhuBanTuyChinh.CheckedChanged += new global::System.EventHandler(this.cboxPhuBanTuyChinh_CheckedChanged);
			this.btnPhuBanOpen.BackColor = global::System.Drawing.Color.Transparent;
			componentResourceManager.ApplyResources(this.btnPhuBanOpen, "btnPhuBanOpen");
			this.btnPhuBanOpen.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnPhuBanOpen.Image = global::ns0.Class212.folderopen;
			this.btnPhuBanOpen.Name = "btnPhuBanOpen";
			this.btnPhuBanOpen.UseVisualStyleBackColor = false;
			this.btnPhuBanOpen.Click += new global::System.EventHandler(this.btnPhuBanOpen_Click);
			this.cboPhuBanPP.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboPhuBanPP, "cboPhuBanPP");
			this.cboPhuBanPP.FormattingEnabled = true;
			this.cboPhuBanPP.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboPhuBanPP.Items")
			});
			this.cboPhuBanPP.Name = "cboPhuBanPP";
			this.cboPhuBanPP.SelectedIndexChanged += new global::System.EventHandler(this.cboPhuBanPP_SelectedIndexChanged);
			this.groupScheduler.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupScheduler.Controls.Add(this.btnAutoPK);
			this.groupScheduler.Controls.Add(this.cboxAutoPK);
			this.groupScheduler.Controls.Add(this.btnNhiemVu2);
			this.groupScheduler.Controls.Add(this.label50);
			this.groupScheduler.Controls.Add(this.btnScheduler);
			this.groupScheduler.Controls.Add(this.cboxScheduler);
			componentResourceManager.ApplyResources(this.groupScheduler, "groupScheduler");
			this.groupScheduler.Name = "groupScheduler";
			this.groupScheduler.TabStop = false;
			this.btnAutoPK.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnAutoPK, "btnAutoPK");
			this.btnAutoPK.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnAutoPK.Image = global::ns0.Class212.setting;
			this.btnAutoPK.Name = "btnAutoPK";
			this.btnAutoPK.UseVisualStyleBackColor = false;
			this.btnAutoPK.Click += new global::System.EventHandler(this.btnAutoPK_Click);
			componentResourceManager.ApplyResources(this.cboxAutoPK, "cboxAutoPK");
			this.cboxAutoPK.ForeColor = global::System.Drawing.Color.Fuchsia;
			this.cboxAutoPK.Name = "cboxAutoPK";
			this.cboxAutoPK.UseVisualStyleBackColor = true;
			this.cboxAutoPK.CheckedChanged += new global::System.EventHandler(this.cboxAutoPK_CheckedChanged);
			this.btnNhiemVu2.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnNhiemVu2, "btnNhiemVu2");
			this.btnNhiemVu2.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnNhiemVu2.Image = global::ns0.Class212.setting;
			this.btnNhiemVu2.Name = "btnNhiemVu2";
			this.btnNhiemVu2.UseVisualStyleBackColor = false;
			componentResourceManager.ApplyResources(this.label50, "label50");
			this.label50.ForeColor = global::System.Drawing.Color.Magenta;
			this.label50.Name = "label50";
			this.btnScheduler.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnScheduler, "btnScheduler");
			this.btnScheduler.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnScheduler.Image = global::ns0.Class212.setting;
			this.btnScheduler.Name = "btnScheduler";
			this.btnScheduler.UseVisualStyleBackColor = false;
			this.btnScheduler.Click += new global::System.EventHandler(this.btnScheduler_Click);
			componentResourceManager.ApplyResources(this.cboxScheduler, "cboxScheduler");
			this.cboxScheduler.ForeColor = global::System.Drawing.Color.Fuchsia;
			this.cboxScheduler.Name = "cboxScheduler";
			this.cboxScheduler.UseVisualStyleBackColor = true;
			this.cboxScheduler.CheckedChanged += new global::System.EventHandler(this.cboxScheduler_CheckedChanged);
			this.tabTienIch.BackColor = global::System.Drawing.Color.Transparent;
			this.tabTienIch.Controls.Add(this.groupDied);
			this.tabTienIch.Controls.Add(this.groupToDoi);
			this.tabTienIch.Controls.Add(this.groupVeThanh);
			this.tabTienIch.Controls.Add(this.groupTocDoTrain);
			this.tabTienIch.Controls.Add(this.groupTuyChon);
			this.tabTienIch.Controls.Add(this.groupChat);
			componentResourceManager.ApplyResources(this.tabTienIch, "tabTienIch");
			this.tabTienIch.Name = "tabTienIch";
			this.groupDied.BackColor = global::System.Drawing.Color.FromArgb(195, 195, 195);
			this.groupDied.Controls.Add(this.numChoHoiSinh);
			this.groupDied.Controls.Add(this.cboxChoHoiSinh);
			this.groupDied.Controls.Add(this.rdioThoatGame);
			this.groupDied.Controls.Add(this.rdioUongTra);
			this.groupDied.Controls.Add(this.label42);
			this.groupDied.Controls.Add(this.rdioLenDiemTrain);
			componentResourceManager.ApplyResources(this.groupDied, "groupDied");
			this.groupDied.Name = "groupDied";
			this.groupDied.TabStop = false;
			this.groupDied.Enter += new global::System.EventHandler(this.groupDied_Enter);
			this.numChoHoiSinh.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numChoHoiSinh, "numChoHoiSinh");
			global::System.Windows.Forms.NumericUpDown numericUpDown69 = this.numChoHoiSinh;
			int[] array69 = new int[4];
			array69[0] = 300;
			numericUpDown69.Maximum = new decimal(array69);
			global::System.Windows.Forms.NumericUpDown numericUpDown70 = this.numChoHoiSinh;
			int[] array70 = new int[4];
			array70[0] = 2;
			numericUpDown70.Minimum = new decimal(array70);
			this.numChoHoiSinh.Name = "numChoHoiSinh";
			global::System.Windows.Forms.NumericUpDown numericUpDown71 = this.numChoHoiSinh;
			int[] array71 = new int[4];
			array71[0] = 20;
			numericUpDown71.Value = new decimal(array71);
			this.numChoHoiSinh.ValueChanged += new global::System.EventHandler(this.numChoHoiSinh_ValueChanged);
			this.numChoHoiSinh.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numChoHoiSinh_KeyPress);
			componentResourceManager.ApplyResources(this.cboxChoHoiSinh, "cboxChoHoiSinh");
			this.cboxChoHoiSinh.Name = "cboxChoHoiSinh";
			this.cboxChoHoiSinh.UseVisualStyleBackColor = true;
			this.cboxChoHoiSinh.CheckedChanged += new global::System.EventHandler(this.cboxChoHoiSinh_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioThoatGame, "rdioThoatGame");
			this.rdioThoatGame.Name = "rdioThoatGame";
			this.rdioThoatGame.UseVisualStyleBackColor = true;
			this.rdioThoatGame.CheckedChanged += new global::System.EventHandler(this.rdioThoatGame_CheckedChanged);
			componentResourceManager.ApplyResources(this.rdioUongTra, "rdioUongTra");
			this.rdioUongTra.Name = "rdioUongTra";
			this.rdioUongTra.UseVisualStyleBackColor = true;
			this.rdioUongTra.CheckedChanged += new global::System.EventHandler(this.rdioUongTra_CheckedChanged);
			componentResourceManager.ApplyResources(this.label42, "label42");
			this.label42.BackColor = global::System.Drawing.Color.Transparent;
			this.label42.Name = "label42";
			componentResourceManager.ApplyResources(this.rdioLenDiemTrain, "rdioLenDiemTrain");
			this.rdioLenDiemTrain.Checked = true;
			this.rdioLenDiemTrain.Name = "rdioLenDiemTrain";
			this.rdioLenDiemTrain.TabStop = true;
			this.rdioLenDiemTrain.UseVisualStyleBackColor = true;
			this.rdioLenDiemTrain.CheckedChanged += new global::System.EventHandler(this.rdioLenDiemTrain_CheckedChanged);
			this.groupToDoi.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.groupToDoi.Controls.Add(this.btnToDoiExpand);
			this.groupToDoi.Controls.Add(this.btnPTBlacklist);
			this.groupToDoi.Controls.Add(this.label12);
			this.groupToDoi.Controls.Add(this.numPTLevel);
			this.groupToDoi.Controls.Add(this.btnPTChoVao);
			this.groupToDoi.Controls.Add(this.cboxPTChoVao);
			this.groupToDoi.Controls.Add(this.cboxPTLevel);
			this.groupToDoi.Controls.Add(this.btnPTAcceptList);
			this.groupToDoi.Controls.Add(this.cboxTuVaoPT);
			componentResourceManager.ApplyResources(this.groupToDoi, "groupToDoi");
			this.groupToDoi.Name = "groupToDoi";
			this.groupToDoi.TabStop = false;
			this.btnToDoiExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnToDoiExpand, "btnToDoiExpand");
			this.btnToDoiExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnToDoiExpand.Name = "btnToDoiExpand";
			this.btnToDoiExpand.UseVisualStyleBackColor = false;
			this.btnToDoiExpand.Click += new global::System.EventHandler(this.btnToDoiExpand_Click);
			this.btnPTBlacklist.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnPTBlacklist, "btnPTBlacklist");
			this.btnPTBlacklist.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnPTBlacklist.Name = "btnPTBlacklist";
			this.btnPTBlacklist.UseVisualStyleBackColor = false;
			this.btnPTBlacklist.Click += new global::System.EventHandler(this.btnPTBlacklist_Click);
			componentResourceManager.ApplyResources(this.label12, "label12");
			this.label12.Name = "label12";
			this.numPTLevel.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numPTLevel, "numPTLevel");
			global::System.Windows.Forms.NumericUpDown numericUpDown72 = this.numPTLevel;
			int[] array72 = new int[4];
			array72[0] = 999;
			numericUpDown72.Maximum = new decimal(array72);
			global::System.Windows.Forms.NumericUpDown numericUpDown73 = this.numPTLevel;
			int[] array73 = new int[4];
			array73[0] = 1;
			numericUpDown73.Minimum = new decimal(array73);
			this.numPTLevel.Name = "numPTLevel";
			global::System.Windows.Forms.NumericUpDown numericUpDown74 = this.numPTLevel;
			int[] array74 = new int[4];
			array74[0] = 120;
			numericUpDown74.Value = new decimal(array74);
			this.numPTLevel.ValueChanged += new global::System.EventHandler(this.numPTLevel_ValueChanged);
			this.numPTLevel.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numPTLevel_KeyPress);
			this.btnPTChoVao.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnPTChoVao, "btnPTChoVao");
			this.btnPTChoVao.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnPTChoVao.Name = "btnPTChoVao";
			this.btnPTChoVao.UseVisualStyleBackColor = false;
			this.btnPTChoVao.Click += new global::System.EventHandler(this.btnPTChoVao_Click);
			componentResourceManager.ApplyResources(this.cboxPTChoVao, "cboxPTChoVao");
			this.cboxPTChoVao.Checked = true;
			this.cboxPTChoVao.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxPTChoVao.Name = "cboxPTChoVao";
			this.cboxPTChoVao.UseVisualStyleBackColor = true;
			this.cboxPTChoVao.CheckedChanged += new global::System.EventHandler(this.cboxPTChoVao_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxPTLevel, "cboxPTLevel");
			this.cboxPTLevel.Name = "cboxPTLevel";
			this.cboxPTLevel.UseVisualStyleBackColor = true;
			this.cboxPTLevel.CheckedChanged += new global::System.EventHandler(this.cboxPTLevel_CheckedChanged);
			this.btnPTAcceptList.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnPTAcceptList, "btnPTAcceptList");
			this.btnPTAcceptList.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnPTAcceptList.Name = "btnPTAcceptList";
			this.btnPTAcceptList.UseVisualStyleBackColor = false;
			this.btnPTAcceptList.Click += new global::System.EventHandler(this.btnPTAcceptList_Click);
			componentResourceManager.ApplyResources(this.cboxTuVaoPT, "cboxTuVaoPT");
			this.cboxTuVaoPT.Checked = true;
			this.cboxTuVaoPT.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxTuVaoPT.Name = "cboxTuVaoPT";
			this.cboxTuVaoPT.UseVisualStyleBackColor = true;
			this.cboxTuVaoPT.CheckedChanged += new global::System.EventHandler(this.cboxTuVaoPT_CheckedChanged);
			this.groupVeThanh.BackColor = global::System.Drawing.Color.FromArgb(215, 215, 215);
			this.groupVeThanh.Controls.Add(this.cboxDuY);
			this.groupVeThanh.Controls.Add(this.btnVeThanhExpand);
			this.groupVeThanh.Controls.Add(this.cboxVeThanhHetBNM);
			this.groupVeThanh.Controls.Add(this.cboPetFoodType);
			this.groupVeThanh.Controls.Add(this.cboVeThanh);
			this.groupVeThanh.Controls.Add(this.numVeThanhMP);
			this.groupVeThanh.Controls.Add(this.numVeThanhHP);
			this.groupVeThanh.Controls.Add(this.cboxVeThanhHetThucAn);
			this.groupVeThanh.Controls.Add(this.label21);
			this.groupVeThanh.Controls.Add(this.cboThanhQuayVe);
			this.groupVeThanh.Controls.Add(this.label22);
			this.groupVeThanh.Controls.Add(this.label25);
			componentResourceManager.ApplyResources(this.groupVeThanh, "groupVeThanh");
			this.groupVeThanh.Name = "groupVeThanh";
			this.groupVeThanh.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxDuY, "cboxDuY");
			this.cboxDuY.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxDuY.Name = "cboxDuY";
			this.cboxDuY.UseVisualStyleBackColor = false;
			this.cboxDuY.CheckedChanged += new global::System.EventHandler(this.cboxDuY_CheckedChanged);
			this.btnVeThanhExpand.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnVeThanhExpand, "btnVeThanhExpand");
			this.btnVeThanhExpand.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnVeThanhExpand.Name = "btnVeThanhExpand";
			this.btnVeThanhExpand.UseVisualStyleBackColor = false;
			this.btnVeThanhExpand.Click += new global::System.EventHandler(this.btnVeThanhExpand_Click);
			componentResourceManager.ApplyResources(this.cboxVeThanhHetBNM, "cboxVeThanhHetBNM");
			this.cboxVeThanhHetBNM.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxVeThanhHetBNM.Name = "cboxVeThanhHetBNM";
			this.cboxVeThanhHetBNM.UseVisualStyleBackColor = false;
			this.cboxVeThanhHetBNM.CheckedChanged += new global::System.EventHandler(this.cboxVeThanhHetBNM_CheckedChanged);
			this.cboPetFoodType.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboPetFoodType, "cboPetFoodType");
			this.cboPetFoodType.FormattingEnabled = true;
			this.cboPetFoodType.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboPetFoodType.Items"),
				componentResourceManager.GetString("cboPetFoodType.Items1"),
				componentResourceManager.GetString("cboPetFoodType.Items2"),
				componentResourceManager.GetString("cboPetFoodType.Items3"),
				componentResourceManager.GetString("cboPetFoodType.Items4")
			});
			this.cboPetFoodType.Name = "cboPetFoodType";
			this.cboPetFoodType.SelectedIndexChanged += new global::System.EventHandler(this.cboPetFoodType_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.cboVeThanh, "cboVeThanh");
			this.cboVeThanh.BackColor = global::System.Drawing.Color.Transparent;
			this.cboVeThanh.Name = "cboVeThanh";
			this.cboVeThanh.UseVisualStyleBackColor = false;
			this.cboVeThanh.CheckedChanged += new global::System.EventHandler(this.cboVeThanh_CheckedChanged);
			this.numVeThanhMP.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown75 = this.numVeThanhMP;
			int[] array75 = new int[4];
			array75[0] = 5;
			numericUpDown75.Increment = new decimal(array75);
			componentResourceManager.ApplyResources(this.numVeThanhMP, "numVeThanhMP");
			global::System.Windows.Forms.NumericUpDown numericUpDown76 = this.numVeThanhMP;
			int[] array76 = new int[4];
			array76[0] = 50;
			numericUpDown76.Maximum = new decimal(array76);
			this.numVeThanhMP.Name = "numVeThanhMP";
			global::System.Windows.Forms.NumericUpDown numericUpDown77 = this.numVeThanhMP;
			int[] array77 = new int[4];
			array77[0] = 1;
			numericUpDown77.Value = new decimal(array77);
			this.numVeThanhMP.ValueChanged += new global::System.EventHandler(this.numVeThanhMP_ValueChanged);
			this.numVeThanhMP.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numVeThanhMP_KeyPress);
			this.numVeThanhHP.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown78 = this.numVeThanhHP;
			int[] array78 = new int[4];
			array78[0] = 5;
			numericUpDown78.Increment = new decimal(array78);
			componentResourceManager.ApplyResources(this.numVeThanhHP, "numVeThanhHP");
			global::System.Windows.Forms.NumericUpDown numericUpDown79 = this.numVeThanhHP;
			int[] array79 = new int[4];
			array79[0] = 50;
			numericUpDown79.Maximum = new decimal(array79);
			this.numVeThanhHP.Name = "numVeThanhHP";
			global::System.Windows.Forms.NumericUpDown numericUpDown80 = this.numVeThanhHP;
			int[] array80 = new int[4];
			array80[0] = 1;
			numericUpDown80.Value = new decimal(array80);
			this.numVeThanhHP.ValueChanged += new global::System.EventHandler(this.numVeThanhHP_ValueChanged);
			this.numVeThanhHP.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numVeThanhHP_KeyPress);
			componentResourceManager.ApplyResources(this.cboxVeThanhHetThucAn, "cboxVeThanhHetThucAn");
			this.cboxVeThanhHetThucAn.BackColor = global::System.Drawing.Color.Transparent;
			this.cboxVeThanhHetThucAn.Name = "cboxVeThanhHetThucAn";
			this.cboxVeThanhHetThucAn.UseVisualStyleBackColor = false;
			this.cboxVeThanhHetThucAn.CheckedChanged += new global::System.EventHandler(this.cboxVeThanhHetThucAn_CheckedChanged);
			componentResourceManager.ApplyResources(this.label21, "label21");
			this.label21.Name = "label21";
			this.cboThanhQuayVe.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboThanhQuayVe, "cboThanhQuayVe");
			this.cboThanhQuayVe.FormattingEnabled = true;
			this.cboThanhQuayVe.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboThanhQuayVe.Items"),
				componentResourceManager.GetString("cboThanhQuayVe.Items1"),
				componentResourceManager.GetString("cboThanhQuayVe.Items2"),
				componentResourceManager.GetString("cboThanhQuayVe.Items3"),
				componentResourceManager.GetString("cboThanhQuayVe.Items4"),
				componentResourceManager.GetString("cboThanhQuayVe.Items5")
			});
			this.cboThanhQuayVe.Name = "cboThanhQuayVe";
			this.cboThanhQuayVe.SelectedIndexChanged += new global::System.EventHandler(this.cboThanhQuayVe_SelectedIndexChanged);
			componentResourceManager.ApplyResources(this.label22, "label22");
			this.label22.BackColor = global::System.Drawing.Color.Transparent;
			this.label22.Name = "label22";
			componentResourceManager.ApplyResources(this.label25, "label25");
			this.label25.BackColor = global::System.Drawing.Color.Transparent;
			this.label25.Name = "label25";
			this.groupTocDoTrain.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.groupTocDoTrain.Controls.Add(this.btnSpeedExpand);
			this.groupTocDoTrain.Controls.Add(this.lblTrainSpeed4);
			this.groupTocDoTrain.Controls.Add(this.lblTrainSpeed3);
			this.groupTocDoTrain.Controls.Add(this.btnTrainExpReset);
			this.groupTocDoTrain.Controls.Add(this.lblTrainSpeed2);
			this.groupTocDoTrain.Controls.Add(this.lblTrainSpeed);
			this.groupTocDoTrain.Controls.Add(this.cboTrainExpMode);
			componentResourceManager.ApplyResources(this.groupTocDoTrain, "groupTocDoTrain");
			this.groupTocDoTrain.Name = "groupTocDoTrain";
			this.groupTocDoTrain.TabStop = false;
			this.btnSpeedExpand.BackColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			componentResourceManager.ApplyResources(this.btnSpeedExpand, "btnSpeedExpand");
			this.btnSpeedExpand.ForeColor = global::System.Drawing.Color.FromArgb(205, 205, 205);
			this.btnSpeedExpand.Name = "btnSpeedExpand";
			this.btnSpeedExpand.UseVisualStyleBackColor = false;
			this.btnSpeedExpand.Click += new global::System.EventHandler(this.btnSpeedExpand_Click);
			componentResourceManager.ApplyResources(this.lblTrainSpeed4, "lblTrainSpeed4");
			this.lblTrainSpeed4.Name = "lblTrainSpeed4";
			componentResourceManager.ApplyResources(this.lblTrainSpeed3, "lblTrainSpeed3");
			this.lblTrainSpeed3.Name = "lblTrainSpeed3";
			componentResourceManager.ApplyResources(this.btnTrainExpReset, "btnTrainExpReset");
			this.btnTrainExpReset.Name = "btnTrainExpReset";
			this.btnTrainExpReset.UseVisualStyleBackColor = true;
			this.btnTrainExpReset.Click += new global::System.EventHandler(this.btnTrainExpReset_Click);
			componentResourceManager.ApplyResources(this.lblTrainSpeed2, "lblTrainSpeed2");
			this.lblTrainSpeed2.Name = "lblTrainSpeed2";
			componentResourceManager.ApplyResources(this.lblTrainSpeed, "lblTrainSpeed");
			this.lblTrainSpeed.Name = "lblTrainSpeed";
			this.cboTrainExpMode.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboTrainExpMode, "cboTrainExpMode");
			this.cboTrainExpMode.FormattingEnabled = true;
			this.cboTrainExpMode.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboTrainExpMode.Items"),
				componentResourceManager.GetString("cboTrainExpMode.Items1"),
				componentResourceManager.GetString("cboTrainExpMode.Items2")
			});
			this.cboTrainExpMode.Name = "cboTrainExpMode";
			this.cboTrainExpMode.SelectedIndexChanged += new global::System.EventHandler(this.cboTrainExpMode_SelectedIndexChanged);
			this.groupTuyChon.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.groupTuyChon.Controls.Add(this.btnShutdown);
			this.groupTuyChon.Controls.Add(this.numShutdownM);
			this.groupTuyChon.Controls.Add(this.label23);
			this.groupTuyChon.Controls.Add(this.label20);
			this.groupTuyChon.Controls.Add(this.numShutdownH);
			this.groupTuyChon.Controls.Add(this.label19);
			this.groupTuyChon.Controls.Add(this.numUpLevel);
			this.groupTuyChon.Controls.Add(this.cboxThoLinhChau);
			this.groupTuyChon.Controls.Add(this.lblTimeOnline);
			this.groupTuyChon.Controls.Add(this.btnTuyChonExpand);
			this.groupTuyChon.Controls.Add(this.btnResetGio);
			this.groupTuyChon.Controls.Add(this.cboxTuUpLevel);
			this.groupTuyChon.Controls.Add(this.label26);
			this.groupTuyChon.Controls.Add(this.cboxSupportLog);
			this.groupTuyChon.Controls.Add(this.cboxTuClickYes);
			this.groupTuyChon.Controls.Add(this.cboxKhongResetGio);
			this.groupTuyChon.Controls.Add(this.cboxAnHienGame);
			this.groupTuyChon.Controls.Add(this.txtPassCap2);
			this.groupTuyChon.Controls.Add(this.cboxTNAlert);
			this.groupTuyChon.Controls.Add(this.cboxPassCap2);
			this.groupTuyChon.Controls.Add(this.cboxTNAlertPK);
			this.groupTuyChon.Controls.Add(this.cboxCaptchaReset);
			this.groupTuyChon.Controls.Add(this.cboxCanX2);
			this.groupTuyChon.Controls.Add(this.cboxCanX4);
			this.groupTuyChon.Controls.Add(this.cboxChayNhanh);
			componentResourceManager.ApplyResources(this.groupTuyChon, "groupTuyChon");
			this.groupTuyChon.Name = "groupTuyChon";
			this.groupTuyChon.TabStop = false;
			componentResourceManager.ApplyResources(this.btnShutdown, "btnShutdown");
			this.btnShutdown.Name = "btnShutdown";
			this.btnShutdown.UseVisualStyleBackColor = true;
			this.btnShutdown.Click += new global::System.EventHandler(this.btnShutdown_Click);
			this.numShutdownM.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numShutdownM, "numShutdownM");
			global::System.Windows.Forms.NumericUpDown numericUpDown81 = this.numShutdownM;
			int[] array81 = new int[4];
			array81[0] = 999;
			numericUpDown81.Maximum = new decimal(array81);
			this.numShutdownM.Name = "numShutdownM";
			global::System.Windows.Forms.NumericUpDown numericUpDown82 = this.numShutdownM;
			int[] array82 = new int[4];
			array82[0] = 20;
			numericUpDown82.Value = new decimal(array82);
			this.numShutdownM.ValueChanged += new global::System.EventHandler(this.numShutdownM_ValueChanged);
			this.numShutdownM.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numShutdownM_KeyPress);
			componentResourceManager.ApplyResources(this.label23, "label23");
			this.label23.BackColor = global::System.Drawing.Color.Transparent;
			this.label23.Name = "label23";
			componentResourceManager.ApplyResources(this.label20, "label20");
			this.label20.Name = "label20";
			this.numShutdownH.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numShutdownH, "numShutdownH");
			global::System.Windows.Forms.NumericUpDown numericUpDown83 = this.numShutdownH;
			int[] array83 = new int[4];
			array83[0] = 999;
			numericUpDown83.Maximum = new decimal(array83);
			this.numShutdownH.Name = "numShutdownH";
			global::System.Windows.Forms.NumericUpDown numericUpDown84 = this.numShutdownH;
			int[] array84 = new int[4];
			array84[0] = 24;
			numericUpDown84.Value = new decimal(array84);
			this.numShutdownH.ValueChanged += new global::System.EventHandler(this.numShutdownH_ValueChanged);
			this.numShutdownH.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numShutdownH_KeyPress);
			componentResourceManager.ApplyResources(this.label19, "label19");
			this.label19.BackColor = global::System.Drawing.Color.Transparent;
			this.label19.Name = "label19";
			this.numUpLevel.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numUpLevel, "numUpLevel");
			global::System.Windows.Forms.NumericUpDown numericUpDown85 = this.numUpLevel;
			int[] array85 = new int[4];
			array85[0] = 999;
			numericUpDown85.Maximum = new decimal(array85);
			this.numUpLevel.Name = "numUpLevel";
			this.numUpLevel.ValueChanged += new global::System.EventHandler(this.numUpLevel_ValueChanged);
			this.numUpLevel.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numUpLevel_KeyPress);
			componentResourceManager.ApplyResources(this.cboxThoLinhChau, "cboxThoLinhChau");
			this.cboxThoLinhChau.ForeColor = global::System.Drawing.Color.Black;
			this.cboxThoLinhChau.Name = "cboxThoLinhChau";
			this.cboxThoLinhChau.UseVisualStyleBackColor = true;
			this.cboxThoLinhChau.CheckedChanged += new global::System.EventHandler(this.cboxThoLinhChau_CheckedChanged);
			componentResourceManager.ApplyResources(this.lblTimeOnline, "lblTimeOnline");
			this.lblTimeOnline.Name = "lblTimeOnline";
			this.btnTuyChonExpand.BackColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			componentResourceManager.ApplyResources(this.btnTuyChonExpand, "btnTuyChonExpand");
			this.btnTuyChonExpand.ForeColor = global::System.Drawing.Color.FromArgb(225, 225, 225);
			this.btnTuyChonExpand.Name = "btnTuyChonExpand";
			this.btnTuyChonExpand.UseVisualStyleBackColor = false;
			this.btnTuyChonExpand.Click += new global::System.EventHandler(this.btnTuyChonExpand_Click);
			componentResourceManager.ApplyResources(this.btnResetGio, "btnResetGio");
			this.btnResetGio.Name = "btnResetGio";
			this.btnResetGio.UseVisualStyleBackColor = true;
			this.btnResetGio.Click += new global::System.EventHandler(this.btnResetGio_Click);
			componentResourceManager.ApplyResources(this.cboxTuUpLevel, "cboxTuUpLevel");
			this.cboxTuUpLevel.Name = "cboxTuUpLevel";
			this.cboxTuUpLevel.UseVisualStyleBackColor = true;
			this.cboxTuUpLevel.CheckedChanged += new global::System.EventHandler(this.cboxTuUpLevel_CheckedChanged);
			componentResourceManager.ApplyResources(this.label26, "label26");
			this.label26.Name = "label26";
			componentResourceManager.ApplyResources(this.cboxSupportLog, "cboxSupportLog");
			this.cboxSupportLog.ForeColor = global::System.Drawing.Color.DodgerBlue;
			this.cboxSupportLog.Name = "cboxSupportLog";
			this.cboxSupportLog.UseVisualStyleBackColor = true;
			this.cboxSupportLog.CheckedChanged += new global::System.EventHandler(this.cboxSupportLog_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTuClickYes, "cboxTuClickYes");
			this.cboxTuClickYes.Name = "cboxTuClickYes";
			this.cboxTuClickYes.UseVisualStyleBackColor = true;
			this.cboxTuClickYes.CheckedChanged += new global::System.EventHandler(this.cboxTuClickYes_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxKhongResetGio, "cboxKhongResetGio");
			this.cboxKhongResetGio.Name = "cboxKhongResetGio";
			this.cboxKhongResetGio.UseVisualStyleBackColor = true;
			this.cboxKhongResetGio.CheckedChanged += new global::System.EventHandler(this.cboxKhongResetGio_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxAnHienGame, "cboxAnHienGame");
			this.cboxAnHienGame.Name = "cboxAnHienGame";
			this.cboxAnHienGame.UseVisualStyleBackColor = true;
			this.cboxAnHienGame.CheckedChanged += new global::System.EventHandler(this.cboxAnHienGame_CheckedChanged);
			this.txtPassCap2.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			this.txtPassCap2.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.txtPassCap2, "txtPassCap2");
			this.txtPassCap2.Name = "txtPassCap2";
			this.txtPassCap2.UseSystemPasswordChar = true;
			this.txtPassCap2.TextChanged += new global::System.EventHandler(this.txtPassCap2_TextChanged);
			componentResourceManager.ApplyResources(this.cboxTNAlert, "cboxTNAlert");
			this.cboxTNAlert.Name = "cboxTNAlert";
			this.cboxTNAlert.UseVisualStyleBackColor = true;
			this.cboxTNAlert.CheckedChanged += new global::System.EventHandler(this.cboxTNAlert_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxPassCap2, "cboxPassCap2");
			this.cboxPassCap2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.cboxPassCap2.Name = "cboxPassCap2";
			this.cboxPassCap2.UseVisualStyleBackColor = true;
			this.cboxPassCap2.CheckedChanged += new global::System.EventHandler(this.cboxPassCap2_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxTNAlertPK, "cboxTNAlertPK");
			this.cboxTNAlertPK.Name = "cboxTNAlertPK";
			this.cboxTNAlertPK.UseVisualStyleBackColor = true;
			this.cboxTNAlertPK.CheckedChanged += new global::System.EventHandler(this.cboxTNAlertPK_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxCaptchaReset, "cboxCaptchaReset");
			this.cboxCaptchaReset.Name = "cboxCaptchaReset";
			this.cboxCaptchaReset.UseVisualStyleBackColor = true;
			this.cboxCaptchaReset.CheckedChanged += new global::System.EventHandler(this.cboxCaptchaReset_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxCanX2, "cboxCanX2");
			this.cboxCanX2.Name = "cboxCanX2";
			this.cboxCanX2.UseVisualStyleBackColor = true;
			this.cboxCanX2.CheckedChanged += new global::System.EventHandler(this.cboxCanX2_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxCanX4, "cboxCanX4");
			this.cboxCanX4.ForeColor = global::System.Drawing.Color.Black;
			this.cboxCanX4.Name = "cboxCanX4";
			this.cboxCanX4.UseVisualStyleBackColor = true;
			this.cboxCanX4.CheckedChanged += new global::System.EventHandler(this.cboxCanX4_CheckedChanged);
			componentResourceManager.ApplyResources(this.cboxChayNhanh, "cboxChayNhanh");
			this.cboxChayNhanh.Name = "cboxChayNhanh";
			this.cboxChayNhanh.UseVisualStyleBackColor = true;
			this.cboxChayNhanh.CheckedChanged += new global::System.EventHandler(this.cboxChayNhanh_CheckedChanged);
			this.groupChat.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.groupChat.Controls.Add(this.cboxVIPPM);
			this.groupChat.Controls.Add(this.numAutoChat);
			this.groupChat.Controls.Add(this.cboxChatSavedMsg);
			this.groupChat.Controls.Add(this.btnChatDelete);
			this.groupChat.Controls.Add(this.btnChatRecord);
			this.groupChat.Controls.Add(this.label3);
			this.groupChat.Controls.Add(this.label1);
			this.groupChat.Controls.Add(this.btnChatExpand);
			this.groupChat.Controls.Add(this.lblNextChat);
			this.groupChat.Controls.Add(this.lbChatTimes);
			this.groupChat.Controls.Add(this.cboxAutoChat);
			this.groupChat.Controls.Add(this.btnSendChat);
			this.groupChat.Controls.Add(this.cboxHelpChat);
			this.groupChat.Controls.Add(this.cboKenhChat);
			this.groupChat.Controls.Add(this.richChat);
			componentResourceManager.ApplyResources(this.groupChat, "groupChat");
			this.groupChat.Name = "groupChat";
			this.groupChat.TabStop = false;
			componentResourceManager.ApplyResources(this.cboxVIPPM, "cboxVIPPM");
			this.cboxVIPPM.Name = "cboxVIPPM";
			this.cboxVIPPM.UseVisualStyleBackColor = true;
			this.cboxVIPPM.CheckedChanged += new global::System.EventHandler(this.cboxVIPPM_CheckedChanged);
			this.numAutoChat.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			global::System.Windows.Forms.NumericUpDown numericUpDown86 = this.numAutoChat;
			int[] array86 = new int[4];
			array86[0] = 5;
			numericUpDown86.Increment = new decimal(array86);
			componentResourceManager.ApplyResources(this.numAutoChat, "numAutoChat");
			global::System.Windows.Forms.NumericUpDown numericUpDown87 = this.numAutoChat;
			int[] array87 = new int[4];
			array87[0] = 9999;
			numericUpDown87.Maximum = new decimal(array87);
			global::System.Windows.Forms.NumericUpDown numericUpDown88 = this.numAutoChat;
			int[] array88 = new int[4];
			array88[0] = 5;
			numericUpDown88.Minimum = new decimal(array88);
			this.numAutoChat.Name = "numAutoChat";
			global::System.Windows.Forms.NumericUpDown numericUpDown89 = this.numAutoChat;
			int[] array89 = new int[4];
			array89[0] = 192;
			numericUpDown89.Value = new decimal(array89);
			this.numAutoChat.ValueChanged += new global::System.EventHandler(this.numAutoChat_ValueChanged);
			this.numAutoChat.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numAutoChat_KeyPress);
			componentResourceManager.ApplyResources(this.cboxChatSavedMsg, "cboxChatSavedMsg");
			this.cboxChatSavedMsg.Checked = true;
			this.cboxChatSavedMsg.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxChatSavedMsg.Name = "cboxChatSavedMsg";
			this.cboxChatSavedMsg.UseVisualStyleBackColor = true;
			this.cboxChatSavedMsg.CheckedChanged += new global::System.EventHandler(this.cboxChatSavedMsg_CheckedChanged);
			this.btnChatDelete.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnChatDelete.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnChatDelete, "btnChatDelete");
			this.btnChatDelete.Name = "btnChatDelete";
			this.btnChatDelete.UseVisualStyleBackColor = false;
			this.btnChatDelete.Click += new global::System.EventHandler(this.btnChatDelete_Click);
			this.btnChatRecord.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnChatRecord.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnChatRecord, "btnChatRecord");
			this.btnChatRecord.Name = "btnChatRecord";
			this.btnChatRecord.UseVisualStyleBackColor = false;
			this.btnChatRecord.Click += new global::System.EventHandler(this.btnChatRecord_Click);
			componentResourceManager.ApplyResources(this.label3, "label3");
			this.label3.Name = "label3";
			componentResourceManager.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			this.btnChatExpand.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnChatExpand, "btnChatExpand");
			this.btnChatExpand.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnChatExpand.Name = "btnChatExpand";
			this.btnChatExpand.UseVisualStyleBackColor = false;
			this.btnChatExpand.Click += new global::System.EventHandler(this.btnChatExpand_Click);
			componentResourceManager.ApplyResources(this.lblNextChat, "lblNextChat");
			this.lblNextChat.Name = "lblNextChat";
			componentResourceManager.ApplyResources(this.lbChatTimes, "lbChatTimes");
			this.lbChatTimes.Name = "lbChatTimes";
			componentResourceManager.ApplyResources(this.cboxAutoChat, "cboxAutoChat");
			this.cboxAutoChat.Name = "cboxAutoChat";
			this.cboxAutoChat.UseVisualStyleBackColor = true;
			this.cboxAutoChat.CheckedChanged += new global::System.EventHandler(this.cboxAutoChat_CheckedChanged);
			this.btnSendChat.BackColor = global::System.Drawing.Color.FromArgb(210, 249, 213);
			this.btnSendChat.ForeColor = global::System.Drawing.Color.DarkGreen;
			componentResourceManager.ApplyResources(this.btnSendChat, "btnSendChat");
			this.btnSendChat.Name = "btnSendChat";
			this.btnSendChat.UseVisualStyleBackColor = false;
			this.btnSendChat.Click += new global::System.EventHandler(this.btnSendChat_Click);
			componentResourceManager.ApplyResources(this.cboxHelpChat, "cboxHelpChat");
			this.cboxHelpChat.Checked = true;
			this.cboxHelpChat.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxHelpChat.Name = "cboxHelpChat";
			this.cboxHelpChat.UseVisualStyleBackColor = true;
			this.cboxHelpChat.CheckedChanged += new global::System.EventHandler(this.cboxHelpChat_CheckedChanged);
			this.cboKenhChat.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.cboKenhChat, "cboKenhChat");
			this.cboKenhChat.FormattingEnabled = true;
			this.cboKenhChat.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboKenhChat.Items"),
				componentResourceManager.GetString("cboKenhChat.Items1"),
				componentResourceManager.GetString("cboKenhChat.Items2"),
				componentResourceManager.GetString("cboKenhChat.Items3")
			});
			this.cboKenhChat.Name = "cboKenhChat";
			this.cboKenhChat.SelectedIndexChanged += new global::System.EventHandler(this.cboKenhChat_SelectedIndexChanged);
			this.richChat.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			componentResourceManager.ApplyResources(this.richChat, "richChat");
			this.richChat.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.richChat.Name = "richChat";
			this.richChat.TextChanged += new global::System.EventHandler(this.richChat_TextChanged);
			this.tabDebug.Controls.Add(this.lvQuai);
			this.tabDebug.Controls.Add(this.lblTotalQuai);
			this.tabDebug.Controls.Add(this.lblDebugInfo);
			componentResourceManager.ApplyResources(this.tabDebug, "tabDebug");
			this.tabDebug.Name = "tabDebug";
			this.tabDebug.UseVisualStyleBackColor = true;
			this.lvQuai.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvQuai.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvQuai.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_8,
				this.columnHeader_9,
				this.columnHeader_10,
				this.columnHeader_11,
				this.columnHeader_12,
				this.columnHeader_13,
				this.columnHeader_34
			});
			this.lvQuai.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvQuai.FullRowSelect = true;
			this.lvQuai.GridLines = true;
			this.lvQuai.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvQuai.HideSelection = false;
			componentResourceManager.ApplyResources(this.lvQuai, "lvQuai");
			this.lvQuai.Name = "lvQuai";
			this.lvQuai.UseCompatibleStateImageBehavior = false;
			this.lvQuai.View = global::System.Windows.Forms.View.Details;
			componentResourceManager.ApplyResources(this.columnHeader_8, "columnHeader5");
			componentResourceManager.ApplyResources(this.columnHeader_9, "columnHeader6");
			componentResourceManager.ApplyResources(this.columnHeader_10, "columnHeader7");
			componentResourceManager.ApplyResources(this.columnHeader_11, "columnHeader8");
			componentResourceManager.ApplyResources(this.columnHeader_12, "columnHeader9");
			componentResourceManager.ApplyResources(this.columnHeader_13, "columnHeader10");
			componentResourceManager.ApplyResources(this.columnHeader_34, "columnHeader1");
			componentResourceManager.ApplyResources(this.lblTotalQuai, "lblTotalQuai");
			this.lblTotalQuai.Name = "lblTotalQuai";
			componentResourceManager.ApplyResources(this.lblDebugInfo, "lblDebugInfo");
			this.lblDebugInfo.ForeColor = global::System.Drawing.Color.Maroon;
			this.lblDebugInfo.Name = "lblDebugInfo";
			this.tabDebugBoc.Controls.Add(this.lvItems);
			this.tabDebugBoc.Controls.Add(this.lblTotalBoc);
			this.tabDebugBoc.Controls.Add(this.lblItems);
			this.tabDebugBoc.Controls.Add(this.lblActiveBocID);
			this.tabDebugBoc.Controls.Add(this.lvAllBoc);
			componentResourceManager.ApplyResources(this.tabDebugBoc, "tabDebugBoc");
			this.tabDebugBoc.Name = "tabDebugBoc";
			this.tabDebugBoc.UseVisualStyleBackColor = true;
			this.lvItems.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvItems.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvItems.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_14,
				this.columnHeader_15,
				this.columnHeader_16,
				this.columnHeader_17
			});
			this.lvItems.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvItems.FullRowSelect = true;
			this.lvItems.GridLines = true;
			this.lvItems.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvItems.HideSelection = false;
			componentResourceManager.ApplyResources(this.lvItems, "lvItems");
			this.lvItems.Name = "lvItems";
			this.lvItems.UseCompatibleStateImageBehavior = false;
			this.lvItems.View = global::System.Windows.Forms.View.Details;
			componentResourceManager.ApplyResources(this.columnHeader_14, "columnHeader17");
			componentResourceManager.ApplyResources(this.columnHeader_15, "columnHeader18");
			componentResourceManager.ApplyResources(this.columnHeader_16, "columnHeader19");
			componentResourceManager.ApplyResources(this.columnHeader_17, "columnHeader20");
			componentResourceManager.ApplyResources(this.lblTotalBoc, "lblTotalBoc");
			this.lblTotalBoc.Name = "lblTotalBoc";
			componentResourceManager.ApplyResources(this.lblItems, "lblItems");
			this.lblItems.Name = "lblItems";
			this.lblItems.Click += new global::System.EventHandler(this.lblItems_Click);
			componentResourceManager.ApplyResources(this.lblActiveBocID, "lblActiveBocID");
			this.lblActiveBocID.Name = "lblActiveBocID";
			this.lvAllBoc.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvAllBoc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvAllBoc.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_18,
				this.columnHeader_19,
				this.columnHeader_20,
				this.columnHeader_21,
				this.columnHeader_22
			});
			this.lvAllBoc.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvAllBoc.FullRowSelect = true;
			this.lvAllBoc.GridLines = true;
			this.lvAllBoc.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvAllBoc.HideSelection = false;
			componentResourceManager.ApplyResources(this.lvAllBoc, "lvAllBoc");
			this.lvAllBoc.Name = "lvAllBoc";
			this.lvAllBoc.UseCompatibleStateImageBehavior = false;
			this.lvAllBoc.View = global::System.Windows.Forms.View.Details;
			componentResourceManager.ApplyResources(this.columnHeader_18, "columnHeader11");
			componentResourceManager.ApplyResources(this.columnHeader_19, "columnHeader13");
			componentResourceManager.ApplyResources(this.columnHeader_20, "columnHeader14");
			componentResourceManager.ApplyResources(this.columnHeader_21, "columnHeader15");
			componentResourceManager.ApplyResources(this.columnHeader_22, "columnHeader12");
			this.tabPhat.Controls.Add(this.groupPhat);
			componentResourceManager.ApplyResources(this.tabPhat, "tabPhat");
			this.tabPhat.Name = "tabPhat";
			this.tabPhat.UseVisualStyleBackColor = true;
			this.groupPhat.Controls.Add(this.tbXorString);
			this.groupPhat.Controls.Add(this.btnXorString);
			this.groupPhat.Controls.Add(this.lbTimeOnlineTest);
			this.groupPhat.Controls.Add(this.checkBox1);
			this.groupPhat.Controls.Add(this.comboBox5);
			this.groupPhat.Controls.Add(this.cboxDebugLog);
			this.groupPhat.Controls.Add(this.button2);
			this.groupPhat.Controls.Add(this.button4);
			this.groupPhat.Controls.Add(this.cboxPhatTest2);
			this.groupPhat.Controls.Add(this.cboxTNRunOnly);
			this.groupPhat.Controls.Add(this.btnPhatTest2);
			this.groupPhat.Controls.Add(this.btnSearchNPC);
			this.groupPhat.Controls.Add(this.cboxPhatTest3);
			this.groupPhat.Controls.Add(this.cboxATAB);
			this.groupPhat.Controls.Add(this.btnPhatTest3);
			this.groupPhat.Controls.Add(this.cboxKhoangDuoc);
			this.groupPhat.Controls.Add(this.btnResetKhoangDuoc);
			componentResourceManager.ApplyResources(this.groupPhat, "groupPhat");
			this.groupPhat.Name = "groupPhat";
			this.groupPhat.TabStop = false;
			componentResourceManager.ApplyResources(this.tbXorString, "tbXorString");
			this.tbXorString.Name = "tbXorString";
			componentResourceManager.ApplyResources(this.btnXorString, "btnXorString");
			this.btnXorString.Name = "btnXorString";
			this.btnXorString.UseVisualStyleBackColor = true;
			this.btnXorString.Click += new global::System.EventHandler(this.btnXorString_Click);
			componentResourceManager.ApplyResources(this.lbTimeOnlineTest, "lbTimeOnlineTest");
			this.lbTimeOnlineTest.Name = "lbTimeOnlineTest";
			componentResourceManager.ApplyResources(this.checkBox1, "checkBox1");
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			componentResourceManager.ApplyResources(this.comboBox5, "comboBox5");
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("comboBox5.Items"),
				componentResourceManager.GetString("comboBox5.Items1"),
				componentResourceManager.GetString("comboBox5.Items2"),
				componentResourceManager.GetString("comboBox5.Items3"),
				componentResourceManager.GetString("comboBox5.Items4"),
				componentResourceManager.GetString("comboBox5.Items5"),
				componentResourceManager.GetString("comboBox5.Items6")
			});
			this.comboBox5.Name = "comboBox5";
			componentResourceManager.ApplyResources(this.cboxDebugLog, "cboxDebugLog");
			this.cboxDebugLog.Name = "cboxDebugLog";
			this.cboxDebugLog.UseVisualStyleBackColor = true;
			this.cboxDebugLog.CheckedChanged += new global::System.EventHandler(this.cboxDebugLog_CheckedChanged);
			componentResourceManager.ApplyResources(this.button2, "button2");
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			componentResourceManager.ApplyResources(this.button4, "button4");
			this.button4.Name = "button4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			componentResourceManager.ApplyResources(this.cboxPhatTest2, "cboxPhatTest2");
			this.cboxPhatTest2.FormattingEnabled = true;
			this.cboxPhatTest2.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboxPhatTest2.Items"),
				componentResourceManager.GetString("cboxPhatTest2.Items1"),
				componentResourceManager.GetString("cboxPhatTest2.Items2"),
				componentResourceManager.GetString("cboxPhatTest2.Items3"),
				componentResourceManager.GetString("cboxPhatTest2.Items4"),
				componentResourceManager.GetString("cboxPhatTest2.Items5"),
				componentResourceManager.GetString("cboxPhatTest2.Items6")
			});
			this.cboxPhatTest2.Name = "cboxPhatTest2";
			componentResourceManager.ApplyResources(this.cboxTNRunOnly, "cboxTNRunOnly");
			this.cboxTNRunOnly.Name = "cboxTNRunOnly";
			this.cboxTNRunOnly.UseVisualStyleBackColor = true;
			this.cboxTNRunOnly.CheckedChanged += new global::System.EventHandler(this.cboxTNRunOnly_CheckedChanged);
			componentResourceManager.ApplyResources(this.btnPhatTest2, "btnPhatTest2");
			this.btnPhatTest2.Name = "btnPhatTest2";
			this.btnPhatTest2.UseVisualStyleBackColor = true;
			this.btnPhatTest2.Click += new global::System.EventHandler(this.btnPhatTest2_Click);
			componentResourceManager.ApplyResources(this.btnSearchNPC, "btnSearchNPC");
			this.btnSearchNPC.Name = "btnSearchNPC";
			this.btnSearchNPC.UseVisualStyleBackColor = true;
			this.btnSearchNPC.Click += new global::System.EventHandler(this.btnSearchNPC_Click);
			componentResourceManager.ApplyResources(this.cboxPhatTest3, "cboxPhatTest3");
			this.cboxPhatTest3.FormattingEnabled = true;
			this.cboxPhatTest3.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cboxPhatTest3.Items"),
				componentResourceManager.GetString("cboxPhatTest3.Items1"),
				componentResourceManager.GetString("cboxPhatTest3.Items2"),
				componentResourceManager.GetString("cboxPhatTest3.Items3"),
				componentResourceManager.GetString("cboxPhatTest3.Items4"),
				componentResourceManager.GetString("cboxPhatTest3.Items5"),
				componentResourceManager.GetString("cboxPhatTest3.Items6")
			});
			this.cboxPhatTest3.Name = "cboxPhatTest3";
			componentResourceManager.ApplyResources(this.cboxATAB, "cboxATAB");
			this.cboxATAB.Name = "cboxATAB";
			this.cboxATAB.UseVisualStyleBackColor = true;
			this.cboxATAB.CheckedChanged += new global::System.EventHandler(this.cboxATAB_CheckedChanged);
			componentResourceManager.ApplyResources(this.btnPhatTest3, "btnPhatTest3");
			this.btnPhatTest3.Name = "btnPhatTest3";
			this.btnPhatTest3.UseVisualStyleBackColor = true;
			this.btnPhatTest3.Click += new global::System.EventHandler(this.btnPhatTest3_Click);
			componentResourceManager.ApplyResources(this.cboxKhoangDuoc, "cboxKhoangDuoc");
			this.cboxKhoangDuoc.Name = "cboxKhoangDuoc";
			this.cboxKhoangDuoc.UseVisualStyleBackColor = true;
			this.cboxKhoangDuoc.CheckedChanged += new global::System.EventHandler(this.cboxKhoangDuoc_CheckedChanged);
			componentResourceManager.ApplyResources(this.btnResetKhoangDuoc, "btnResetKhoangDuoc");
			this.btnResetKhoangDuoc.Name = "btnResetKhoangDuoc";
			this.btnResetKhoangDuoc.UseVisualStyleBackColor = true;
			this.btnResetKhoangDuoc.Click += new global::System.EventHandler(this.btnResetKhoangDuoc_Click);
			this.AIModes.BackColor = global::System.Drawing.Color.MistyRose;
			componentResourceManager.ApplyResources(this.AIModes, "AIModes");
			this.AIModes.ForeColor = global::System.Drawing.Color.Maroon;
			this.AIModes.FormattingEnabled = true;
			this.AIModes.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("AIModes.Items"),
				componentResourceManager.GetString("AIModes.Items1"),
				componentResourceManager.GetString("AIModes.Items2"),
				componentResourceManager.GetString("AIModes.Items3"),
				componentResourceManager.GetString("AIModes.Items4"),
				componentResourceManager.GetString("AIModes.Items5"),
				componentResourceManager.GetString("AIModes.Items6"),
				componentResourceManager.GetString("AIModes.Items7")
			});
			this.AIModes.Name = "AIModes";
			this.AIModes.SelectedIndexChanged += new global::System.EventHandler(this.AIModes_SelectedIndexChanged);
			this.btnMoiDoi.BackColor = global::System.Drawing.Color.Violet;
			this.btnMoiDoi.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnMoiDoi, "btnMoiDoi");
			this.btnMoiDoi.Name = "btnMoiDoi";
			this.btnMoiDoi.UseVisualStyleBackColor = false;
			this.btnMoiDoi.Click += new global::System.EventHandler(this.btnMoiDoi_Click);
			this.btnTrieuTap.BackColor = global::System.Drawing.Color.Violet;
			this.btnTrieuTap.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnTrieuTap, "btnTrieuTap");
			this.btnTrieuTap.Name = "btnTrieuTap";
			this.btnTrieuTap.UseVisualStyleBackColor = false;
			this.btnTrieuTap.Click += new global::System.EventHandler(this.btnTrieuTap_Click);
			this.numGroupID.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numGroupID, "numGroupID");
			global::System.Windows.Forms.NumericUpDown numericUpDown90 = this.numGroupID;
			int[] array90 = new int[4];
			array90[0] = 1000;
			numericUpDown90.Maximum = new decimal(array90);
			global::System.Windows.Forms.NumericUpDown numericUpDown91 = this.numGroupID;
			int[] array91 = new int[4];
			array91[0] = 1;
			numericUpDown91.Minimum = new decimal(array91);
			this.numGroupID.Name = "numGroupID";
			global::System.Windows.Forms.NumericUpDown numericUpDown92 = this.numGroupID;
			int[] array92 = new int[4];
			array92[0] = 4;
			numericUpDown92.Value = new decimal(array92);
			this.numGroupID.ValueChanged += new global::System.EventHandler(this.numGroupID_ValueChanged);
			this.numGroupID.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.numGroupID_KeyPress);
			componentResourceManager.ApplyResources(this.label35, "label35");
			this.label35.Name = "label35";
			this.label35.Click += new global::System.EventHandler(this.label35_Click);
			componentResourceManager.ApplyResources(this.mnuMain, "mnuMain");
			this.mnuMain.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.itemSystem,
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_24,
				this.toolStripMenuItem_34,
				this.itemHelp
			});
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Stretch = false;
			this.itemSystem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.itemUserInfo,
				this.itemRenew,
				this.toolStripMenuItem_39,
				this.buyHoursBlockToolStripMenuItem,
				this.itemSysSep2,
				this.toolStripMenuItem_38,
				this.toolStripMenuItem_80,
				this.toolStripMenuItem_20,
				this.toolStripMenuItem_23,
				this.toolStripMenuItem_28,
				this.toolStripMenuItem9,
				this.itemExit
			});
			this.itemSystem.Name = "itemSystem";
			componentResourceManager.ApplyResources(this.itemSystem, "itemSystem");
			this.itemSystem.DropDownOpened += new global::System.EventHandler(this.itemSystem_DropDownOpened);
			this.itemSystem.Click += new global::System.EventHandler(this.itemSystem_Click);
			this.itemUserInfo.Name = "itemUserInfo";
			componentResourceManager.ApplyResources(this.itemUserInfo, "itemUserInfo");
			this.itemUserInfo.Click += new global::System.EventHandler(this.itemUserInfo_Click);
			this.itemRenew.Name = "itemRenew";
			componentResourceManager.ApplyResources(this.itemRenew, "itemRenew");
			this.itemRenew.Click += new global::System.EventHandler(this.itemRenew_Click);
			this.toolStripMenuItem_39.Name = "kíchHoạtThẻTặngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_39, "kíchHoạtThẻTặngToolStripMenuItem");
			this.toolStripMenuItem_39.Click += new global::System.EventHandler(this.toolStripMenuItem_39_Click);
			this.buyHoursBlockToolStripMenuItem.Name = "buyHoursBlockToolStripMenuItem";
			componentResourceManager.ApplyResources(this.buyHoursBlockToolStripMenuItem, "buyHoursBlockToolStripMenuItem");
			this.buyHoursBlockToolStripMenuItem.Click += new global::System.EventHandler(this.buyHoursBlockToolStripMenuItem_Click);
			this.itemSysSep2.Name = "itemSysSep2";
			componentResourceManager.ApplyResources(this.itemSysSep2, "itemSysSep2");
			this.toolStripMenuItem_38.Name = "nhậnGameKhóGCafeToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_38, "nhậnGameKhóGCafeToolStripMenuItem");
			this.toolStripMenuItem_38.Click += new global::System.EventHandler(this.toolStripMenuItem_38_Click);
			this.toolStripMenuItem_80.Name = "bậttắtLogHướngDẫnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_80, "bậttắtLogHướngDẫnToolStripMenuItem");
			this.toolStripMenuItem_80.Click += new global::System.EventHandler(this.toolStripMenuItem_80_Click);
			this.toolStripMenuItem_20.Checked = true;
			this.toolStripMenuItem_20.CheckState = global::System.Windows.Forms.CheckState.Checked;
			componentResourceManager.ApplyResources(this.toolStripMenuItem_20, "bậttắtHộpThôngBáoToolStripMenuItem");
			this.toolStripMenuItem_20.Name = "bậttắtHộpThôngBáoToolStripMenuItem";
			this.toolStripMenuItem_20.Click += new global::System.EventHandler(this.toolStripMenuItem_20_Click);
			this.toolStripMenuItem_23.Name = "resetAutokhiGặpLỗiLạToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_23, "resetAutokhiGặpLỗiLạToolStripMenuItem");
			this.toolStripMenuItem_23.Click += new global::System.EventHandler(this.toolStripMenuItem_23_Click);
			this.toolStripMenuItem_28.Checked = true;
			this.toolStripMenuItem_28.CheckState = global::System.Windows.Forms.CheckState.Checked;
			componentResourceManager.ApplyResources(this.toolStripMenuItem_28, "nhậnGameMớiToolStripMenuItem");
			this.toolStripMenuItem_28.Name = "nhậnGameMớiToolStripMenuItem";
			this.toolStripMenuItem_28.Click += new global::System.EventHandler(this.toolStripMenuItem_28_Click);
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			componentResourceManager.ApplyResources(this.toolStripMenuItem9, "toolStripMenuItem9");
			this.itemExit.Name = "itemExit";
			componentResourceManager.ApplyResources(this.itemExit, "itemExit");
			this.itemExit.Click += new global::System.EventHandler(this.itemExit_Click);
			this.toolStripMenuItem_3.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_4,
				this.toolStripMenuItem_22,
				this.toolStripMenuItem_69,
				this.toolStripMenuItem10,
				this.toolStripMenuItem_18,
				this.toolStripMenuItem_17,
				this.toolStripMenuItem11,
				this.toolStripMenuItem_15,
				this.toolStripMenuItem2,
				this.toolStripMenuItem_13,
				this.thuGToolStripMenuItem,
				this.toolStripMenuItem_19
			});
			this.toolStripMenuItem_3.Name = "côngCụToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_3, "côngCụToolStripMenuItem");
			this.toolStripMenuItem_3.DropDownOpened += new global::System.EventHandler(this.toolStripMenuItem_3_DropDownOpened);
			this.toolStripMenuItem_4.Name = "mởThêmgameToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_4, "mởThêmgameToolStripMenuItem");
			this.toolStripMenuItem_4.Click += new global::System.EventHandler(this.toolStripMenuItem_4_Click);
			this.toolStripMenuItem_22.Name = "mởThêmNhiềuGameToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_22, "mởThêmNhiềuGameToolStripMenuItem");
			this.toolStripMenuItem_22.Click += new global::System.EventHandler(this.toolStripMenuItem_22_Click);
			this.toolStripMenuItem_69.Name = "chọnĐườngDẫnGameexeToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_69, "chọnĐườngDẫnGameexeToolStripMenuItem");
			this.toolStripMenuItem_69.Click += new global::System.EventHandler(this.toolStripMenuItem_69_Click);
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			componentResourceManager.ApplyResources(this.toolStripMenuItem10, "toolStripMenuItem10");
			this.toolStripMenuItem_18.Name = "ẩnAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_18, "ẩnAutoToolStripMenuItem");
			this.toolStripMenuItem_18.Click += new global::System.EventHandler(this.toolStripMenuItem_18_Click);
			this.toolStripMenuItem_17.Name = "ẩnHiệnDanhHiệuToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_17, "ẩnHiệnDanhHiệuToolStripMenuItem");
			this.toolStripMenuItem_17.Click += new global::System.EventHandler(this.toolStripMenuItem_17_Click);
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			componentResourceManager.ApplyResources(this.toolStripMenuItem11, "toolStripMenuItem11");
			this.toolStripMenuItem_15.Checked = true;
			this.toolStripMenuItem_15.CheckState = global::System.Windows.Forms.CheckState.Checked;
			componentResourceManager.ApplyResources(this.toolStripMenuItem_15, "dựĐoánTốcĐộTrainToolStripMenuItem");
			this.toolStripMenuItem_15.Name = "dựĐoánTốcĐộTrainToolStripMenuItem";
			this.toolStripMenuItem_15.Click += new global::System.EventHandler(this.toolStripMenuItem_15_Click);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			componentResourceManager.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
			this.toolStripMenuItem_13.Name = "tắtMáyKhiThoátHếtGameToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_13, "tắtMáyKhiThoátHếtGameToolStripMenuItem");
			this.toolStripMenuItem_13.Click += new global::System.EventHandler(this.toolStripMenuItem_13_Click);
			this.thuGToolStripMenuItem.Name = "thuGToolStripMenuItem";
			componentResourceManager.ApplyResources(this.thuGToolStripMenuItem, "thuGToolStripMenuItem");
			this.thuGToolStripMenuItem.Click += new global::System.EventHandler(this.thuGToolStripMenuItem_Click);
			this.toolStripMenuItem_19.Name = "tựGomCủaSổAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_19, "tựGomCủaSổAutoToolStripMenuItem");
			this.toolStripMenuItem_19.Click += new global::System.EventHandler(this.toolStripMenuItem_19_Click);
			this.toolStripMenuItem_24.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_33,
				this.toolStripMenuItem12,
				this.toolStripMenuItem_25,
				this.toolStripMenuItem_26,
				this.toolStripMenuItem_27,
				this.toolStripMenuItem_29,
				this.toolStripMenuItem_30,
				this.toolStripMenuItem_31,
				this.toolStripMenuItem_41,
				this.toolStripMenuItem18,
				this.toolStripMenuItem_36,
				this.toolStripMenuItem_37,
				this.autoPKToolStripMenuItem,
				this.toolStripMenuItem_76,
				this.toolStripMenuItem_86,
				this.toolStripMenuItem_96,
				this.toolStripMenuItem_97,
				this.toolStripMenuItem_101,
				this.toolStripMenuItem_100,
				this.toolStripMenuItem_102,
				this.toolStripMenuItem_121,
				this.toolStripMenuItem_189,
				this.testGameToolStripMenuItem,
				this.toolStripMenuItem_161
			});
			this.toolStripMenuItem_24.Name = "thiếtLậpToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_24, "thiếtLậpToolStripMenuItem");
			this.toolStripMenuItem_24.DropDownOpened += new global::System.EventHandler(this.toolStripMenuItem_24_DropDownOpened);
			this.toolStripMenuItem_33.Name = "phímTắtToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_33, "phímTắtToolStripMenuItem1");
			this.toolStripMenuItem_33.Click += new global::System.EventHandler(this.toolStripMenuItem_33_Click);
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			componentResourceManager.ApplyResources(this.toolStripMenuItem12, "toolStripMenuItem12");
			this.toolStripMenuItem_25.Name = "dùngKinhMạchNghịchHànhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_25, "dùngKinhMạchNghịchHànhToolStripMenuItem");
			this.toolStripMenuItem_25.Click += new global::System.EventHandler(this.toolStripMenuItem_25_Click);
			this.toolStripMenuItem_26.Name = "phụBảnKéoĐộiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_26, "phụBảnKéoĐộiToolStripMenuItem");
			this.toolStripMenuItem_26.Click += new global::System.EventHandler(this.toolStripMenuItem_26_Click);
			this.toolStripMenuItem_27.Name = "sửDụngSkillF1ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_27, "sửDụngSkillF1ToolStripMenuItem");
			this.toolStripMenuItem_27.Click += new global::System.EventHandler(this.toolStripMenuItem_27_Click);
			this.toolStripMenuItem_29.Name = "làmMớiPathpointsToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_29, "làmMớiPathpointsToolStripMenuItem");
			this.toolStripMenuItem_29.Click += new global::System.EventHandler(this.toolStripMenuItem_29_Click);
			this.toolStripMenuItem_30.Name = "xếpSkillTheoTênToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_30, "xếpSkillTheoTênToolStripMenuItem");
			this.toolStripMenuItem_30.Click += new global::System.EventHandler(this.toolStripMenuItem_30_Click);
			this.toolStripMenuItem_31.Name = "khôngDùngNgựaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_31, "khôngDùngNgựaToolStripMenuItem");
			this.toolStripMenuItem_31.Click += new global::System.EventHandler(this.toolStripMenuItem_31_Click);
			this.toolStripMenuItem_41.Name = "timeẨnGameToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_41, "timeẨnGameToolStripMenuItem");
			this.toolStripMenuItem_41.Click += new global::System.EventHandler(this.toolStripMenuItem_41_Click);
			this.toolStripMenuItem18.Name = "toolStripMenuItem18";
			componentResourceManager.ApplyResources(this.toolStripMenuItem18, "toolStripMenuItem18");
			this.toolStripMenuItem_36.Name = "chốngLagKhiĐánhSkillToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_36, "chốngLagKhiĐánhSkillToolStripMenuItem");
			this.toolStripMenuItem_36.Click += new global::System.EventHandler(this.toolStripMenuItem_36_Click);
			this.toolStripMenuItem_37.Name = "đổiMụcTiêuNhanhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_37, "đổiMụcTiêuNhanhToolStripMenuItem");
			this.toolStripMenuItem_37.Click += new global::System.EventHandler(this.toolStripMenuItem_37_Click);
			this.autoPKToolStripMenuItem.Name = "autoPKToolStripMenuItem";
			componentResourceManager.ApplyResources(this.autoPKToolStripMenuItem, "autoPKToolStripMenuItem");
			this.autoPKToolStripMenuItem.Click += new global::System.EventHandler(this.autoPKToolStripMenuItem_Click);
			this.toolStripMenuItem_76.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_77,
				this.toolStripMenuItem_78
			});
			this.toolStripMenuItem_76.Name = "báoChatMậtToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_76, "báoChatMậtToolStripMenuItem");
			this.toolStripMenuItem_76.Click += new global::System.EventHandler(this.toolStripMenuItem_76_Click);
			this.toolStripMenuItem_77.Name = "bậtTấtCảToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_77, "bậtTấtCảToolStripMenuItem");
			this.toolStripMenuItem_77.Click += new global::System.EventHandler(this.toolStripMenuItem_77_Click);
			this.toolStripMenuItem_78.Name = "tắtTấtCảToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_78, "tắtTấtCảToolStripMenuItem");
			this.toolStripMenuItem_78.Click += new global::System.EventHandler(this.toolStripMenuItem_78_Click);
			this.toolStripMenuItem_86.Name = "làmNhẹAutotăngDelayToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_86, "làmNhẹAutotăngDelayToolStripMenuItem");
			this.toolStripMenuItem_86.Click += new global::System.EventHandler(this.toolStripMenuItem_86_Click);
			this.toolStripMenuItem_96.Name = "tựĐồngÝPhùTổĐộiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_96, "tựĐồngÝPhùTổĐộiToolStripMenuItem");
			this.toolStripMenuItem_96.Click += new global::System.EventHandler(this.toolStripMenuItem_96_Click);
			this.toolStripMenuItem_97.Name = "tựKếtNốiLạiSau5sToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_97, "tựKếtNốiLạiSau5sToolStripMenuItem");
			this.toolStripMenuItem_97.Click += new global::System.EventHandler(this.toolStripMenuItem_97_Click);
			this.toolStripMenuItem_101.Name = "thoátGameKhiBịDis3pToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_101, "thoátGameKhiBịDis3pToolStripMenuItem");
			this.toolStripMenuItem_101.Click += new global::System.EventHandler(this.toolStripMenuItem_101_Click);
			this.toolStripMenuItem_100.Name = "tựMuaCànKhônHồToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_100, "tựMuaCànKhônHồToolStripMenuItem");
			this.toolStripMenuItem_100.Click += new global::System.EventHandler(this.toolStripMenuItem_100_Click);
			this.toolStripMenuItem_102.Name = "fixLỗiCưỡngChếVNGToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_102, "fixLỗiCưỡngChếVNGToolStripMenuItem");
			this.toolStripMenuItem_102.Click += new global::System.EventHandler(this.toolStripMenuItem_102_Click);
			this.toolStripMenuItem_121.Name = "tựBấmĐồngÝChuyểnCảnhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_121, "tựBấmĐồngÝChuyểnCảnhToolStripMenuItem");
			this.toolStripMenuItem_121.Click += new global::System.EventHandler(this.toolStripMenuItem_121_Click);
			this.toolStripMenuItem_189.Name = "lênMônPháiDùngTLCToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_189, "lênMônPháiDùngTLCToolStripMenuItem");
			this.toolStripMenuItem_189.Click += new global::System.EventHandler(this.toolStripMenuItem_189_Click);
			this.testGameToolStripMenuItem.Name = "testGameToolStripMenuItem";
			componentResourceManager.ApplyResources(this.testGameToolStripMenuItem, "testGameToolStripMenuItem");
			this.testGameToolStripMenuItem.Click += new global::System.EventHandler(this.testGameToolStripMenuItem_Click);
			this.toolStripMenuItem_161.Name = "testBánĐồToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_161, "testBánĐồToolStripMenuItem");
			this.toolStripMenuItem_161.Click += new global::System.EventHandler(this.toolStripMenuItem_161_Click);
			this.toolStripMenuItem_34.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_35,
				this.toolStripMenuItem13
			});
			this.toolStripMenuItem_34.Name = "tựĐăngNhậpToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_34, "tựĐăngNhậpToolStripMenuItem");
			this.toolStripMenuItem_34.DropDownOpened += new global::System.EventHandler(this.toolStripMenuItem_34_DropDownOpened);
			this.toolStripMenuItem_34.Click += new global::System.EventHandler(this.toolStripMenuItem_34_Click);
			this.toolStripMenuItem_35.Name = "quảnLýProfileToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_35, "quảnLýProfileToolStripMenuItem");
			this.toolStripMenuItem_35.Click += new global::System.EventHandler(this.toolStripMenuItem_35_Click);
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			componentResourceManager.ApplyResources(this.toolStripMenuItem13, "toolStripMenuItem13");
			this.itemHelp.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.facebookFanpageToolStripMenuItem,
				this.toolStripMenuItem_11,
				this.toolStripSeparator4,
				this.toolStripMenuItem_1,
				this.toolStripSeparator3,
				this.toolStripMenuItem_2,
				this.toolStripMenuItem3,
				this.toolStripMenuItem_14,
				this.toolStripMenuItem_32,
				this.toolStripMenuItem_68,
				this.toolStripMenuItem_83
			});
			this.itemHelp.Name = "itemHelp";
			componentResourceManager.ApplyResources(this.itemHelp, "itemHelp");
			this.itemHelp.DropDownOpened += new global::System.EventHandler(this.itemHelp_DropDownOpened);
			this.toolStripMenuItem_0.Name = "trangChủToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_0, "trangChủToolStripMenuItem");
			this.toolStripMenuItem_0.Click += new global::System.EventHandler(this.toolStripMenuItem_0_Click);
			this.facebookFanpageToolStripMenuItem.Name = "facebookFanpageToolStripMenuItem";
			componentResourceManager.ApplyResources(this.facebookFanpageToolStripMenuItem, "facebookFanpageToolStripMenuItem");
			this.facebookFanpageToolStripMenuItem.Click += new global::System.EventHandler(this.facebookFanpageToolStripMenuItem_Click);
			this.toolStripMenuItem_11.Name = "diễnĐànGAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_11, "diễnĐànGAutoToolStripMenuItem");
			this.toolStripMenuItem_11.Click += new global::System.EventHandler(this.toolStripMenuItem_11_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			componentResourceManager.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
			this.toolStripMenuItem_1.Name = "hướngDẫnSửDụngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_1, "hướngDẫnSửDụngToolStripMenuItem");
			this.toolStripMenuItem_1.Click += new global::System.EventHandler(this.toolStripMenuItem_1_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			componentResourceManager.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
			this.toolStripMenuItem_2.Name = "vềChươngTrìnhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_2, "vềChươngTrìnhToolStripMenuItem");
			this.toolStripMenuItem_2.Click += new global::System.EventHandler(this.toolStripMenuItem_2_Click);
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			componentResourceManager.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
			this.toolStripMenuItem_14.Checked = true;
			this.toolStripMenuItem_14.CheckState = global::System.Windows.Forms.CheckState.Checked;
			componentResourceManager.ApplyResources(this.toolStripMenuItem_14, "hiệnẨnLogToolStripMenuItem");
			this.toolStripMenuItem_14.Name = "hiệnẨnLogToolStripMenuItem";
			this.toolStripMenuItem_14.Click += new global::System.EventHandler(this.toolStripMenuItem_14_Click);
			this.toolStripMenuItem_32.Name = "xóaBảngHashToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_32, "xóaBảngHashToolStripMenuItem");
			this.toolStripMenuItem_32.Click += new global::System.EventHandler(this.toolStripMenuItem_32_Click);
			this.toolStripMenuItem_68.Name = "xóaDanhSáchProcessToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_68, "xóaDanhSáchProcessToolStripMenuItem");
			this.toolStripMenuItem_68.Click += new global::System.EventHandler(this.toolStripMenuItem_68_Click);
			this.toolStripMenuItem_83.Name = "lưuGóiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_83, "lưuGóiToolStripMenuItem");
			this.toolStripMenuItem_83.Click += new global::System.EventHandler(this.toolStripMenuItem_83_Click);
			this.timer_0.Interval = 400;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.notifyIcon_0.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			componentResourceManager.ApplyResources(this.notifyIcon_0, "notifyIcon");
			this.notifyIcon_0.ContextMenuStrip = this.contextTray;
			this.notifyIcon_0.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon_0_MouseDoubleClick);
			this.contextTray.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.contextTray.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_16,
				this.toolStripMenuItem8,
				this.mnuTrayShutdownNoGame,
				this.toolStripMenuItem_6,
				this.toolStripMenuItem_99
			});
			this.contextTray.Name = "contextTray";
			componentResourceManager.ApplyResources(this.contextTray, "contextTray");
			this.toolStripMenuItem_5.Name = "hiệnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_5, "hiệnToolStripMenuItem");
			this.toolStripMenuItem_5.Click += new global::System.EventHandler(this.toolStripMenuItem_5_Click);
			this.toolStripMenuItem_16.Name = "mởThêmGameToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_16, "mởThêmGameToolStripMenuItem1");
			this.toolStripMenuItem_16.Click += new global::System.EventHandler(this.toolStripMenuItem_16_Click);
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			componentResourceManager.ApplyResources(this.toolStripMenuItem8, "toolStripMenuItem8");
			this.mnuTrayShutdownNoGame.Name = "mnuTrayShutdownNoGame";
			componentResourceManager.ApplyResources(this.mnuTrayShutdownNoGame, "mnuTrayShutdownNoGame");
			this.mnuTrayShutdownNoGame.Click += new global::System.EventHandler(this.mnuTrayShutdownNoGame_Click);
			this.toolStripMenuItem_6.Name = "thoátToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_6, "thoátToolStripMenuItem");
			this.toolStripMenuItem_6.Click += new global::System.EventHandler(this.toolStripMenuItem_6_Click);
			this.toolStripMenuItem_99.Name = "tắtÂmBáoĐộngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_99, "tắtÂmBáoĐộngToolStripMenuItem");
			this.toolStripMenuItem_99.Click += new global::System.EventHandler(this.toolStripMenuItem_99_Click);
			this.contextUserList.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.contextUserList.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_7,
				this.toolStripMenuItem_8,
				this.toolStripSeparator1,
				this.toolStripMenuItem_9
			});
			this.contextUserList.Name = "contextUserList";
			componentResourceManager.ApplyResources(this.contextUserList, "contextUserList");
			this.contextUserList.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextUserList_Opening);
			this.toolStripMenuItem_7.Name = "hiệnẨnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_7, "hiệnẨnToolStripMenuItem");
			this.toolStripMenuItem_8.Name = "thoátToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_8, "thoátToolStripMenuItem1");
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			componentResourceManager.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			this.toolStripMenuItem_9.Name = "triệuTậpĐồngĐộiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_9, "triệuTậpĐồngĐộiToolStripMenuItem");
			this.toolStripMenuItem_9.Click += new global::System.EventHandler(this.toolStripMenuItem_9_Click);
			this.contextProcessList.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.contextProcessList.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_42,
				this.toolStripMenuItem_129,
				this.toolStripMenuItem_45,
				this.toolStripMenuItem_133,
				this.toolStripMenuItem_173,
				this.toolStripMenuItem_184,
				this.toolStripMenuItem1,
				this.toolStripMenuItem_156,
				this.toolStripMenuItem_157,
				this.toolStripSeparator7,
				this.toolStripMenuItem_62,
				this.toolStripMenuItem_63,
				this.toolStripMenuItem_82,
				this.toolStripSeparator2,
				this.toolStripMenuItem_12,
				this.toolStripMenuItem_87,
				this.toolStripMenuItem_10,
				this.toolStripMenuItem_21,
				this.toolStripMenuItem_40,
				this.menuThoatGameNhanh,
				this.toolStripMenuItem_67,
				this.toolStripMenuItem5,
				this.toolStripMenuItem_166,
				this.toolStripMenuItem_162,
				this.toolStripMenuItem_163,
				this.toolStripMenuItem_164,
				this.toolStripMenuItem_165
			});
			this.contextProcessList.Name = "contextProcessList";
			componentResourceManager.ApplyResources(this.contextProcessList, "contextProcessList");
			this.contextProcessList.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextProcessList_Opening);
			this.toolStripMenuItem_42.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_44,
				this.toolStripMenuItem_70,
				this.toolStripMenuItem_64,
				this.toolStripMenuItem_152,
				this.toolStripMenuItem_43,
				this.toolStripMenuItem_49,
				this.toolStripMenuItem_50,
				this.toolStripMenuItem_52,
				this.toolStripMenuItem_53,
				this.toolStripMenuItem_54,
				this.toolStripMenuItem_55,
				this.toolStripMenuItem_84,
				this.lV2840ToolStripMenuItem,
				this.toolStripMenuItem_51,
				this.toolStripMenuItem_56,
				this.toolStripMenuItem_57,
				this.toolStripMenuItem_58,
				this.toolStripMenuItem_79,
				this.toolStripMenuItem_132,
				this.toolStripMenuItem_170
			});
			this.toolStripMenuItem_42.Name = "nhiệmVụToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_42, "nhiệmVụToolStripMenuItem");
			this.toolStripMenuItem_44.Name = "dừngNhiệmVụToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_44, "dừngNhiệmVụToolStripMenuItem");
			this.toolStripMenuItem_44.Click += new global::System.EventHandler(this.toolStripMenuItem_44_Click);
			this.toolStripMenuItem_70.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_71,
				this.toolStripMenuItem_73,
				this.toolStripMenuItem_74,
				this.toolStripMenuItem_72,
				this.toolStripSeparator8,
				this.toolStripMenuItem_158
			});
			this.toolStripMenuItem_70.Name = "hàngNgàyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_70, "hàngNgàyToolStripMenuItem");
			this.toolStripMenuItem_71.Name = "thửTàiVậnMayToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_71, "thửTàiVậnMayToolStripMenuItem1");
			this.toolStripMenuItem_71.Click += new global::System.EventHandler(this.toolStripMenuItem_71_Click);
			this.toolStripMenuItem_73.Name = "ngũHànhPhápThiệpToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_73, "ngũHànhPhápThiệpToolStripMenuItem");
			this.toolStripMenuItem_73.Click += new global::System.EventHandler(this.toolStripMenuItem_73_Click);
			this.toolStripMenuItem_74.Name = "lòLyHỏaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_74, "lòLyHỏaToolStripMenuItem");
			this.toolStripMenuItem_74.Click += new global::System.EventHandler(this.toolStripMenuItem_74_Click);
			this.toolStripMenuItem_72.Name = "thiênLongTuếHồngToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_72, "thiênLongTuếHồngToolStripMenuItem1");
			this.toolStripMenuItem_72.Click += new global::System.EventHandler(this.toolStripMenuItem_72_Click);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			componentResourceManager.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
			this.toolStripMenuItem_158.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_159,
				this.toolStripMenuItem_160
			});
			this.toolStripMenuItem_158.Name = "tựNốiNhiệmVụToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_158, "tựNốiNhiệmVụToolStripMenuItem");
			this.toolStripMenuItem_159.Name = "bậtToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_159, "bậtToolStripMenuItem1");
			this.toolStripMenuItem_159.Click += new global::System.EventHandler(this.toolStripMenuItem_159_Click);
			this.toolStripMenuItem_160.Name = "tắtToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_160, "tắtToolStripMenuItem");
			this.toolStripMenuItem_160.Click += new global::System.EventHandler(this.toolStripMenuItem_160_Click);
			this.toolStripMenuItem_64.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_65,
				this.toolStripMenuItem_66,
				this.toolStripMenuItem_75,
				this.toolStripMenuItem_167,
				this.toolStripMenuItem_85,
				this.toolStripMenuItem_90,
				this.toolStripMenuItem_93,
				this.toolStripMenuItem_116
			});
			this.toolStripMenuItem_64.Name = "đổiVậtPhẩmToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_64, "đổiVậtPhẩmToolStripMenuItem");
			this.toolStripMenuItem_65.Name = "đổiKimTàmTiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_65, "đổiKimTàmTiToolStripMenuItem");
			this.toolStripMenuItem_65.Click += new global::System.EventHandler(this.toolStripMenuItem_65_Click);
			this.toolStripMenuItem_66.Name = "phỉMậtHàmChíTônCHToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_66, "phỉMậtHàmChíTônCHToolStripMenuItem");
			this.toolStripMenuItem_66.Click += new global::System.EventHandler(this.toolStripMenuItem_66_Click);
			this.toolStripMenuItem_75.Name = "đổiKimTinhThạchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_75, "đổiKimTinhThạchToolStripMenuItem");
			this.toolStripMenuItem_75.Click += new global::System.EventHandler(this.toolStripMenuItem_75_Click);
			this.toolStripMenuItem_167.Name = "hồngBaTư999ĐóaHồngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_167, "hồngBaTư999ĐóaHồngToolStripMenuItem");
			this.toolStripMenuItem_167.Click += new global::System.EventHandler(this.toolStripMenuItem_167_Click);
			this.toolStripMenuItem_85.Name = "tiềnVàngThỏiVàngTKToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_85, "tiềnVàngThỏiVàngTKToolStripMenuItem");
			this.toolStripMenuItem_85.Click += new global::System.EventHandler(this.toolStripMenuItem_85_Click);
			this.toolStripMenuItem_90.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_91,
				this.lamToolStripMenuItem,
				this.toolStripMenuItem_92
			});
			this.toolStripMenuItem_90.Name = "linhHồnToáiPhiếnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_90, "linhHồnToáiPhiếnToolStripMenuItem");
			this.toolStripMenuItem_90.Click += new global::System.EventHandler(this.toolStripMenuItem_90_Click);
			this.toolStripMenuItem_91.Name = "hoàngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_91, "hoàngToolStripMenuItem");
			this.toolStripMenuItem_91.Click += new global::System.EventHandler(this.toolStripMenuItem_91_Click);
			this.lamToolStripMenuItem.Name = "lamToolStripMenuItem";
			componentResourceManager.ApplyResources(this.lamToolStripMenuItem, "lamToolStripMenuItem");
			this.lamToolStripMenuItem.Click += new global::System.EventHandler(this.lamToolStripMenuItem_Click);
			this.toolStripMenuItem_92.Name = "lụcToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_92, "lụcToolStripMenuItem");
			this.toolStripMenuItem_92.Click += new global::System.EventHandler(this.toolStripMenuItem_92_Click);
			this.toolStripMenuItem_93.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_94,
				this.toolStripMenuItem_95
			});
			this.toolStripMenuItem_93.Name = "ngânLượngPhiếuTiềnVàngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_93, "ngânLượngPhiếuTiềnVàngToolStripMenuItem");
			this.toolStripMenuItem_93.Click += new global::System.EventHandler(this.toolStripMenuItem_93_Click);
			this.toolStripMenuItem_94.Name = "đổi1VạnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_94, "đổi1VạnToolStripMenuItem");
			this.toolStripMenuItem_94.Click += new global::System.EventHandler(this.toolStripMenuItem_94_Click);
			this.toolStripMenuItem_95.Name = "đổi10VạnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_95, "đổi10VạnToolStripMenuItem");
			this.toolStripMenuItem_95.Click += new global::System.EventHandler(this.toolStripMenuItem_95_Click);
			this.toolStripMenuItem_116.Name = "đổiThầnBinhPhùTKToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_116, "đổiThầnBinhPhùTKToolStripMenuItem");
			this.toolStripMenuItem_116.Click += new global::System.EventHandler(this.toolStripMenuItem_116_Click);
			this.toolStripMenuItem_152.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_153,
				this.toolStripMenuItem_154,
				this.toolStripMenuItem_169,
				this.toolStripMenuItem_155,
				this.toolStripMenuItem4
			});
			this.toolStripMenuItem_152.Name = "nhậnVậtPhẩmToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_152, "nhậnVậtPhẩmToolStripMenuItem");
			this.toolStripMenuItem_153.Name = "nhẫnLễBaoVNGToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_153, "nhẫnLễBaoVNGToolStripMenuItem1");
			this.toolStripMenuItem_153.Click += new global::System.EventHandler(this.toolStripMenuItem_153_Click);
			this.toolStripMenuItem_154.Name = "nhậnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_154, "nhậnToolStripMenuItem");
			this.toolStripMenuItem_154.Click += new global::System.EventHandler(this.toolStripMenuItem_154_Click);
			this.toolStripMenuItem_169.Name = "nhậnSCKinhNghiệmĐanToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_169, "nhậnSCKinhNghiệmĐanToolStripMenuItem");
			this.toolStripMenuItem_169.Click += new global::System.EventHandler(this.toolStripMenuItem_169_Click);
			this.toolStripMenuItem_155.Name = "nhậnKNBTiêuPhongTKToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_155, "nhậnKNBTiêuPhongTKToolStripMenuItem");
			this.toolStripMenuItem_155.Click += new global::System.EventHandler(this.toolStripMenuItem_155_Click);
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			componentResourceManager.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
			this.toolStripMenuItem4.Click += new global::System.EventHandler(this.toolStripMenuItem4_Click);
			this.toolStripMenuItem_43.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_59,
				this.toolStripMenuItem_60,
				this.toolStripMenuItem_61,
				this.toolStripMenuItem_104,
				this.toolStripMenuItem_108,
				this.toolStripMenuItem_106,
				this.toolStripMenuItem_107,
				this.toolStripMenuItem_105,
				this.toolStripMenuItem_109
			});
			this.toolStripMenuItem_43.Name = "báchHoaDuyênToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_43, "báchHoaDuyênToolStripMenuItem");
			this.toolStripMenuItem_43.Click += new global::System.EventHandler(this.toolStripMenuItem_43_Click);
			this.toolStripMenuItem_59.Name = "trồngHoaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_59, "trồngHoaToolStripMenuItem");
			this.toolStripMenuItem_59.Click += new global::System.EventHandler(this.toolStripMenuItem_59_Click);
			this.toolStripMenuItem_60.Name = "bónHoaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_60, "bónHoaToolStripMenuItem");
			this.toolStripMenuItem_60.Click += new global::System.EventHandler(this.toolStripMenuItem_60_Click);
			this.toolStripMenuItem_61.Name = "thuHoạchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_61, "thuHoạchToolStripMenuItem");
			this.toolStripMenuItem_61.Click += new global::System.EventHandler(this.toolStripMenuItem_61_Click);
			this.toolStripMenuItem_104.Name = "trồngBónToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_104, "trồngBónToolStripMenuItem");
			this.toolStripMenuItem_104.Click += new global::System.EventHandler(this.toolStripMenuItem_104_Click);
			this.toolStripMenuItem_108.Name = "trồngThuHoạchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_108, "trồngThuHoạchToolStripMenuItem");
			this.toolStripMenuItem_108.Click += new global::System.EventHandler(this.toolStripMenuItem_108_Click);
			this.toolStripMenuItem_106.Name = "bónThuHoạchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_106, "bónThuHoạchToolStripMenuItem");
			this.toolStripMenuItem_106.Click += new global::System.EventHandler(this.toolStripMenuItem_106_Click);
			this.toolStripMenuItem_107.Name = "trồngBónThuHoạchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_107, "trồngBónThuHoạchToolStripMenuItem");
			this.toolStripMenuItem_107.Click += new global::System.EventHandler(this.toolStripMenuItem_107_Click);
			this.toolStripMenuItem_105.Name = "xóaTọaĐộTrồngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_105, "xóaTọaĐộTrồngToolStripMenuItem");
			this.toolStripMenuItem_105.Click += new global::System.EventHandler(this.toolStripMenuItem_105_Click);
			this.toolStripMenuItem_109.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_110,
				this.toolStripMenuItem_111
			});
			this.toolStripMenuItem_109.Name = "chỉThuHoạchHoaCủaMìnhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_109, "chỉThuHoạchHoaCủaMìnhToolStripMenuItem");
			this.toolStripMenuItem_110.Name = "bậtToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_110, "bậtToolStripMenuItem");
			this.toolStripMenuItem_110.Click += new global::System.EventHandler(this.toolStripMenuItem_110_Click);
			this.toolStripMenuItem_111.Name = "tắtToolStripMenuItem2";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_111, "tắtToolStripMenuItem2");
			this.toolStripMenuItem_111.Click += new global::System.EventHandler(this.toolStripMenuItem_111_Click);
			this.toolStripMenuItem_49.Name = "questSưMônToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_49, "questSưMônToolStripMenuItem");
			this.toolStripMenuItem_49.Click += new global::System.EventHandler(this.toolStripMenuItem_49_Click);
			this.toolStripMenuItem_50.Name = "tụBảoBồnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_50, "tụBảoBồnToolStripMenuItem");
			this.toolStripMenuItem_50.Click += new global::System.EventHandler(this.toolStripMenuItem_50_Click);
			this.toolStripMenuItem_52.Name = "cầuPhúcToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_52, "cầuPhúcToolStripMenuItem");
			this.toolStripMenuItem_52.Click += new global::System.EventHandler(this.toolStripMenuItem_52_Click);
			this.toolStripMenuItem_53.Name = "cầuNguyệnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_53, "cầuNguyệnToolStripMenuItem");
			this.toolStripMenuItem_53.Click += new global::System.EventHandler(this.toolStripMenuItem_53_Click);
			this.toolStripMenuItem_54.Name = "xâyDựngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_54, "xâyDựngToolStripMenuItem");
			this.toolStripMenuItem_54.Click += new global::System.EventHandler(this.toolStripMenuItem_54_Click);
			this.toolStripMenuItem_55.Name = "luyệnKimToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_55, "luyệnKimToolStripMenuItem");
			this.toolStripMenuItem_55.Click += new global::System.EventHandler(this.toolStripMenuItem_55_Click);
			this.toolStripMenuItem_84.Name = "luyệnKimChậmToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_84, "luyệnKimChậmToolStripMenuItem");
			this.toolStripMenuItem_84.Click += new global::System.EventHandler(this.toolStripMenuItem_84_Click);
			this.lV2840ToolStripMenuItem.Name = "lV2840ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.lV2840ToolStripMenuItem, "lV2840ToolStripMenuItem");
			this.lV2840ToolStripMenuItem.Click += new global::System.EventHandler(this.lV2840ToolStripMenuItem_Click);
			this.toolStripMenuItem_51.Name = "khoángDượcToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_51, "khoángDượcToolStripMenuItem");
			this.toolStripMenuItem_51.Click += new global::System.EventHandler(this.toolStripMenuItem_51_Click);
			this.toolStripMenuItem_56.Name = "trừngÁcToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_56, "trừngÁcToolStripMenuItem");
			this.toolStripMenuItem_56.Click += new global::System.EventHandler(this.toolStripMenuItem_56_Click);
			this.toolStripMenuItem_57.Name = "mởTàngBảoĐồToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_57, "mởTàngBảoĐồToolStripMenuItem");
			this.toolStripMenuItem_57.Click += new global::System.EventHandler(this.toolStripMenuItem_57_Click);
			this.toolStripMenuItem_58.Name = "tuDưỡngConToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_58, "tuDưỡngConToolStripMenuItem");
			this.toolStripMenuItem_58.Click += new global::System.EventHandler(this.toolStripMenuItem_58_Click);
			this.toolStripMenuItem_79.Name = "buônDưaHấuToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_79, "buônDưaHấuToolStripMenuItem");
			this.toolStripMenuItem_79.Click += new global::System.EventHandler(this.toolStripMenuItem_79_Click);
			this.toolStripMenuItem_132.Name = "thủBịChiếnMinhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_132, "thủBịChiếnMinhToolStripMenuItem");
			this.toolStripMenuItem_132.Click += new global::System.EventHandler(this.toolStripMenuItem_132_Click);
			this.toolStripMenuItem_170.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem7,
				this.toolStripMenuItem14,
				this.toolStripMenuItem15,
				this.toolStripMenuItem16,
				this.toolStripMenuItem17
			});
			this.toolStripMenuItem_170.Name = "giángSinhYêuThươngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_170, "giángSinhYêuThươngToolStripMenuItem");
			this.toolStripMenuItem_170.Click += new global::System.EventHandler(this.toolStripMenuItem_170_Click);
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			componentResourceManager.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
			this.toolStripMenuItem7.Click += new global::System.EventHandler(this.toolStripMenuItem7_Click);
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			componentResourceManager.ApplyResources(this.toolStripMenuItem14, "toolStripMenuItem14");
			this.toolStripMenuItem14.Click += new global::System.EventHandler(this.toolStripMenuItem14_Click);
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			componentResourceManager.ApplyResources(this.toolStripMenuItem15, "toolStripMenuItem15");
			this.toolStripMenuItem15.Click += new global::System.EventHandler(this.toolStripMenuItem15_Click);
			this.toolStripMenuItem16.Name = "toolStripMenuItem16";
			componentResourceManager.ApplyResources(this.toolStripMenuItem16, "toolStripMenuItem16");
			this.toolStripMenuItem16.Click += new global::System.EventHandler(this.toolStripMenuItem16_Click);
			this.toolStripMenuItem17.Name = "toolStripMenuItem17";
			componentResourceManager.ApplyResources(this.toolStripMenuItem17, "toolStripMenuItem17");
			this.toolStripMenuItem17.Click += new global::System.EventHandler(this.toolStripMenuItem17_Click);
			this.toolStripMenuItem_129.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_130,
				this.toolStripMenuItem_131
			});
			this.toolStripMenuItem_129.Name = "phụBảnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_129, "phụBảnToolStripMenuItem");
			this.toolStripMenuItem_130.Name = "pMPSơChiếnToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_130, "pMPSơChiếnToolStripMenuItem1");
			this.toolStripMenuItem_130.Click += new global::System.EventHandler(this.toolStripMenuItem_130_Click);
			this.toolStripMenuItem_131.Name = "pMPKhiêuChiếnToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_131, "pMPKhiêuChiếnToolStripMenuItem1");
			this.toolStripMenuItem_131.Click += new global::System.EventHandler(this.toolStripMenuItem_131_Click);
			this.toolStripMenuItem_45.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_177,
				this.toolStripMenuItem_180,
				this.muaToolStripMenuItem,
				this.toolStripMenuItem_183,
				this.toolStripMenuItem_98,
				this.toolStripMenuItem_46,
				this.toolStripMenuItem_81,
				this.toolStripMenuItem_171,
				this.toolStripMenuItem_172,
				this.toolStripMenuItem_47,
				this.toolStripMenuItem_48,
				this.toolStripMenuItem_88,
				this.toolStripMenuItem_89,
				this.toolStripMenuItem_103,
				this.toolStripMenuItem_168,
				this.toolStripMenuItem_179,
				this.toolStripMenuItem_117,
				this.toolStripMenuItem_122,
				this.toolStripMenuItem_124,
				this.toolStripMenuItem_126
			});
			this.toolStripMenuItem_45.Name = "tiệnDụngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_45, "tiệnDụngToolStripMenuItem");
			this.toolStripMenuItem_177.Name = "lấyTọaĐộTrainHiệnTaiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_177, "lấyTọaĐộTrainHiệnTaiToolStripMenuItem");
			this.toolStripMenuItem_177.Click += new global::System.EventHandler(this.toolStripMenuItem_177_Click);
			this.toolStripMenuItem_180.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_181,
				this.tLCToolStripMenuItem,
				this.toolStripMenuItem_182
			});
			this.toolStripMenuItem_180.Name = "địnhVịTLCTạiĐâyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_180, "địnhVịTLCTạiĐâyToolStripMenuItem");
			this.toolStripMenuItem_180.Click += new global::System.EventHandler(this.toolStripMenuItem_180_Click);
			this.toolStripMenuItem_181.Name = "tLCĐầuTiênToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_181, "tLCĐầuTiênToolStripMenuItem");
			this.toolStripMenuItem_181.Click += new global::System.EventHandler(this.toolStripMenuItem_181_Click);
			this.tLCToolStripMenuItem.Name = "tLCToolStripMenuItem";
			componentResourceManager.ApplyResources(this.tLCToolStripMenuItem, "tLCToolStripMenuItem");
			this.tLCToolStripMenuItem.Click += new global::System.EventHandler(this.tLCToolStripMenuItem_Click);
			this.toolStripMenuItem_182.Name = "tấtCảTLCToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_182, "tấtCảTLCToolStripMenuItem");
			this.toolStripMenuItem_182.Click += new global::System.EventHandler(this.toolStripMenuItem_182_Click);
			this.muaToolStripMenuItem.Name = "muaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.muaToolStripMenuItem, "muaToolStripMenuItem");
			this.muaToolStripMenuItem.Click += new global::System.EventHandler(this.muaToolStripMenuItem_Click);
			this.toolStripMenuItem_183.Name = "muaĐồKNBTrongDanhSáchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_183, "muaĐồKNBTrongDanhSáchToolStripMenuItem");
			this.toolStripMenuItem_183.Click += new global::System.EventHandler(this.toolStripMenuItem_183_Click);
			this.toolStripMenuItem_98.Name = "bánĐồTrongDanhSáchToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_98, "bánĐồTrongDanhSáchToolStripMenuItem");
			this.toolStripMenuItem_98.Click += new global::System.EventHandler(this.toolStripMenuItem_98_Click);
			this.toolStripMenuItem_46.Name = "resetAutoNhânVậtToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_46, "resetAutoNhânVậtToolStripMenuItem");
			this.toolStripMenuItem_46.Click += new global::System.EventHandler(this.toolStripMenuItem_46_Click);
			this.toolStripMenuItem_81.Name = "resetGiờNgayVNGToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_81, "resetGiờNgayVNGToolStripMenuItem");
			this.toolStripMenuItem_81.Click += new global::System.EventHandler(this.toolStripMenuItem_81_Click);
			this.toolStripMenuItem_171.Name = "resetGiờCùngLúcVNGToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_171, "resetGiờCùngLúcVNGToolStripMenuItem");
			this.toolStripMenuItem_171.Click += new global::System.EventHandler(this.toolStripMenuItem_171_Click);
			this.toolStripMenuItem_172.Name = "nhậnKinhNghiệmLưuTrữToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_172, "nhậnKinhNghiệmLưuTrữToolStripMenuItem");
			this.toolStripMenuItem_172.Click += new global::System.EventHandler(this.toolStripMenuItem_172_Click);
			this.toolStripMenuItem_47.Name = "đánhQuanhĐiểmToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_47, "đánhQuanhĐiểmToolStripMenuItem");
			this.toolStripMenuItem_47.Click += new global::System.EventHandler(this.toolStripMenuItem_47_Click);
			this.toolStripMenuItem_48.Name = "đánhTựDoToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_48, "đánhTựDoToolStripMenuItem1");
			this.toolStripMenuItem_48.Click += new global::System.EventHandler(this.toolStripMenuItem_48_Click);
			this.toolStripMenuItem_88.Name = "lênNgựaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_88, "lênNgựaToolStripMenuItem");
			this.toolStripMenuItem_88.Click += new global::System.EventHandler(this.toolStripMenuItem_88_Click);
			this.toolStripMenuItem_89.Name = "xuốngNgựaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_89, "xuốngNgựaToolStripMenuItem");
			this.toolStripMenuItem_89.Click += new global::System.EventHandler(this.toolStripMenuItem_89_Click);
			this.toolStripMenuItem_103.Name = "càiTimeAnToàn1pToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_103, "càiTimeAnToàn1pToolStripMenuItem");
			this.toolStripMenuItem_103.Click += new global::System.EventHandler(this.toolStripMenuItem_103_Click);
			this.toolStripMenuItem_168.Name = "tựKếtBáiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_168, "tựKếtBáiToolStripMenuItem");
			this.toolStripMenuItem_168.Click += new global::System.EventHandler(this.toolStripMenuItem_168_Click);
			this.toolStripMenuItem_179.Name = "tăngĐiểmPetToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_179, "tăngĐiểmPetToolStripMenuItem");
			this.toolStripMenuItem_179.Click += new global::System.EventHandler(this.toolStripMenuItem_179_Click);
			this.toolStripMenuItem_117.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_118,
				this.toolStripMenuItem_119,
				this.toolStripMenuItem_120
			});
			this.toolStripMenuItem_117.Name = "nhậnX2FreeVNGToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_117, "nhậnX2FreeVNGToolStripMenuItem");
			this.toolStripMenuItem_118.Name = "nhận4hX2ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_118, "nhận4hX2ToolStripMenuItem");
			this.toolStripMenuItem_118.Click += new global::System.EventHandler(this.toolStripMenuItem_118_Click);
			this.toolStripMenuItem_119.Name = "đóngBăngX2ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_119, "đóngBăngX2ToolStripMenuItem");
			this.toolStripMenuItem_119.Click += new global::System.EventHandler(this.toolStripMenuItem_119_Click);
			this.toolStripMenuItem_120.Name = "kíchHoạtX2ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_120, "kíchHoạtX2ToolStripMenuItem");
			this.toolStripMenuItem_120.Click += new global::System.EventHandler(this.toolStripMenuItem_120_Click);
			this.toolStripMenuItem_122.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_123
			});
			this.toolStripMenuItem_122.Name = "đặtLịchToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_122, "đặtLịchToolStripMenuItem1");
			this.toolStripMenuItem_122.Click += new global::System.EventHandler(this.toolStripMenuItem_122_Click);
			this.toolStripMenuItem_123.Name = "tắtToolStripMenuItem3";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_123, "tắtToolStripMenuItem3");
			this.toolStripMenuItem_123.Click += new global::System.EventHandler(this.toolStripMenuItem_123_Click);
			this.toolStripMenuItem_124.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_125
			});
			this.toolStripMenuItem_124.Name = "bậtAutoPKToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_124, "bậtAutoPKToolStripMenuItem");
			this.toolStripMenuItem_124.Click += new global::System.EventHandler(this.toolStripMenuItem_124_Click);
			this.toolStripMenuItem_125.Name = "tắtToolStripMenuItem4";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_125, "tắtToolStripMenuItem4");
			this.toolStripMenuItem_125.Click += new global::System.EventHandler(this.toolStripMenuItem_125_Click);
			this.toolStripMenuItem_126.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_127,
				this.toolStripMenuItem_128
			});
			this.toolStripMenuItem_126.Name = "hủyVậtPhẩmNVToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_126, "hủyVậtPhẩmNVToolStripMenuItem1");
			this.toolStripMenuItem_127.Name = "thưHKVDuyTuMộcTàiToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_127, "thưHKVDuyTuMộcTàiToolStripMenuItem1");
			this.toolStripMenuItem_127.Click += new global::System.EventHandler(this.toolStripMenuItem_127_Click);
			this.toolStripMenuItem_128.Name = "hủyTấtCảVậtPhẩmNVToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_128, "hủyTấtCảVậtPhẩmNVToolStripMenuItem1");
			this.toolStripMenuItem_128.Click += new global::System.EventHandler(this.toolStripMenuItem_128_Click);
			this.toolStripMenuItem_133.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_148,
				this.toolStripMenuItem_149,
				this.toolStripMenuItem_145,
				this.toolStripMenuItem_178,
				this.toolStripMenuItem_151,
				this.toolStripMenuItem_144,
				this.toolStripMenuItem_137,
				this.toolStripMenuItem_138,
				this.toolStripMenuItem_147,
				this.toolStripSeparator5,
				this.toolStripMenuItem_134,
				this.toolStripMenuItem_136,
				this.toolStripMenuItem_135,
				this.toolStripMenuItem_139,
				this.toolStripMenuItem_140,
				this.toolStripMenuItem_141,
				this.toolStripMenuItem_142,
				this.kimLangToolStripMenuItem,
				this.toolStripMenuItem_190,
				this.toolStripMenuItem_143,
				this.toolStripMenuItem_146,
				this.toolStripSeparator6,
				this.theoSauKeyToolStripMenuItem1
			});
			this.toolStripMenuItem_133.Name = "diChuyểnNhanhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_133, "diChuyểnNhanhToolStripMenuItem");
			this.toolStripMenuItem_148.Name = "phùVềThànhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_148, "phùVềThànhToolStripMenuItem");
			this.toolStripMenuItem_148.Click += new global::System.EventHandler(this.toolStripMenuItem_148_Click);
			this.toolStripMenuItem_149.Name = "phùĐạiLýToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_149, "phùĐạiLýToolStripMenuItem");
			this.toolStripMenuItem_149.Click += new global::System.EventHandler(this.toolStripMenuItem_149_Click);
			this.toolStripMenuItem_145.Name = "lênBãiTrainToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_145, "lênBãiTrainToolStripMenuItem1");
			this.toolStripMenuItem_145.Click += new global::System.EventHandler(this.toolStripMenuItem_145_Click);
			this.toolStripMenuItem_178.Name = "dùngTLCÔSố1ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_178, "dùngTLCÔSố1ToolStripMenuItem");
			this.toolStripMenuItem_178.Click += new global::System.EventHandler(this.toolStripMenuItem_178_Click);
			this.toolStripMenuItem_151.Name = "hồiPhụcToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_151, "hồiPhụcToolStripMenuItem");
			this.toolStripMenuItem_151.Click += new global::System.EventHandler(this.toolStripMenuItem_151_Click);
			this.toolStripMenuItem_144.Name = "hồiPhụcLênBãiToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_144, "hồiPhụcLênBãiToolStripMenuItem1");
			this.toolStripMenuItem_144.Click += new global::System.EventHandler(this.toolStripMenuItem_144_Click);
			this.toolStripMenuItem_137.Name = "tiềnTrangToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_137, "tiềnTrangToolStripMenuItem");
			this.toolStripMenuItem_137.Click += new global::System.EventHandler(this.toolStripMenuItem_137_Click);
			this.toolStripMenuItem_138.Name = "rươngĐồToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_138, "rươngĐồToolStripMenuItem");
			this.toolStripMenuItem_138.Click += new global::System.EventHandler(this.toolStripMenuItem_138_Click);
			this.toolStripMenuItem_147.Name = "thươngHộiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_147, "thươngHộiToolStripMenuItem");
			this.toolStripMenuItem_147.Click += new global::System.EventHandler(this.toolStripMenuItem_147_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			componentResourceManager.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
			this.toolStripMenuItem_134.Name = "chiếnMinhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_134, "chiếnMinhToolStripMenuItem");
			this.toolStripMenuItem_134.Click += new global::System.EventHandler(this.toolStripMenuItem_134_Click);
			this.toolStripMenuItem_136.Name = "thànhBangToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_136, "thànhBangToolStripMenuItem");
			this.toolStripMenuItem_136.Click += new global::System.EventHandler(this.toolStripMenuItem_136_Click);
			this.toolStripMenuItem_135.Name = "phụngMinhTrấnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_135, "phụngMinhTrấnToolStripMenuItem");
			this.toolStripMenuItem_135.Click += new global::System.EventHandler(this.toolStripMenuItem_135_Click);
			this.toolStripMenuItem_139.Name = "lạcDươngToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_139, "lạcDươngToolStripMenuItem");
			this.toolStripMenuItem_139.Click += new global::System.EventHandler(this.toolStripMenuItem_139_Click);
			this.toolStripMenuItem_140.Name = "tôChâuToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_140, "tôChâuToolStripMenuItem");
			this.toolStripMenuItem_140.Click += new global::System.EventHandler(this.toolStripMenuItem_140_Click);
			this.toolStripMenuItem_141.Name = "đạiLýToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_141, "đạiLýToolStripMenuItem");
			this.toolStripMenuItem_141.Click += new global::System.EventHandler(this.toolStripMenuItem_141_Click);
			this.toolStripMenuItem_142.Name = "lâuLanToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_142, "lâuLanToolStripMenuItem");
			this.toolStripMenuItem_142.Click += new global::System.EventHandler(this.toolStripMenuItem_142_Click);
			this.kimLangToolStripMenuItem.Name = "kimLangToolStripMenuItem";
			componentResourceManager.ApplyResources(this.kimLangToolStripMenuItem, "kimLangToolStripMenuItem");
			this.kimLangToolStripMenuItem.Click += new global::System.EventHandler(this.kimLangToolStripMenuItem_Click);
			this.toolStripMenuItem_190.Name = "biệnKinhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_190, "biệnKinhToolStripMenuItem");
			this.toolStripMenuItem_190.Click += new global::System.EventHandler(this.toolStripMenuItem_190_Click);
			this.toolStripMenuItem_143.Name = "thúcHàCổTrấnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_143, "thúcHàCổTrấnToolStripMenuItem");
			this.toolStripMenuItem_143.Click += new global::System.EventHandler(this.toolStripMenuItem_143_Click);
			this.toolStripMenuItem_146.Name = "phụngHoàngCổThànhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_146, "phụngHoàngCổThànhToolStripMenuItem");
			this.toolStripMenuItem_146.Click += new global::System.EventHandler(this.toolStripMenuItem_146_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			componentResourceManager.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
			this.theoSauKeyToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_150
			});
			this.theoSauKeyToolStripMenuItem1.Name = "theoSauKeyToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.theoSauKeyToolStripMenuItem1, "theoSauKeyToolStripMenuItem1");
			this.theoSauKeyToolStripMenuItem1.Click += new global::System.EventHandler(this.theoSauKeyToolStripMenuItem1_Click);
			this.toolStripMenuItem_150.Name = "tắtTheoSauToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_150, "tắtTheoSauToolStripMenuItem1");
			this.toolStripMenuItem_150.Click += new global::System.EventHandler(this.toolStripMenuItem_150_Click);
			this.toolStripMenuItem_173.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_174,
				this.toolStripMenuItem_175,
				this.toolStripMenuItem_176
			});
			this.toolStripMenuItem_173.Name = "sắpXếpTàiKhoảnToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_173, "sắpXếpTàiKhoảnToolStripMenuItem");
			this.toolStripMenuItem_174.Name = "theoCấpĐộToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_174, "theoCấpĐộToolStripMenuItem");
			this.toolStripMenuItem_174.Click += new global::System.EventHandler(this.toolStripMenuItem_174_Click);
			this.toolStripMenuItem_175.Name = "theoNhómToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_175, "theoNhómToolStripMenuItem");
			this.toolStripMenuItem_175.Click += new global::System.EventHandler(this.toolStripMenuItem_175_Click);
			this.toolStripMenuItem_176.Name = "theoPháiToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_176, "theoPháiToolStripMenuItem");
			this.toolStripMenuItem_176.Click += new global::System.EventHandler(this.toolStripMenuItem_176_Click);
			this.toolStripMenuItem_184.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_185,
				this.toolStripMenuItem_187
			});
			this.toolStripMenuItem_184.Name = "càiĐặtThiếtLậpToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_184, "càiĐặtThiếtLậpToolStripMenuItem");
			this.toolStripMenuItem_185.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_186
			});
			this.toolStripMenuItem_185.Name = "lưuAccNàyLàmChủPartyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_185, "lưuAccNàyLàmChủPartyToolStripMenuItem");
			this.toolStripMenuItem_185.Click += new global::System.EventHandler(this.toolStripMenuItem_185_Click);
			this.toolStripMenuItem_186.Name = "xóaThiếtLậpToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_186, "xóaThiếtLậpToolStripMenuItem");
			this.toolStripMenuItem_186.Click += new global::System.EventHandler(this.toolStripMenuItem_186_Click);
			this.toolStripMenuItem_187.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_188
			});
			this.toolStripMenuItem_187.Name = "tựMuaX2ShopKNBKhóaToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_187, "tựMuaX2ShopKNBKhóaToolStripMenuItem");
			this.toolStripMenuItem_187.Click += new global::System.EventHandler(this.toolStripMenuItem_187_Click);
			this.toolStripMenuItem_188.Name = "xóaThiếtLậpToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_188, "xóaThiếtLậpToolStripMenuItem1");
			this.toolStripMenuItem_188.Click += new global::System.EventHandler(this.toolStripMenuItem_188_Click);
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			this.toolStripMenuItem_156.Name = "bậtAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_156, "bậtAutoToolStripMenuItem");
			this.toolStripMenuItem_156.Click += new global::System.EventHandler(this.toolStripMenuItem_156_Click);
			this.toolStripMenuItem_157.Name = "tắtAutoToolStripMenuItem1";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_157, "tắtAutoToolStripMenuItem1");
			this.toolStripMenuItem_157.Click += new global::System.EventHandler(this.toolStripMenuItem_157_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			componentResourceManager.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
			this.toolStripMenuItem_62.Name = "mờiĐộiCảNhómToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_62, "mờiĐộiCảNhómToolStripMenuItem");
			this.toolStripMenuItem_62.Click += new global::System.EventHandler(this.toolStripMenuItem_62_Click);
			this.toolStripMenuItem_63.Name = "triệuTậpCảNhómToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_63, "triệuTậpCảNhómToolStripMenuItem");
			this.toolStripMenuItem_63.Click += new global::System.EventHandler(this.toolStripMenuItem_63_Click);
			this.toolStripMenuItem_82.Name = "setNhómIDToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_82, "setNhómIDToolStripMenuItem");
			this.toolStripMenuItem_82.Click += new global::System.EventHandler(this.toolStripMenuItem_82_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			componentResourceManager.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			this.toolStripMenuItem_12.Name = "làmNổiCửaSổGameToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_12, "làmNổiCửaSổGameToolStripMenuItem");
			this.toolStripMenuItem_12.Click += new global::System.EventHandler(this.toolStripMenuItem_12_Click);
			this.toolStripMenuItem_87.Name = "hiệnGameVàThuXuốngTaskbarToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_87, "hiệnGameVàThuXuốngTaskbarToolStripMenuItem");
			this.toolStripMenuItem_87.Click += new global::System.EventHandler(this.toolStripMenuItem_87_Click);
			this.toolStripMenuItem_10.Name = "tắtAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_10, "tắtAutoToolStripMenuItem");
			this.toolStripMenuItem_10.Click += new global::System.EventHandler(this.toolStripMenuItem_10_Click);
			this.toolStripMenuItem_21.Name = "ânCửaSổGameLoại2ToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_21, "ânCửaSổGameLoại2ToolStripMenuItem");
			this.toolStripMenuItem_21.Click += new global::System.EventHandler(this.toolStripMenuItem_21_Click);
			this.toolStripMenuItem_40.Name = "hiệnGameBịMấtToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_40, "hiệnGameBịMấtToolStripMenuItem");
			this.toolStripMenuItem_40.Click += new global::System.EventHandler(this.toolStripMenuItem_40_Click);
			this.menuThoatGameNhanh.Name = "menuThoatGameNhanh";
			componentResourceManager.ApplyResources(this.menuThoatGameNhanh, "menuThoatGameNhanh");
			this.menuThoatGameNhanh.Click += new global::System.EventHandler(this.menuThoatGameNhanh_Click);
			this.toolStripMenuItem_67.Name = "bỏQuaKhôngAutoNhânVậtNàyToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_67, "bỏQuaKhôngAutoNhânVậtNàyToolStripMenuItem");
			this.toolStripMenuItem_67.Click += new global::System.EventHandler(this.toolStripMenuItem_67_Click);
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			componentResourceManager.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
			componentResourceManager.ApplyResources(this.toolStripMenuItem_166, "xửLýThiếtLậpAutoToolStripMenuItem");
			this.toolStripMenuItem_166.Name = "xửLýThiếtLậpAutoToolStripMenuItem";
			this.toolStripMenuItem_162.Name = "lưuThiếtLậpVàoTậpTinToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_162, "lưuThiếtLậpVàoTậpTinToolStripMenuItem");
			this.toolStripMenuItem_162.Click += new global::System.EventHandler(this.toolStripMenuItem_162_Click);
			this.toolStripMenuItem_163.Name = "nạpThiếtLậpTừTậpTinToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_163, "nạpThiếtLậpTừTậpTinToolStripMenuItem");
			this.toolStripMenuItem_163.Click += new global::System.EventHandler(this.toolStripMenuItem_163_Click);
			this.toolStripMenuItem_164.Name = "ápDụngThiếtLậpChoToànAutoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_164, "ápDụngThiếtLậpChoToànAutoToolStripMenuItem");
			this.toolStripMenuItem_164.Click += new global::System.EventHandler(this.toolStripMenuItem_164_Click);
			this.toolStripMenuItem_165.Name = "xóaThiếtLậpVềMặcĐịnhToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_165, "xóaThiếtLậpVềMặcĐịnhToolStripMenuItem");
			this.toolStripMenuItem_165.Click += new global::System.EventHandler(this.toolStripMenuItem_165_Click);
			this.toolStripMenuItem_112.Name = "thủyLaoToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_112, "thủyLaoToolStripMenuItem");
			this.toolStripMenuItem_113.Name = "nhậnNhiệmVụToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_113, "nhậnNhiệmVụToolStripMenuItem");
			this.toolStripMenuItem_114.Name = "chạyQToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_114, "chạyQToolStripMenuItem");
			this.toolStripMenuItem_115.Name = "bánRácToolStripMenuItem";
			componentResourceManager.ApplyResources(this.toolStripMenuItem_115, "bánRácToolStripMenuItem");
			this.pnelFacebook.BackColor = global::System.Drawing.Color.Cornsilk;
			this.pnelFacebook.Controls.Add(this.btnBuyHour);
			this.pnelFacebook.Controls.Add(this.btnSkillsOff);
			this.pnelFacebook.Controls.Add(this.btnSkills);
			this.pnelFacebook.Controls.Add(this.label51);
			this.pnelFacebook.Controls.Add(this.btnTheoSau);
			this.pnelFacebook.Controls.Add(this.btnTheoSauOff);
			this.pnelFacebook.Controls.Add(this.AIModes);
			this.pnelFacebook.Controls.Add(this.label18);
			this.pnelFacebook.Controls.Add(this.cboxTuTheo);
			this.pnelFacebook.Controls.Add(this.btnDanhTheoTen);
			this.pnelFacebook.Controls.Add(this.label15);
			this.pnelFacebook.Controls.Add(this.label14);
			this.pnelFacebook.Controls.Add(this.btnThuPetOff);
			this.pnelFacebook.Controls.Add(this.btnNhatBocOff);
			this.pnelFacebook.Controls.Add(this.btnThuPet);
			this.pnelFacebook.Controls.Add(this.btnNhatBoc);
			this.pnelFacebook.Controls.Add(this.btnDanhTheoKey);
			this.pnelFacebook.Controls.Add(this.btnDanhGomQuai);
			this.pnelFacebook.Controls.Add(this.btnDanhTungCon);
			this.pnelFacebook.Controls.Add(this.numDelay);
			this.pnelFacebook.Controls.Add(this.numGroupID);
			this.pnelFacebook.Controls.Add(this.label5);
			this.pnelFacebook.Controls.Add(this.label35);
			this.pnelFacebook.Controls.Add(this.btnUpdate);
			this.pnelFacebook.Controls.Add(this.btnMoiDoi);
			this.pnelFacebook.Controls.Add(this.btnTrieuTap);
			componentResourceManager.ApplyResources(this.pnelFacebook, "pnelFacebook");
			this.pnelFacebook.Name = "pnelFacebook";
			this.btnBuyHour.BackColor = global::System.Drawing.Color.OrangeRed;
			this.btnBuyHour.ForeColor = global::System.Drawing.Color.LavenderBlush;
			componentResourceManager.ApplyResources(this.btnBuyHour, "btnBuyHour");
			this.btnBuyHour.Name = "btnBuyHour";
			this.btnBuyHour.UseVisualStyleBackColor = false;
			this.btnBuyHour.Click += new global::System.EventHandler(this.btnBuyHour_Click);
			this.btnSkillsOff.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnSkillsOff, "btnSkillsOff");
			this.btnSkillsOff.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnSkillsOff.Name = "btnSkillsOff";
			this.btnSkillsOff.UseVisualStyleBackColor = false;
			this.btnSkillsOff.Click += new global::System.EventHandler(this.btnSkillsOff_Click);
			this.btnSkills.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnSkills, "btnSkills");
			this.btnSkills.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnSkills.Name = "btnSkills";
			this.btnSkills.UseVisualStyleBackColor = false;
			this.btnSkills.Click += new global::System.EventHandler(this.btnSkills_Click);
			componentResourceManager.ApplyResources(this.label51, "label51");
			this.label51.Name = "label51";
			this.btnTheoSau.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnTheoSau, "btnTheoSau");
			this.btnTheoSau.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnTheoSau.Name = "btnTheoSau";
			this.btnTheoSau.UseVisualStyleBackColor = false;
			this.btnTheoSau.Click += new global::System.EventHandler(this.btnTheoSau_Click);
			this.btnTheoSauOff.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnTheoSauOff, "btnTheoSauOff");
			this.btnTheoSauOff.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnTheoSauOff.Name = "btnTheoSauOff";
			this.btnTheoSauOff.UseVisualStyleBackColor = false;
			this.btnTheoSauOff.Click += new global::System.EventHandler(this.btnTheoSauOff_Click);
			componentResourceManager.ApplyResources(this.label18, "label18");
			this.label18.Name = "label18";
			componentResourceManager.ApplyResources(this.cboxTuTheo, "cboxTuTheo");
			this.cboxTuTheo.Checked = true;
			this.cboxTuTheo.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.cboxTuTheo.Name = "cboxTuTheo";
			this.cboxTuTheo.UseVisualStyleBackColor = true;
			this.btnDanhTheoTen.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnDanhTheoTen.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnDanhTheoTen, "btnDanhTheoTen");
			this.btnDanhTheoTen.Name = "btnDanhTheoTen";
			this.btnDanhTheoTen.UseVisualStyleBackColor = false;
			this.btnDanhTheoTen.Click += new global::System.EventHandler(this.btnDanhTheoTen_Click);
			componentResourceManager.ApplyResources(this.label15, "label15");
			this.label15.Name = "label15";
			componentResourceManager.ApplyResources(this.label14, "label14");
			this.label14.Name = "label14";
			this.btnThuPetOff.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnThuPetOff, "btnThuPetOff");
			this.btnThuPetOff.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnThuPetOff.Name = "btnThuPetOff";
			this.btnThuPetOff.UseVisualStyleBackColor = false;
			this.btnThuPetOff.Click += new global::System.EventHandler(this.btnThuPetOff_Click);
			this.btnNhatBocOff.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnNhatBocOff, "btnNhatBocOff");
			this.btnNhatBocOff.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnNhatBocOff.Name = "btnNhatBocOff";
			this.btnNhatBocOff.UseVisualStyleBackColor = false;
			this.btnNhatBocOff.Click += new global::System.EventHandler(this.btnNhatBocOff_Click);
			this.btnThuPet.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnThuPet, "btnThuPet");
			this.btnThuPet.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnThuPet.Name = "btnThuPet";
			this.btnThuPet.UseVisualStyleBackColor = false;
			this.btnThuPet.Click += new global::System.EventHandler(this.btnThuPet_Click);
			this.btnNhatBoc.BackColor = global::System.Drawing.Color.Cornsilk;
			componentResourceManager.ApplyResources(this.btnNhatBoc, "btnNhatBoc");
			this.btnNhatBoc.ForeColor = global::System.Drawing.Color.Cornsilk;
			this.btnNhatBoc.Name = "btnNhatBoc";
			this.btnNhatBoc.UseVisualStyleBackColor = false;
			this.btnNhatBoc.Click += new global::System.EventHandler(this.btnNhatBoc_Click);
			this.btnDanhTheoKey.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnDanhTheoKey.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnDanhTheoKey, "btnDanhTheoKey");
			this.btnDanhTheoKey.Name = "btnDanhTheoKey";
			this.btnDanhTheoKey.UseVisualStyleBackColor = false;
			this.btnDanhTheoKey.Click += new global::System.EventHandler(this.btnDanhTheoKey_Click);
			this.btnDanhGomQuai.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnDanhGomQuai.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnDanhGomQuai, "btnDanhGomQuai");
			this.btnDanhGomQuai.Name = "btnDanhGomQuai";
			this.btnDanhGomQuai.UseVisualStyleBackColor = false;
			this.btnDanhGomQuai.Click += new global::System.EventHandler(this.btnDanhGomQuai_Click);
			this.btnDanhTungCon.BackColor = global::System.Drawing.Color.FromArgb(247, 207, 142);
			this.btnDanhTungCon.ForeColor = global::System.Drawing.Color.Black;
			componentResourceManager.ApplyResources(this.btnDanhTungCon, "btnDanhTungCon");
			this.btnDanhTungCon.Name = "btnDanhTungCon";
			this.btnDanhTungCon.UseVisualStyleBackColor = false;
			this.btnDanhTungCon.Click += new global::System.EventHandler(this.btnDanhTungCon_Click);
			this.numDelay.BackColor = global::System.Drawing.Color.FromArgb(206, 233, 253);
			componentResourceManager.ApplyResources(this.numDelay, "numDelay");
			global::System.Windows.Forms.NumericUpDown numericUpDown93 = this.numDelay;
			int[] array93 = new int[4];
			array93[0] = 10;
			numericUpDown93.Maximum = new decimal(array93);
			this.numDelay.Name = "numDelay";
			global::System.Windows.Forms.NumericUpDown numericUpDown94 = this.numDelay;
			int[] array94 = new int[4];
			array94[0] = 3;
			numericUpDown94.Value = new decimal(array94);
			this.numDelay.ValueChanged += new global::System.EventHandler(this.numDelay_ValueChanged);
			componentResourceManager.ApplyResources(this.label5, "label5");
			this.label5.Name = "label5";
			this.btnUpdate.BackColor = global::System.Drawing.Color.OrangeRed;
			this.btnUpdate.ForeColor = global::System.Drawing.Color.LavenderBlush;
			componentResourceManager.ApplyResources(this.btnUpdate, "btnUpdate");
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new global::System.EventHandler(this.btnUpdate_Click);
			componentResourceManager.ApplyResources(this.btnThuGon, "btnThuGon");
			this.btnThuGon.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnThuGon.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnThuGon.Image = global::ns0.Class212.collapse;
			this.btnThuGon.Name = "btnThuGon";
			this.btnThuGon.UseVisualStyleBackColor = false;
			this.btnThuGon.Click += new global::System.EventHandler(this.btnThuGon_Click);
			componentResourceManager.ApplyResources(this.btnThuCommonGUI, "btnThuCommonGUI");
			this.btnThuCommonGUI.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnThuCommonGUI.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnThuCommonGUI.Image = global::ns0.Class212.collapse;
			this.btnThuCommonGUI.Name = "btnThuCommonGUI";
			this.btnThuCommonGUI.UseVisualStyleBackColor = false;
			this.btnThuCommonGUI.Click += new global::System.EventHandler(this.btnThuCommonGUI_Click);
			this.btnFacebook.BackColor = global::System.Drawing.Color.WhiteSmoke;
			componentResourceManager.ApplyResources(this.btnFacebook, "btnFacebook");
			this.btnFacebook.ForeColor = global::System.Drawing.Color.WhiteSmoke;
			this.btnFacebook.Name = "btnFacebook";
			this.btnFacebook.UseVisualStyleBackColor = false;
			this.btnFacebook.Click += new global::System.EventHandler(this.btnFacebook_Click);
			componentResourceManager.ApplyResources(this.lvAllAccounts, "lvAllAccounts");
			this.lvAllAccounts.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.lvAllAccounts.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lvAllAccounts.CheckBoxes = true;
			this.lvAllAccounts.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4,
				this.columnHeader_7,
				this.columnHeader_35
			});
			this.lvAllAccounts.ForeColor = global::System.Drawing.Color.FromArgb(32, 32, 32);
			this.lvAllAccounts.FullRowSelect = true;
			this.lvAllAccounts.GridLines = true;
			this.lvAllAccounts.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvAllAccounts.HideSelection = false;
			this.lvAllAccounts.Int32_1 = -1;
			this.lvAllAccounts.Int32_0 = -1;
			this.lvAllAccounts.Name = "lvAllAccounts";
			this.lvAllAccounts.UseCompatibleStateImageBehavior = false;
			this.lvAllAccounts.View = global::System.Windows.Forms.View.Details;
			this.lvAllAccounts.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.lvAllAccounts_ItemCheck);
			this.lvAllAccounts.SelectedIndexChanged += new global::System.EventHandler(this.lvAllAccounts_SelectedIndexChanged);
			this.lvAllAccounts.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.lvAllAccounts_MouseClick);
			this.lvAllAccounts.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.lvAllAccounts_MouseDoubleClick);
			this.lvAllAccounts.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.lvAllAccounts_MouseDown);
			this.lvAllAccounts.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.lvAllAccounts_MouseMove);
			this.lvAllAccounts.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.lvAllAccounts_MouseUp);
			componentResourceManager.ApplyResources(this.columnHeader_0, "colCharacterName");
			componentResourceManager.ApplyResources(this.columnHeader_1, "colCharacterHP");
			componentResourceManager.ApplyResources(this.columnHeader_2, "colCharacterMP");
			componentResourceManager.ApplyResources(this.columnHeader_3, "colPetHP");
			componentResourceManager.ApplyResources(this.columnHeader_4, "colCharacterMode");
			componentResourceManager.ApplyResources(this.columnHeader_7, "colStatus");
			componentResourceManager.ApplyResources(this.columnHeader_35, "colHidden");
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.btnThuGon);
			base.Controls.Add(this.btnThuCommonGUI);
			base.Controls.Add(this.btnFacebook);
			base.Controls.Add(this.pnelFacebook);
			base.Controls.Add(this.tabDieuKhien);
			base.Controls.Add(this.pnelLog);
			base.Controls.Add(this.lvAllAccounts);
			base.Controls.Add(this.mnuMain);
			base.Controls.Add(this.statusStrip);
			this.DoubleBuffered = true;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.Name = "frmMain";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			base.Load += new global::System.EventHandler(this.frmMain_Load);
			base.Shown += new global::System.EventHandler(this.frmMain_Shown);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
			base.Resize += new global::System.EventHandler(this.frmMain_Resize);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.pnelLog.ResumeLayout(false);
			this.tabDieuKhien.ResumeLayout(false);
			this.tabCoBan.ResumeLayout(false);
			this.groupNgaMi.ResumeLayout(false);
			this.groupNgaMi.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numBuffPhamVi).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBuffPartyPercent).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numNgaMyBuff).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBuffPet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numPhatQuangDelay).EndInit();
			this.groupPhucHoi.ResumeLayout(false);
			this.groupPhucHoi.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPetHPPercent).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numMPPercent).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numHPPercent).EndInit();
			this.groupDanhQuai.ResumeLayout(false);
			this.groupDanhQuai.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numGomMode).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numDistance).EndInit();
			this.groupTheoSau.ResumeLayout(false);
			this.groupTheoSau.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numTheoSau).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numRadius).EndInit();
			this.tabKyNang.ResumeLayout(false);
			this.groupPKSkills.ResumeLayout(false);
			this.groupPKSkills.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPKThoatGame).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numPKSkill).EndInit();
			this.groupSkillBuff.ResumeLayout(false);
			this.groupSkillBuff.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillBuffLength).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillBuffDelay).EndInit();
			this.groupKyNang.ResumeLayout(false);
			this.groupKyNang.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numSkillDelay).EndInit();
			this.tabVatPham.ResumeLayout(false);
			this.tabVatPham.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupItemUse.ResumeLayout(false);
			this.groupItemUse.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numItemUse).EndInit();
			this.groupMuaDo.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.numItemMua).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBanKinhNhat).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numFullThung).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numGiuDoDong).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numGiuDoSao).EndInit();
			this.tabThuongNhan.ResumeLayout(false);
			this.groupThuongNhan.ResumeLayout(false);
			this.groupThuongNhan.PerformLayout();
			this.groupTNThanhMinh.ResumeLayout(false);
			this.groupTNThanhMinh.PerformLayout();
			this.groupTNThanhFriend.ResumeLayout(false);
			this.groupTNThanhFriend.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numTNRounds).EndInit();
			this.tabNhiemVu.ResumeLayout(false);
			this.groupYTO.ResumeLayout(false);
			this.groupYTO.PerformLayout();
			this.groupQ123.ResumeLayout(false);
			this.groupQ123.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numQ12Level).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numQ12ChoPT).EndInit();
			this.groupBaoRuong.ResumeLayout(false);
			this.groupBaoRuong.PerformLayout();
			this.groupQSM.ResumeLayout(false);
			this.groupQSM.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numQSMMax).EndInit();
			this.groupTKC.ResumeLayout(false);
			this.groupTKC.PerformLayout();
			this.groupTBB.ResumeLayout(false);
			this.groupTBB.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numsoHangTrongHoa).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBHDBanKinh).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numBHDMax).EndInit();
			this.groupMuaKNB.ResumeLayout(false);
			this.groupMuaKNB.PerformLayout();
			this.groupLuyenKim.ResumeLayout(false);
			this.groupLuyenKim.PerformLayout();
			this.groupTrungAc.ResumeLayout(false);
			this.groupTrungAc.PerformLayout();
			this.groupAcTac.ResumeLayout(false);
			this.groupAcTac.PerformLayout();
			this.groupDuaHau.ResumeLayout(false);
			this.groupDuaHau.PerformLayout();
			this.groupKhaiKhoang.ResumeLayout(false);
			this.groupKhaiKhoang.PerformLayout();
			this.groupPhuBanTuyChinh.ResumeLayout(false);
			this.groupPhuBanTuyChinh.PerformLayout();
			this.groupScheduler.ResumeLayout(false);
			this.groupScheduler.PerformLayout();
			this.tabTienIch.ResumeLayout(false);
			this.groupDied.ResumeLayout(false);
			this.groupDied.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numChoHoiSinh).EndInit();
			this.groupToDoi.ResumeLayout(false);
			this.groupToDoi.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numPTLevel).EndInit();
			this.groupVeThanh.ResumeLayout(false);
			this.groupVeThanh.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numVeThanhMP).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numVeThanhHP).EndInit();
			this.groupTocDoTrain.ResumeLayout(false);
			this.groupTocDoTrain.PerformLayout();
			this.groupTuyChon.ResumeLayout(false);
			this.groupTuyChon.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numShutdownM).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numShutdownH).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numUpLevel).EndInit();
			this.groupChat.ResumeLayout(false);
			this.groupChat.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numAutoChat).EndInit();
			this.tabDebug.ResumeLayout(false);
			this.tabDebug.PerformLayout();
			this.tabDebugBoc.ResumeLayout(false);
			this.tabPhat.ResumeLayout(false);
			this.groupPhat.ResumeLayout(false);
			this.groupPhat.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numGroupID).EndInit();
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.contextTray.ResumeLayout(false);
			this.contextUserList.ResumeLayout(false);
			this.contextProcessList.ResumeLayout(false);
			this.pnelFacebook.ResumeLayout(false);
			this.pnelFacebook.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000FD1 RID: 4049
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000FD2 RID: 4050
		private global::System.Windows.Forms.StatusStrip statusStrip;

		// Token: 0x04000FD3 RID: 4051
		private global::System.Windows.Forms.ToolStripStatusLabel lblLocation;

		// Token: 0x04000FD4 RID: 4052
		private global::System.Windows.Forms.ToolStripStatusLabel lblCharLoc;

		// Token: 0x04000FD5 RID: 4053
		private global::ns0.GClass3 lvAllAccounts;

		// Token: 0x04000FD6 RID: 4054
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000FD7 RID: 4055
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000FD8 RID: 4056
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000FD9 RID: 4057
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000FDA RID: 4058
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x04000FDB RID: 4059
		private global::System.Windows.Forms.TabPage tabCoBan;

		// Token: 0x04000FDC RID: 4060
		private global::System.Windows.Forms.ComboBox AIModes;

		// Token: 0x04000FDD RID: 4061
		private global::System.Windows.Forms.GroupBox groupDanhQuai;

		// Token: 0x04000FDE RID: 4062
		private global::System.Windows.Forms.ComboBox cboTrainMaps;

		// Token: 0x04000FDF RID: 4063
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000FE0 RID: 4064
		private global::System.Windows.Forms.Button btnGetCurrentPos;

		// Token: 0x04000FE1 RID: 4065
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000FE2 RID: 4066
		private global::System.Windows.Forms.RadioButton modeTUNGCON;

		// Token: 0x04000FE3 RID: 4067
		private global::System.Windows.Forms.GroupBox groupKhaiKhoang;

		// Token: 0x04000FE4 RID: 4068
		private global::System.Windows.Forms.ComboBox cboKhoangDuocMaps;

		// Token: 0x04000FE5 RID: 4069
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000FE6 RID: 4070
		private global::System.Windows.Forms.CheckBox cboxHaiDuoc;

		// Token: 0x04000FE7 RID: 4071
		private global::System.Windows.Forms.CheckBox cboxKhaiKhoang;

		// Token: 0x04000FE8 RID: 4072
		private global::System.Windows.Forms.GroupBox groupDied;

		// Token: 0x04000FE9 RID: 4073
		private global::System.Windows.Forms.RadioButton rdioLenDiemTrain;

		// Token: 0x04000FEA RID: 4074
		private global::System.Windows.Forms.CheckBox cboTTThuHoach;

		// Token: 0x04000FEB RID: 4075
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000FEC RID: 4076
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000FED RID: 4077
		private global::System.Windows.Forms.ComboBox cboTTLoai;

		// Token: 0x04000FEE RID: 4078
		private global::System.Windows.Forms.TabPage tabKyNang;

		// Token: 0x04000FEF RID: 4079
		private global::System.Windows.Forms.TabPage tabVatPham;

		// Token: 0x04000FF0 RID: 4080
		private global::System.Windows.Forms.TabPage tabThuongNhan;

		// Token: 0x04000FF1 RID: 4081
		private global::System.Windows.Forms.GroupBox groupNgaMi;

		// Token: 0x04000FF2 RID: 4082
		private global::System.Windows.Forms.GroupBox groupPhucHoi;

		// Token: 0x04000FF3 RID: 4083
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000FF4 RID: 4084
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000FF5 RID: 4085
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000FF6 RID: 4086
		private global::System.Windows.Forms.CheckBox cboxHuyetTe;

		// Token: 0x04000FF7 RID: 4087
		private global::System.Windows.Forms.CheckBox cboxCongSinh;

		// Token: 0x04000FF8 RID: 4088
		private global::System.Windows.Forms.MenuStrip mnuMain;

		// Token: 0x04000FF9 RID: 4089
		private global::System.Windows.Forms.ToolStripMenuItem itemSystem;

		// Token: 0x04000FFA RID: 4090
		private global::System.Windows.Forms.ToolStripMenuItem itemUserInfo;

		// Token: 0x04000FFB RID: 4091
		private global::System.Windows.Forms.ToolStripMenuItem itemRenew;

		// Token: 0x04000FFC RID: 4092
		private global::System.Windows.Forms.ToolStripSeparator itemSysSep2;

		// Token: 0x04000FFD RID: 4093
		private global::System.Windows.Forms.ToolStripMenuItem itemExit;

		// Token: 0x04000FFE RID: 4094
		private global::System.Windows.Forms.ToolStripMenuItem itemHelp;

		// Token: 0x04000FFF RID: 4095
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04001000 RID: 4096
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04001001 RID: 4097
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04001002 RID: 4098
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04001003 RID: 4099
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04001004 RID: 4100
		private global::System.Windows.Forms.TabPage tabTienIch;

		// Token: 0x04001005 RID: 4101
		private global::System.Windows.Forms.CheckBox cboxBuffPet;

		// Token: 0x04001006 RID: 4102
		private global::System.Windows.Forms.CheckBox cboxPhatQuangPhoChieu;

		// Token: 0x04001007 RID: 4103
		private global::System.Windows.Forms.NumericUpDown numDistance;

		// Token: 0x04001008 RID: 4104
		private global::System.Windows.Forms.NumericUpDown numRadius;

		// Token: 0x04001009 RID: 4105
		private global::System.Windows.Forms.NumericUpDown numMPPercent;

		// Token: 0x0400100A RID: 4106
		private global::System.Windows.Forms.NumericUpDown numHPPercent;

		// Token: 0x0400100B RID: 4107
		private global::System.Windows.Forms.NumericUpDown numPetHPPercent;

		// Token: 0x0400100C RID: 4108
		private global::System.Windows.Forms.CheckBox cboxTuNhatVatPham;

		// Token: 0x0400100D RID: 4109
		internal global::System.Windows.Forms.TextBox txtToaDoX;

		// Token: 0x0400100E RID: 4110
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x0400100F RID: 4111
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04001010 RID: 4112
		internal global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04001011 RID: 4113
		private global::System.Windows.Forms.ContextMenuStrip contextTray;

		// Token: 0x04001012 RID: 4114
		private global::System.Windows.Forms.ContextMenuStrip contextUserList;

		// Token: 0x04001013 RID: 4115
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04001014 RID: 4116
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04001015 RID: 4117
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04001016 RID: 4118
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04001017 RID: 4119
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04001018 RID: 4120
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x04001019 RID: 4121
		internal global::System.Windows.Forms.TextBox txtToaDoY;

		// Token: 0x0400101A RID: 4122
		private global::System.Windows.Forms.ContextMenuStrip contextProcessList;

		// Token: 0x0400101B RID: 4123
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x0400101C RID: 4124
		private global::System.Windows.Forms.ToolStripMenuItem menuThoatGameNhanh;

		// Token: 0x0400101D RID: 4125
		private global::System.Windows.Forms.NumericUpDown numBuffPet;

		// Token: 0x0400101E RID: 4126
		private global::System.Windows.Forms.NumericUpDown numPhatQuangDelay;

		// Token: 0x0400101F RID: 4127
		private global::System.Windows.Forms.NumericUpDown numNgaMyBuff;

		// Token: 0x04001020 RID: 4128
		private global::System.Windows.Forms.Label label32;

		// Token: 0x04001021 RID: 4129
		private global::System.Windows.Forms.CheckBox cboxTuUpLevel;

		// Token: 0x04001022 RID: 4130
		private global::System.Windows.Forms.NumericUpDown numUpLevel;

		// Token: 0x04001023 RID: 4131
		private global::System.Windows.Forms.ToolStripStatusLabel imgBuyHour;

		// Token: 0x04001024 RID: 4132
		private global::System.Windows.Forms.NumericUpDown numBuffPartyPercent;

		// Token: 0x04001025 RID: 4133
		private global::System.Windows.Forms.ComboBox cboPetChien;

		// Token: 0x04001026 RID: 4134
		private global::System.Windows.Forms.ComboBox cboPetHuyetTe;

		// Token: 0x04001027 RID: 4135
		private global::System.Windows.Forms.ComboBox cboPetCongSinh;

		// Token: 0x04001028 RID: 4136
		private global::System.Windows.Forms.Label lblNMPQSecond;

		// Token: 0x04001029 RID: 4137
		private global::System.Windows.Forms.GroupBox groupMuaDo;

		// Token: 0x0400102A RID: 4138
		private global::System.Windows.Forms.ListView lvItemMua;

		// Token: 0x0400102B RID: 4139
		private global::System.Windows.Forms.NumericUpDown numItemMua;

		// Token: 0x0400102C RID: 4140
		private global::System.Windows.Forms.Button btnItemMuaThem;

		// Token: 0x0400102D RID: 4141
		private global::System.Windows.Forms.ComboBox cboItemMua;

		// Token: 0x0400102E RID: 4142
		private global::System.Windows.Forms.CheckBox cboxVutDoKhiFull;

		// Token: 0x0400102F RID: 4143
		private global::System.Windows.Forms.NumericUpDown numGiuDoDong;

		// Token: 0x04001030 RID: 4144
		private global::System.Windows.Forms.Label label41;

		// Token: 0x04001031 RID: 4145
		private global::System.Windows.Forms.NumericUpDown numGiuDoSao;

		// Token: 0x04001032 RID: 4146
		private global::System.Windows.Forms.Label label40;

		// Token: 0x04001033 RID: 4147
		private global::System.Windows.Forms.CheckBox cboxTuMuaBan;

		// Token: 0x04001034 RID: 4148
		private global::System.Windows.Forms.ColumnHeader columnHeader_5;

		// Token: 0x04001035 RID: 4149
		private global::System.Windows.Forms.ColumnHeader columnHeader_6;

		// Token: 0x04001036 RID: 4150
		private global::System.Windows.Forms.GroupBox groupVeThanh;

		// Token: 0x04001037 RID: 4151
		private global::System.Windows.Forms.NumericUpDown numVeThanhMP;

		// Token: 0x04001038 RID: 4152
		private global::System.Windows.Forms.NumericUpDown numVeThanhHP;

		// Token: 0x04001039 RID: 4153
		private global::System.Windows.Forms.CheckBox cboxVeThanhHetThucAn;

		// Token: 0x0400103A RID: 4154
		private global::System.Windows.Forms.Label label21;

		// Token: 0x0400103B RID: 4155
		private global::System.Windows.Forms.ComboBox cboThanhQuayVe;

		// Token: 0x0400103C RID: 4156
		private global::System.Windows.Forms.Label label22;

		// Token: 0x0400103D RID: 4157
		private global::System.Windows.Forms.Label label25;

		// Token: 0x0400103E RID: 4158
		private global::System.Windows.Forms.CheckBox cboVeThanh;

		// Token: 0x0400103F RID: 4159
		private global::System.Windows.Forms.Label label29;

		// Token: 0x04001040 RID: 4160
		private global::System.Windows.Forms.ColumnHeader columnHeader_7;

		// Token: 0x04001041 RID: 4161
		private global::System.Windows.Forms.TabPage tabDebug;

		// Token: 0x04001042 RID: 4162
		private global::System.Windows.Forms.Label lblDebugInfo;

		// Token: 0x04001043 RID: 4163
		private global::System.Windows.Forms.ListView lvQuai;

		// Token: 0x04001044 RID: 4164
		private global::System.Windows.Forms.ColumnHeader columnHeader_8;

		// Token: 0x04001045 RID: 4165
		private global::System.Windows.Forms.ColumnHeader columnHeader_9;

		// Token: 0x04001046 RID: 4166
		private global::System.Windows.Forms.ColumnHeader columnHeader_10;

		// Token: 0x04001047 RID: 4167
		private global::System.Windows.Forms.ColumnHeader columnHeader_11;

		// Token: 0x04001048 RID: 4168
		private global::System.Windows.Forms.ColumnHeader columnHeader_12;

		// Token: 0x04001049 RID: 4169
		private global::System.Windows.Forms.ColumnHeader columnHeader_13;

		// Token: 0x0400104A RID: 4170
		private global::System.Windows.Forms.Label lblTotalQuai;

		// Token: 0x0400104B RID: 4171
		private global::System.Windows.Forms.TabPage tabDebugBoc;

		// Token: 0x0400104C RID: 4172
		private global::System.Windows.Forms.ListView lvItems;

		// Token: 0x0400104D RID: 4173
		private global::System.Windows.Forms.ColumnHeader columnHeader_14;

		// Token: 0x0400104E RID: 4174
		private global::System.Windows.Forms.ColumnHeader columnHeader_15;

		// Token: 0x0400104F RID: 4175
		private global::System.Windows.Forms.ColumnHeader columnHeader_16;

		// Token: 0x04001050 RID: 4176
		private global::System.Windows.Forms.ColumnHeader columnHeader_17;

		// Token: 0x04001051 RID: 4177
		private global::System.Windows.Forms.Label lblTotalBoc;

		// Token: 0x04001052 RID: 4178
		private global::System.Windows.Forms.Label lblItems;

		// Token: 0x04001053 RID: 4179
		private global::System.Windows.Forms.Label lblActiveBocID;

		// Token: 0x04001054 RID: 4180
		private global::System.Windows.Forms.ListView lvAllBoc;

		// Token: 0x04001055 RID: 4181
		private global::System.Windows.Forms.ColumnHeader columnHeader_18;

		// Token: 0x04001056 RID: 4182
		private global::System.Windows.Forms.ColumnHeader columnHeader_19;

		// Token: 0x04001057 RID: 4183
		private global::System.Windows.Forms.ColumnHeader columnHeader_20;

		// Token: 0x04001058 RID: 4184
		private global::System.Windows.Forms.ColumnHeader columnHeader_21;

		// Token: 0x04001059 RID: 4185
		private global::System.Windows.Forms.ColumnHeader columnHeader_22;

		// Token: 0x0400105A RID: 4186
		private global::System.Windows.Forms.ToolStripStatusLabel lblRemainHours;

		// Token: 0x0400105B RID: 4187
		private global::System.Windows.Forms.GroupBox groupKyNang;

		// Token: 0x0400105C RID: 4188
		private global::System.Windows.Forms.Label label28;

		// Token: 0x0400105D RID: 4189
		private global::System.Windows.Forms.Label label27;

		// Token: 0x0400105E RID: 4190
		private global::System.Windows.Forms.NumericUpDown numSkillDelay;

		// Token: 0x0400105F RID: 4191
		private global::System.Windows.Forms.ComboBox cboSkills;

		// Token: 0x04001060 RID: 4192
		private global::System.Windows.Forms.Button btnXoaSkillPlayList;

		// Token: 0x04001061 RID: 4193
		private global::System.Windows.Forms.Button btnSuaSkillPlayList;

		// Token: 0x04001062 RID: 4194
		private global::System.Windows.Forms.Button btnThemSkill;

		// Token: 0x04001063 RID: 4195
		private global::System.Windows.Forms.ListView lvSkills;

		// Token: 0x04001064 RID: 4196
		private global::System.Windows.Forms.ColumnHeader columnHeader_23;

		// Token: 0x04001065 RID: 4197
		private global::System.Windows.Forms.ColumnHeader columnHeader_24;

		// Token: 0x04001066 RID: 4198
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x04001067 RID: 4199
		private global::System.Windows.Forms.GroupBox groupChat;

		// Token: 0x04001068 RID: 4200
		private global::System.Windows.Forms.Button btnSendChat;

		// Token: 0x04001069 RID: 4201
		private global::System.Windows.Forms.CheckBox cboxHelpChat;

		// Token: 0x0400106A RID: 4202
		private global::System.Windows.Forms.ComboBox cboKenhChat;

		// Token: 0x0400106B RID: 4203
		private global::System.Windows.Forms.RichTextBox richChat;

		// Token: 0x0400106C RID: 4204
		private global::System.Windows.Forms.NumericUpDown numAutoChat;

		// Token: 0x0400106D RID: 4205
		private global::System.Windows.Forms.CheckBox cboxAutoChat;

		// Token: 0x0400106E RID: 4206
		private global::System.Windows.Forms.Label lblNextChat;

		// Token: 0x0400106F RID: 4207
		private global::System.Windows.Forms.Label lbChatTimes;

		// Token: 0x04001070 RID: 4208
		private global::System.Windows.Forms.GroupBox groupThuongNhan;

		// Token: 0x04001071 RID: 4209
		private global::System.Windows.Forms.Button btnTNChayVe;

		// Token: 0x04001072 RID: 4210
		private global::System.Windows.Forms.Button btnTNChayDi;

		// Token: 0x04001073 RID: 4211
		internal global::System.Windows.Forms.TextBox tboxIDFriend;

		// Token: 0x04001074 RID: 4212
		private global::System.Windows.Forms.CheckBox cboxTNFullAuto;

		// Token: 0x04001075 RID: 4213
		internal global::System.Windows.Forms.TextBox tboxIDBang;

		// Token: 0x04001076 RID: 4214
		private global::System.Windows.Forms.Button btnTNStop;

		// Token: 0x04001077 RID: 4215
		private global::System.Windows.Forms.Button btnLenBai;

		// Token: 0x04001078 RID: 4216
		private global::System.Windows.Forms.NumericUpDown numTNRounds;

		// Token: 0x04001079 RID: 4217
		private global::System.Windows.Forms.Label label46;

		// Token: 0x0400107A RID: 4218
		private global::System.Windows.Forms.CheckBox cboxVeThanhHetBNM;

		// Token: 0x0400107B RID: 4219
		private global::System.Windows.Forms.ComboBox cboPetFoodType;

		// Token: 0x0400107C RID: 4220
		private global::System.Windows.Forms.Label lblPath;

		// Token: 0x0400107D RID: 4221
		private global::System.Windows.Forms.CheckBox cboItemTuHuy;

		// Token: 0x0400107E RID: 4222
		private global::System.Windows.Forms.CheckBox cboxTNTuNhanPhieu;

		// Token: 0x0400107F RID: 4223
		private global::System.Windows.Forms.CheckBox cboxTNAlert;

		// Token: 0x04001080 RID: 4224
		private global::System.Windows.Forms.CheckBox cboxTNAlertPK;

		// Token: 0x04001081 RID: 4225
		private global::System.Windows.Forms.Button btnChayHuongNao;

		// Token: 0x04001082 RID: 4226
		private global::System.Windows.Forms.CheckBox cboxAnHienGame;

		// Token: 0x04001083 RID: 4227
		private global::System.Windows.Forms.NumericUpDown numFullThung;

		// Token: 0x04001084 RID: 4228
		private global::System.Windows.Forms.CheckBox cboxFullStopNhat;

		// Token: 0x04001085 RID: 4229
		private global::System.Windows.Forms.CheckBox cboxFullThungVT;

		// Token: 0x04001086 RID: 4230
		private global::System.Windows.Forms.CheckBox cboxCaptchaReset;

		// Token: 0x04001087 RID: 4231
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04001088 RID: 4232
		private global::System.Windows.Forms.ComboBox comboBox5;

		// Token: 0x04001089 RID: 4233
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x0400108A RID: 4234
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;

		// Token: 0x0400108B RID: 4235
		private global::System.Windows.Forms.TabPage tabNhiemVu;

		// Token: 0x0400108C RID: 4236
		private global::System.Windows.Forms.RadioButton rdioGomQuai;

		// Token: 0x0400108D RID: 4237
		private global::System.Windows.Forms.Label label26;

		// Token: 0x0400108E RID: 4238
		private global::System.Windows.Forms.CheckBox cboxTheoSau;

		// Token: 0x0400108F RID: 4239
		private global::System.Windows.Forms.Label label35;

		// Token: 0x04001090 RID: 4240
		private global::System.Windows.Forms.Button btnTrieuTap;

		// Token: 0x04001091 RID: 4241
		private global::System.Windows.Forms.Button btnMoiDoi;

		// Token: 0x04001092 RID: 4242
		private global::System.Windows.Forms.Button btnXoaDuLieuTN;

		// Token: 0x04001093 RID: 4243
		private global::System.Windows.Forms.CheckBox cboxChayNhanh;

		// Token: 0x04001094 RID: 4244
		private global::System.Windows.Forms.CheckBox cboxSupportLog;

		// Token: 0x04001095 RID: 4245
		private global::System.Windows.Forms.Button btnHoiSucLenBai;

		// Token: 0x04001096 RID: 4246
		private global::System.Windows.Forms.RadioButton rdioThoatGame;

		// Token: 0x04001097 RID: 4247
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;

		// Token: 0x04001098 RID: 4248
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x04001099 RID: 4249
		private global::System.Windows.Forms.CheckBox cboxTuVaoPT;

		// Token: 0x0400109A RID: 4250
		private global::System.Windows.Forms.GroupBox groupSkillBuff;

		// Token: 0x0400109B RID: 4251
		private global::System.Windows.Forms.CheckBox cboxBuffQuanDoan;

		// Token: 0x0400109C RID: 4252
		private global::System.Windows.Forms.CheckBox cboxBuffDanhSach;

		// Token: 0x0400109D RID: 4253
		private global::System.Windows.Forms.CheckBox cboxBuffDongDoi;

		// Token: 0x0400109E RID: 4254
		private global::System.Windows.Forms.CheckBox cboxBuffBanThan;

		// Token: 0x0400109F RID: 4255
		private global::System.Windows.Forms.Label label49;

		// Token: 0x040010A0 RID: 4256
		private global::System.Windows.Forms.Label label36;

		// Token: 0x040010A1 RID: 4257
		private global::System.Windows.Forms.NumericUpDown numSkillBuffDelay;

		// Token: 0x040010A2 RID: 4258
		private global::System.Windows.Forms.ComboBox cboSkillBuff;

		// Token: 0x040010A3 RID: 4259
		private global::System.Windows.Forms.Button btnSkillBuffDelete;

		// Token: 0x040010A4 RID: 4260
		private global::System.Windows.Forms.Button btnSkillBuffThem;

		// Token: 0x040010A5 RID: 4261
		private global::System.Windows.Forms.ListView lvSkillBuff;

		// Token: 0x040010A6 RID: 4262
		private global::System.Windows.Forms.ColumnHeader columnHeader_25;

		// Token: 0x040010A7 RID: 4263
		private global::System.Windows.Forms.ColumnHeader columnHeader_26;

		// Token: 0x040010A8 RID: 4264
		private global::System.Windows.Forms.ColumnHeader columnHeader_27;

		// Token: 0x040010A9 RID: 4265
		private global::System.Windows.Forms.ColumnHeader columnHeader_28;

		// Token: 0x040010AA RID: 4266
		private global::System.Windows.Forms.ColumnHeader columnHeader_29;

		// Token: 0x040010AB RID: 4267
		private global::System.Windows.Forms.CheckBox cboxCanX2;

		// Token: 0x040010AC RID: 4268
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;

		// Token: 0x040010AD RID: 4269
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x040010AE RID: 4270
		private global::System.Windows.Forms.Panel pnelLog;

		// Token: 0x040010AF RID: 4271
		internal global::System.Windows.Forms.RichTextBox richLog;

		// Token: 0x040010B0 RID: 4272
		private global::System.Windows.Forms.CheckBox cboxCanX4;

		// Token: 0x040010B1 RID: 4273
		private global::System.Windows.Forms.CheckBox cboxNMBuffQuanDoan;

		// Token: 0x040010B2 RID: 4274
		private global::System.Windows.Forms.CheckBox cboxNMBuffList;

		// Token: 0x040010B3 RID: 4275
		private global::System.Windows.Forms.Label lblNMParty;

		// Token: 0x040010B4 RID: 4276
		private global::System.Windows.Forms.NumericUpDown numTheoSau;

		// Token: 0x040010B5 RID: 4277
		private global::System.Windows.Forms.CheckBox cboxKhongResetGio;

		// Token: 0x040010B6 RID: 4278
		private global::System.Windows.Forms.ColumnHeader columnHeader_30;

		// Token: 0x040010B7 RID: 4279
		private global::System.Windows.Forms.GroupBox groupPKSkills;

		// Token: 0x040010B8 RID: 4280
		private global::System.Windows.Forms.CheckBox cboxPKTuVe;

		// Token: 0x040010B9 RID: 4281
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040010BA RID: 4282
		private global::System.Windows.Forms.Label label52;

		// Token: 0x040010BB RID: 4283
		private global::System.Windows.Forms.NumericUpDown numPKSkill;

		// Token: 0x040010BC RID: 4284
		private global::System.Windows.Forms.ComboBox cboPKSkills;

		// Token: 0x040010BD RID: 4285
		private global::System.Windows.Forms.Button btnPKRemove;

		// Token: 0x040010BE RID: 4286
		private global::System.Windows.Forms.Button btnPKEdit;

		// Token: 0x040010BF RID: 4287
		private global::System.Windows.Forms.Button btnPKThem;

		// Token: 0x040010C0 RID: 4288
		private global::System.Windows.Forms.ListView lvPKSkills;

		// Token: 0x040010C1 RID: 4289
		private global::System.Windows.Forms.ColumnHeader columnHeader_31;

		// Token: 0x040010C2 RID: 4290
		private global::System.Windows.Forms.ColumnHeader columnHeader_32;

		// Token: 0x040010C3 RID: 4291
		private global::System.Windows.Forms.ColumnHeader columnHeader_33;

		// Token: 0x040010C4 RID: 4292
		private global::System.Windows.Forms.Label label55;

		// Token: 0x040010C5 RID: 4293
		private global::System.Windows.Forms.Label label54;

		// Token: 0x040010C6 RID: 4294
		private global::System.Windows.Forms.Label label53;

		// Token: 0x040010C7 RID: 4295
		private global::System.Windows.Forms.NumericUpDown numSkillBuffLength;

		// Token: 0x040010C8 RID: 4296
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040010C9 RID: 4297
		private global::System.Windows.Forms.CheckBox cboxThoLinhChau;

		// Token: 0x040010CA RID: 4298
		private global::System.Windows.Forms.Label label42;

		// Token: 0x040010CB RID: 4299
		private global::System.Windows.Forms.NumericUpDown numChoHoiSinh;

		// Token: 0x040010CC RID: 4300
		private global::System.Windows.Forms.CheckBox cboxChoHoiSinh;

		// Token: 0x040010CD RID: 4301
		private global::System.Windows.Forms.ComboBox cboTTTen;

		// Token: 0x040010CE RID: 4302
		private global::System.Windows.Forms.Button btnTTNPC2Add;

		// Token: 0x040010CF RID: 4303
		private global::System.Windows.Forms.Button btnTTNPC1Add;

		// Token: 0x040010D0 RID: 4304
		internal global::System.Windows.Forms.TextBox txtTTNPC2_Y;

		// Token: 0x040010D1 RID: 4305
		internal global::System.Windows.Forms.TextBox txtTTNPC2_X;

		// Token: 0x040010D2 RID: 4306
		internal global::System.Windows.Forms.TextBox txtTTNPC2_ID;

		// Token: 0x040010D3 RID: 4307
		internal global::System.Windows.Forms.TextBox txtTTNPC1_Y;

		// Token: 0x040010D4 RID: 4308
		internal global::System.Windows.Forms.TextBox txtTTNPC1_X;

		// Token: 0x040010D5 RID: 4309
		private global::System.Windows.Forms.Label label58;

		// Token: 0x040010D6 RID: 4310
		private global::System.Windows.Forms.Label label57;

		// Token: 0x040010D7 RID: 4311
		internal global::System.Windows.Forms.TextBox txtTTNPC1_ID;

		// Token: 0x040010D8 RID: 4312
		private global::System.Windows.Forms.Label lblTTCity;

		// Token: 0x040010D9 RID: 4313
		private global::System.Windows.Forms.Label lblTTTime;

		// Token: 0x040010DA RID: 4314
		private global::System.Windows.Forms.Button btnPhatTest3;

		// Token: 0x040010DB RID: 4315
		private global::System.Windows.Forms.ComboBox cboxPhatTest3;

		// Token: 0x040010DC RID: 4316
		private global::System.Windows.Forms.Button btnPhatTest2;

		// Token: 0x040010DD RID: 4317
		private global::System.Windows.Forms.ComboBox cboxPhatTest2;

		// Token: 0x040010DE RID: 4318
		private global::System.Windows.Forms.Button btnResetKhoangDuoc;

		// Token: 0x040010DF RID: 4319
		private global::System.Windows.Forms.CheckBox cboxKhoangDuoc;

		// Token: 0x040010E0 RID: 4320
		private global::System.Windows.Forms.CheckBox cboxATAB;

		// Token: 0x040010E1 RID: 4321
		private global::System.Windows.Forms.GroupBox groupDuaHau;

		// Token: 0x040010E2 RID: 4322
		private global::System.Windows.Forms.Button btnDuaHauStart;

		// Token: 0x040010E3 RID: 4323
		private global::System.Windows.Forms.ComboBox cboxDuaHauMaps;

		// Token: 0x040010E4 RID: 4324
		private global::System.Windows.Forms.Label label59;

		// Token: 0x040010E5 RID: 4325
		private global::System.Windows.Forms.CheckBox cboDHFromCity;

		// Token: 0x040010E6 RID: 4326
		private global::System.Windows.Forms.CheckBox cboDHAutoPick;

		// Token: 0x040010E7 RID: 4327
		private global::System.Windows.Forms.CheckBox cboDHAutoNV;

		// Token: 0x040010E8 RID: 4328
		private global::System.Windows.Forms.CheckBox cboDHAlertTuu;

		// Token: 0x040010E9 RID: 4329
		internal global::System.Windows.Forms.TextBox txtDHBangID;

		// Token: 0x040010EA RID: 4330
		private global::System.Windows.Forms.Label label60;

		// Token: 0x040010EB RID: 4331
		private global::System.Windows.Forms.ComboBox cboxDuaHauCity;

		// Token: 0x040010EC RID: 4332
		private global::System.Windows.Forms.Button btnSearchNPC;

		// Token: 0x040010ED RID: 4333
		private global::System.Windows.Forms.CheckBox cboxNMPKBuff;

		// Token: 0x040010EE RID: 4334
		private global::System.Windows.Forms.GroupBox groupAcTac;

		// Token: 0x040010EF RID: 4335
		private global::System.Windows.Forms.ComboBox cboATMaps;

		// Token: 0x040010F0 RID: 4336
		private global::System.Windows.Forms.Label label62;

		// Token: 0x040010F1 RID: 4337
		private global::System.Windows.Forms.GroupBox groupTNThanhFriend;

		// Token: 0x040010F2 RID: 4338
		private global::System.Windows.Forms.CheckBox cboxTNFriendGiaHigher;

		// Token: 0x040010F3 RID: 4339
		internal global::System.Windows.Forms.TextBox txtTNFriendGia;

		// Token: 0x040010F4 RID: 4340
		private global::System.Windows.Forms.Label lblTNFriendGia;

		// Token: 0x040010F5 RID: 4341
		private global::System.Windows.Forms.ComboBox cboTNFriendItem;

		// Token: 0x040010F6 RID: 4342
		private global::System.Windows.Forms.Label label65;

		// Token: 0x040010F7 RID: 4343
		private global::System.Windows.Forms.RadioButton rdioTNTheoChiDinh;

		// Token: 0x040010F8 RID: 4344
		private global::System.Windows.Forms.RadioButton rdioTNAutoMua;

		// Token: 0x040010F9 RID: 4345
		private global::System.Windows.Forms.GroupBox groupTNThanhMinh;

		// Token: 0x040010FA RID: 4346
		private global::System.Windows.Forms.CheckBox cboxTNMinhGiaHigher;

		// Token: 0x040010FB RID: 4347
		internal global::System.Windows.Forms.TextBox txtTNMinhGiaHigher;

		// Token: 0x040010FC RID: 4348
		private global::System.Windows.Forms.Label lblTNMinhGia;

		// Token: 0x040010FD RID: 4349
		private global::System.Windows.Forms.ComboBox cboTNMinhItem;

		// Token: 0x040010FE RID: 4350
		private global::System.Windows.Forms.Label label69;

		// Token: 0x040010FF RID: 4351
		private global::System.Windows.Forms.Button btnListNMBuff;

		// Token: 0x04001100 RID: 4352
		private global::System.Windows.Forms.CheckBox cboxBuffHoTroOnOff;

		// Token: 0x04001101 RID: 4353
		private global::System.Windows.Forms.CheckBox cboxTNRunOnly;

		// Token: 0x04001102 RID: 4354
		private global::System.Windows.Forms.CheckBox cboxSkillOnOff;

		// Token: 0x04001103 RID: 4355
		private global::System.Windows.Forms.RadioButton rdioTheoSauPT;

		// Token: 0x04001104 RID: 4356
		private global::System.Windows.Forms.TextBox txtTheoSauName;

		// Token: 0x04001105 RID: 4357
		private global::System.Windows.Forms.RadioButton rdioTheoSauAiDo;

		// Token: 0x04001106 RID: 4358
		private global::System.Windows.Forms.GroupBox groupTocDoTrain;

		// Token: 0x04001107 RID: 4359
		private global::System.Windows.Forms.Label lblTrainSpeed2;

		// Token: 0x04001108 RID: 4360
		private global::System.Windows.Forms.Label lblTrainSpeed;

		// Token: 0x04001109 RID: 4361
		private global::System.Windows.Forms.ComboBox cboTrainExpMode;

		// Token: 0x0400110A RID: 4362
		private global::System.Windows.Forms.Button btnTrainExpReset;

		// Token: 0x0400110B RID: 4363
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x0400110C RID: 4364
		private global::System.Windows.Forms.Label lblTrainSpeed3;

		// Token: 0x0400110D RID: 4365
		private global::System.Windows.Forms.Label lblTrainSpeed4;

		// Token: 0x0400110E RID: 4366
		private global::System.Windows.Forms.Label lblTimeOnline;

		// Token: 0x0400110F RID: 4367
		private global::System.Windows.Forms.Panel pnelFacebook;

		// Token: 0x04001110 RID: 4368
		private global::System.Windows.Forms.RadioButton rdioDanhTheoKey;

		// Token: 0x04001111 RID: 4369
		internal global::System.Windows.Forms.TabControl tabDieuKhien;

		// Token: 0x04001112 RID: 4370
		private global::System.Windows.Forms.TextBox txtPassCap2;

		// Token: 0x04001113 RID: 4371
		private global::System.Windows.Forms.CheckBox cboxPassCap2;

		// Token: 0x04001114 RID: 4372
		private global::System.Windows.Forms.GroupBox groupToDoi;

		// Token: 0x04001115 RID: 4373
		private global::System.Windows.Forms.Button btnUpdate;

		// Token: 0x04001116 RID: 4374
		private global::System.Windows.Forms.CheckBox cboxTuClickYes;

		// Token: 0x04001117 RID: 4375
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x04001118 RID: 4376
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;

		// Token: 0x04001119 RID: 4377
		private global::System.Windows.Forms.ToolStripMenuItem mnuTrayShutdownNoGame;

		// Token: 0x0400111A RID: 4378
		private global::System.Windows.Forms.Label label66;

		// Token: 0x0400111B RID: 4379
		private global::System.Windows.Forms.NumericUpDown numPKThoatGame;

		// Token: 0x0400111C RID: 4380
		private global::System.Windows.Forms.CheckBox cboxPKThoatGame;

		// Token: 0x0400111D RID: 4381
		private global::System.Windows.Forms.GroupBox groupTrungAc;

		// Token: 0x0400111E RID: 4382
		private global::System.Windows.Forms.CheckBox cboxTANhanNV;

		// Token: 0x0400111F RID: 4383
		private global::System.Windows.Forms.CheckBox cboxTAHoiPhuc;

		// Token: 0x04001120 RID: 4384
		private global::System.Windows.Forms.GroupBox groupLuyenKim;

		// Token: 0x04001121 RID: 4385
		private global::System.Windows.Forms.CheckBox cboxLKTuNhanNV;

		// Token: 0x04001122 RID: 4386
		private global::System.Windows.Forms.GroupBox groupMuaKNB;

		// Token: 0x04001123 RID: 4387
		private global::System.Windows.Forms.Label label73;

		// Token: 0x04001124 RID: 4388
		internal global::System.Windows.Forms.TextBox txtKNB500;

		// Token: 0x04001125 RID: 4389
		private global::System.Windows.Forms.Label label74;

		// Token: 0x04001126 RID: 4390
		private global::System.Windows.Forms.Label label71;

		// Token: 0x04001127 RID: 4391
		internal global::System.Windows.Forms.TextBox txtKNB200;

		// Token: 0x04001128 RID: 4392
		private global::System.Windows.Forms.Label label72;

		// Token: 0x04001129 RID: 4393
		private global::System.Windows.Forms.Label label70;

		// Token: 0x0400112A RID: 4394
		internal global::System.Windows.Forms.TextBox txtKNB50;

		// Token: 0x0400112B RID: 4395
		private global::System.Windows.Forms.Label label68;

		// Token: 0x0400112C RID: 4396
		private global::System.Windows.Forms.Button btnMuaKNB;

		// Token: 0x0400112D RID: 4397
		private global::System.Windows.Forms.CheckBox cboxLuyenKimCham;

		// Token: 0x0400112E RID: 4398
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400112F RID: 4399
		private global::System.Windows.Forms.Button btnListTuHuy;

		// Token: 0x04001130 RID: 4400
		private global::System.Windows.Forms.Button btnItemTuBan;

		// Token: 0x04001131 RID: 4401
		private global::System.Windows.Forms.Button btnPTAcceptList;

		// Token: 0x04001132 RID: 4402
		private global::System.Windows.Forms.Button btnFacebook;

		// Token: 0x04001133 RID: 4403
		private global::System.Windows.Forms.Button btnPTBlacklist;

		// Token: 0x04001134 RID: 4404
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04001135 RID: 4405
		private global::System.Windows.Forms.NumericUpDown numPTLevel;

		// Token: 0x04001136 RID: 4406
		private global::System.Windows.Forms.Button btnPTChoVao;

		// Token: 0x04001137 RID: 4407
		private global::System.Windows.Forms.CheckBox cboxPTChoVao;

		// Token: 0x04001138 RID: 4408
		private global::System.Windows.Forms.CheckBox cboxPTLevel;

		// Token: 0x04001139 RID: 4409
		private global::System.Windows.Forms.CheckBox cboxXDHoiMau;

		// Token: 0x0400113A RID: 4410
		private global::System.Windows.Forms.GroupBox groupTBB;

		// Token: 0x0400113B RID: 4411
		private global::System.Windows.Forms.CheckBox cboxTBBPhiThuy;

		// Token: 0x0400113C RID: 4412
		private global::System.Windows.Forms.Label lblTBBCounter;

		// Token: 0x0400113D RID: 4413
		private global::System.Windows.Forms.Button button4;

		// Token: 0x0400113E RID: 4414
		private global::System.Windows.Forms.Label lblABPhai;

		// Token: 0x0400113F RID: 4415
		private global::System.Windows.Forms.Button btnATExpand;

		// Token: 0x04001140 RID: 4416
		private global::System.Windows.Forms.Button btnTAExpand;

		// Token: 0x04001141 RID: 4417
		private global::System.Windows.Forms.Button btnLKExpand;

		// Token: 0x04001142 RID: 4418
		private global::System.Windows.Forms.Button btnKKExpand;

		// Token: 0x04001143 RID: 4419
		private global::System.Windows.Forms.Button btnDuaHauExpand;

		// Token: 0x04001144 RID: 4420
		private global::System.Windows.Forms.Button btnTBBExpand;

		// Token: 0x04001145 RID: 4421
		private global::System.Windows.Forms.Button btnMuaKNBExpand;

		// Token: 0x04001146 RID: 4422
		private global::System.Windows.Forms.ColumnHeader columnHeader_34;

		// Token: 0x04001147 RID: 4423
		private global::System.Windows.Forms.CheckBox cboxNMBuff;

		// Token: 0x04001148 RID: 4424
		private global::System.Windows.Forms.CheckBox cboxTAPhuDL;

		// Token: 0x04001149 RID: 4425
		private global::System.Windows.Forms.CheckBox cboxTAPhuLD;

		// Token: 0x0400114A RID: 4426
		private global::System.Windows.Forms.CheckBox cboxTAPhuToChau;

		// Token: 0x0400114B RID: 4427
		private global::System.Windows.Forms.CheckBox cboxXayDungPhu;

		// Token: 0x0400114C RID: 4428
		private global::System.Windows.Forms.CheckBox cboxXDXaPhu;

		// Token: 0x0400114D RID: 4429
		private global::System.Windows.Forms.Button btnResetGio;

		// Token: 0x0400114E RID: 4430
		private global::System.Windows.Forms.RadioButton rdioNhatHet;

		// Token: 0x0400114F RID: 4431
		private global::System.Windows.Forms.Button btnListNhat;

		// Token: 0x04001150 RID: 4432
		private global::System.Windows.Forms.RadioButton rdioNhatList;

		// Token: 0x04001151 RID: 4433
		private global::System.Windows.Forms.CheckBox cboxDebugLog;

		// Token: 0x04001152 RID: 4434
		private global::System.Windows.Forms.ComboBox cboTuDuongCon;

		// Token: 0x04001153 RID: 4435
		private global::System.Windows.Forms.CheckBox cboxLTNhanVN;

		// Token: 0x04001154 RID: 4436
		private global::System.Windows.Forms.CheckBox cboxDanhQuai;

		// Token: 0x04001155 RID: 4437
		private global::System.Windows.Forms.Button btnDanhTheoAi;

		// Token: 0x04001156 RID: 4438
		private global::System.Windows.Forms.RadioButton rdioDanhTheoAi;

		// Token: 0x04001157 RID: 4439
		private global::System.Windows.Forms.CheckBox cboxBanKinh;

		// Token: 0x04001158 RID: 4440
		private global::System.Windows.Forms.Button btnSkillBuffExpand;

		// Token: 0x04001159 RID: 4441
		private global::System.Windows.Forms.Button btnSkillPhaiExpand;

		// Token: 0x0400115A RID: 4442
		private global::System.Windows.Forms.Button btnPhanPKExpand;

		// Token: 0x0400115B RID: 4443
		private global::System.Windows.Forms.GroupBox groupTuyChon;

		// Token: 0x0400115C RID: 4444
		private global::System.Windows.Forms.Button btnTuyChonExpand;

		// Token: 0x0400115D RID: 4445
		private global::System.Windows.Forms.Button btnChatExpand;

		// Token: 0x0400115E RID: 4446
		private global::System.Windows.Forms.Button btnSpeedExpand;

		// Token: 0x0400115F RID: 4447
		private global::System.Windows.Forms.Button btnDiTheoAi;

		// Token: 0x04001160 RID: 4448
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04001161 RID: 4449
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04001162 RID: 4450
		private global::System.Windows.Forms.TextBox txtDanhTheoAi;

		// Token: 0x04001163 RID: 4451
		private global::System.Windows.Forms.ComboBox cboTuBaoBon;

		// Token: 0x04001164 RID: 4452
		private global::System.Windows.Forms.Button btnVeThanhExpand;

		// Token: 0x04001165 RID: 4453
		private global::System.Windows.Forms.CheckBox cboxAOE;

		// Token: 0x04001166 RID: 4454
		private global::System.Windows.Forms.CheckBox cboxTBBchaynhanh;

		// Token: 0x04001167 RID: 4455
		private global::System.Windows.Forms.NumericUpDown numDelay;

		// Token: 0x04001168 RID: 4456
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04001169 RID: 4457
		private global::System.Windows.Forms.GroupBox groupTKC;

		// Token: 0x0400116A RID: 4458
		private global::System.Windows.Forms.ComboBox cboTKCMaps;

		// Token: 0x0400116B RID: 4459
		private global::System.Windows.Forms.Button btnTKCEx;

		// Token: 0x0400116C RID: 4460
		private global::System.Windows.Forms.Label label17;

		// Token: 0x0400116D RID: 4461
		private global::System.Windows.Forms.RadioButton rdioUongTra;

		// Token: 0x0400116E RID: 4462
		private global::System.Windows.Forms.CheckBox cboxNMUutienself;

		// Token: 0x0400116F RID: 4463
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x04001170 RID: 4464
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_18;

		// Token: 0x04001171 RID: 4465
		private global::System.Windows.Forms.CheckBox cboxTAXaPhu;

		// Token: 0x04001172 RID: 4466
		private global::System.Windows.Forms.Button btnThuPet;

		// Token: 0x04001173 RID: 4467
		private global::System.Windows.Forms.Button btnNhatBoc;

		// Token: 0x04001174 RID: 4468
		private global::System.Windows.Forms.Button btnTheoSau;

		// Token: 0x04001175 RID: 4469
		private global::System.Windows.Forms.Button btnDanhTheoKey;

		// Token: 0x04001176 RID: 4470
		private global::System.Windows.Forms.Button btnDanhGomQuai;

		// Token: 0x04001177 RID: 4471
		private global::System.Windows.Forms.Button btnDanhTungCon;

		// Token: 0x04001178 RID: 4472
		private global::System.Windows.Forms.Button btnToDoiExpand;

		// Token: 0x04001179 RID: 4473
		private global::System.Windows.Forms.Button btnThuGon;

		// Token: 0x0400117A RID: 4474
		private global::System.Windows.Forms.GroupBox groupPhat;

		// Token: 0x0400117B RID: 4475
		private global::System.Windows.Forms.TabPage tabPhat;

		// Token: 0x0400117C RID: 4476
		private global::System.Windows.Forms.GroupBox groupTheoSau;

		// Token: 0x0400117D RID: 4477
		private global::System.Windows.Forms.CheckBox cboxTuTheo;

		// Token: 0x0400117E RID: 4478
		private global::System.Windows.Forms.Button btnDanhTheoTen;

		// Token: 0x0400117F RID: 4479
		private global::System.Windows.Forms.Label label15;

		// Token: 0x04001180 RID: 4480
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04001181 RID: 4481
		private global::System.Windows.Forms.Button btnThuPetOff;

		// Token: 0x04001182 RID: 4482
		private global::System.Windows.Forms.Button btnNhatBocOff;

		// Token: 0x04001183 RID: 4483
		private global::System.Windows.Forms.Button btnTheoSauOff;

		// Token: 0x04001184 RID: 4484
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04001185 RID: 4485
		private global::System.Windows.Forms.CheckBox cboxNoKS;

		// Token: 0x04001186 RID: 4486
		private global::System.Windows.Forms.ToolStripMenuItem thuGToolStripMenuItem;

		// Token: 0x04001187 RID: 4487
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_19;

		// Token: 0x04001188 RID: 4488
		private global::System.Windows.Forms.CheckBox cboxDuY;

		// Token: 0x04001189 RID: 4489
		private global::System.Windows.Forms.Button btnShutdown;

		// Token: 0x0400118A RID: 4490
		private global::System.Windows.Forms.NumericUpDown numShutdownM;

		// Token: 0x0400118B RID: 4491
		private global::System.Windows.Forms.Label label23;

		// Token: 0x0400118C RID: 4492
		private global::System.Windows.Forms.Label label20;

		// Token: 0x0400118D RID: 4493
		private global::System.Windows.Forms.NumericUpDown numShutdownH;

		// Token: 0x0400118E RID: 4494
		private global::System.Windows.Forms.Label label19;

		// Token: 0x0400118F RID: 4495
		private global::System.Windows.Forms.Button btnBHDVe;

		// Token: 0x04001190 RID: 4496
		private global::System.Windows.Forms.ColumnHeader columnHeader_35;

		// Token: 0x04001191 RID: 4497
		internal global::System.Windows.Forms.NotifyIcon notifyIcon_0;

		// Token: 0x04001192 RID: 4498
		private global::System.Windows.Forms.CheckBox cboxGiuVuKhi;

		// Token: 0x04001193 RID: 4499
		private global::System.Windows.Forms.NumericUpDown numBanKinhNhat;

		// Token: 0x04001194 RID: 4500
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_20;

		// Token: 0x04001195 RID: 4501
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;

		// Token: 0x04001196 RID: 4502
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;

		// Token: 0x04001197 RID: 4503
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;

		// Token: 0x04001198 RID: 4504
		private global::System.Windows.Forms.NumericUpDown numBHDMax;

		// Token: 0x04001199 RID: 4505
		private global::System.Windows.Forms.Label label24;

		// Token: 0x0400119A RID: 4506
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_21;

		// Token: 0x0400119B RID: 4507
		private global::System.Windows.Forms.CheckBox cboxBTDXaPhu;

		// Token: 0x0400119C RID: 4508
		private global::System.Windows.Forms.CheckBox cboxBTDPhuVe;

		// Token: 0x0400119D RID: 4509
		private global::System.Windows.Forms.CheckBox cboxIsBTD;

		// Token: 0x0400119E RID: 4510
		private global::System.Windows.Forms.CheckBox cboxTKCNhanh;

		// Token: 0x0400119F RID: 4511
		private global::System.Windows.Forms.CheckBox cboxIsTuDuongCon;

		// Token: 0x040011A0 RID: 4512
		private global::System.Windows.Forms.CheckBox cboxLuyenKim;

		// Token: 0x040011A1 RID: 4513
		private global::System.Windows.Forms.CheckBox cboxIsXayDung;

		// Token: 0x040011A2 RID: 4514
		private global::System.Windows.Forms.CheckBox cboxIsTrungAc;

		// Token: 0x040011A3 RID: 4515
		private global::System.Windows.Forms.CheckBox cboxIsTrongTrot;

		// Token: 0x040011A4 RID: 4516
		private global::System.Windows.Forms.GroupBox groupQSM;

		// Token: 0x040011A5 RID: 4517
		private global::System.Windows.Forms.Button btnPHLMExpand;

		// Token: 0x040011A6 RID: 4518
		private global::System.Windows.Forms.Button btnPhuBanRefresh;

		// Token: 0x040011A7 RID: 4519
		private global::System.Windows.Forms.Button btnPhuBanOpen;

		// Token: 0x040011A8 RID: 4520
		private global::System.Windows.Forms.CheckBox cboxPhuBanTuyChinh;

		// Token: 0x040011A9 RID: 4521
		private global::System.Windows.Forms.GroupBox groupPhuBanTuyChinh;

		// Token: 0x040011AA RID: 4522
		private global::System.Windows.Forms.Label label30;

		// Token: 0x040011AB RID: 4523
		internal global::System.Windows.Forms.ComboBox cboPhuBanPP;

		// Token: 0x040011AC RID: 4524
		private global::System.Windows.Forms.CheckBox cboxCauNguyen;

		// Token: 0x040011AD RID: 4525
		private global::System.Windows.Forms.CheckBox cboxCauPhuc;

		// Token: 0x040011AE RID: 4526
		private global::System.Windows.Forms.Button btnMuaNgay;

		// Token: 0x040011AF RID: 4527
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_22;

		// Token: 0x040011B0 RID: 4528
		private global::System.Windows.Forms.Label label33;

		// Token: 0x040011B1 RID: 4529
		internal global::System.Windows.Forms.TextBox RightY;

		// Token: 0x040011B2 RID: 4530
		internal global::System.Windows.Forms.TextBox RightX;

		// Token: 0x040011B3 RID: 4531
		private global::System.Windows.Forms.Label label31;

		// Token: 0x040011B4 RID: 4532
		internal global::System.Windows.Forms.TextBox leftY;

		// Token: 0x040011B5 RID: 4533
		internal global::System.Windows.Forms.TextBox leftX;

		// Token: 0x040011B6 RID: 4534
		private global::System.Windows.Forms.Button btnPetList;

		// Token: 0x040011B7 RID: 4535
		private global::System.Windows.Forms.CheckBox cboxPetList;

		// Token: 0x040011B8 RID: 4536
		private global::System.Windows.Forms.GroupBox groupBaoRuong;

		// Token: 0x040011B9 RID: 4537
		private global::System.Windows.Forms.ComboBox cboBaoRuongMap;

		// Token: 0x040011BA RID: 4538
		private global::System.Windows.Forms.Label label34;

		// Token: 0x040011BB RID: 4539
		private global::System.Windows.Forms.CheckBox cboxNhanHop;

		// Token: 0x040011BC RID: 4540
		private global::System.Windows.Forms.CheckBox cboxNhatHop;

		// Token: 0x040011BD RID: 4541
		private global::System.Windows.Forms.CheckBox cboxIsDoatBaoRuong;

		// Token: 0x040011BE RID: 4542
		private global::System.Windows.Forms.Button btnBaoRuongExpand;

		// Token: 0x040011BF RID: 4543
		private global::System.Windows.Forms.CheckBox cboxBRTLC;

		// Token: 0x040011C0 RID: 4544
		private global::System.Windows.Forms.CheckBox cboxBRXaPhu;

		// Token: 0x040011C1 RID: 4545
		private global::System.Windows.Forms.Button btnQSMDiVe;

		// Token: 0x040011C2 RID: 4546
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_23;

		// Token: 0x040011C3 RID: 4547
		private global::System.Windows.Forms.CheckBox cboxDongMon;

		// Token: 0x040011C4 RID: 4548
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_24;

		// Token: 0x040011C5 RID: 4549
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_25;

		// Token: 0x040011C6 RID: 4550
		private global::System.Windows.Forms.Button btnCheDoSettings;

		// Token: 0x040011C7 RID: 4551
		private global::System.Windows.Forms.CheckBox cboxGiamDinh;

		// Token: 0x040011C8 RID: 4552
		internal global::System.Windows.Forms.CheckBox cboxIsCheDo;

		// Token: 0x040011C9 RID: 4553
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_26;

		// Token: 0x040011CA RID: 4554
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_27;

		// Token: 0x040011CB RID: 4555
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_28;

		// Token: 0x040011CC RID: 4556
		private global::System.Windows.Forms.GroupBox groupQ123;

		// Token: 0x040011CD RID: 4557
		private global::System.Windows.Forms.ComboBox cboQ1Cau;

		// Token: 0x040011CE RID: 4558
		private global::System.Windows.Forms.Label lblQ1Cau;

		// Token: 0x040011CF RID: 4559
		private global::System.Windows.Forms.Button btnQ12GroupExpand;

		// Token: 0x040011D0 RID: 4560
		private global::System.Windows.Forms.CheckBox cboxABChayTim;

		// Token: 0x040011D1 RID: 4561
		private global::System.Windows.Forms.CheckBox cboxThuHoach;

		// Token: 0x040011D2 RID: 4562
		private global::System.Windows.Forms.CheckBox cboxBonHoa;

		// Token: 0x040011D3 RID: 4563
		private global::System.Windows.Forms.CheckBox cboxTrongHoa;

		// Token: 0x040011D4 RID: 4564
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_29;

		// Token: 0x040011D5 RID: 4565
		private global::System.Windows.Forms.NumericUpDown numQ12ChoPT;

		// Token: 0x040011D6 RID: 4566
		private global::System.Windows.Forms.CheckBox cboxHongQPT;

		// Token: 0x040011D7 RID: 4567
		private global::System.Windows.Forms.Label label38;

		// Token: 0x040011D8 RID: 4568
		private global::System.Windows.Forms.Label label39;

		// Token: 0x040011D9 RID: 4569
		private global::System.Windows.Forms.CheckBox cboxTuHuyNV;

		// Token: 0x040011DA RID: 4570
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_30;

		// Token: 0x040011DB RID: 4571
		private global::System.Windows.Forms.NumericUpDown numQ12Level;

		// Token: 0x040011DC RID: 4572
		private global::System.Windows.Forms.CheckBox cboxQ12Level;

		// Token: 0x040011DD RID: 4573
		private global::System.Windows.Forms.Button btnXepTen1;

		// Token: 0x040011DE RID: 4574
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040011DF RID: 4575
		private global::System.Windows.Forms.CheckBox cboxDiTheoPP;

		// Token: 0x040011E0 RID: 4576
		private global::System.Windows.Forms.CheckBox cboxNhatTuyet;

		// Token: 0x040011E1 RID: 4577
		private global::System.Windows.Forms.Label lblQ123Timer;

		// Token: 0x040011E2 RID: 4578
		private global::System.Windows.Forms.CheckBox cboxQ12AutoExtend;

		// Token: 0x040011E3 RID: 4579
		private global::System.Windows.Forms.Button btnQ12Mua3H;

		// Token: 0x040011E4 RID: 4580
		private global::System.Windows.Forms.Button btnQ12Mua1H;

		// Token: 0x040011E5 RID: 4581
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_31;

		// Token: 0x040011E6 RID: 4582
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_32;

		// Token: 0x040011E7 RID: 4583
		private global::System.Windows.Forms.Button btnChatDelete;

		// Token: 0x040011E8 RID: 4584
		private global::System.Windows.Forms.Button btnChatRecord;

		// Token: 0x040011E9 RID: 4585
		private global::System.Windows.Forms.CheckBox cboxChatSavedMsg;

		// Token: 0x040011EA RID: 4586
		private global::System.Windows.Forms.GroupBox groupYTO;

		// Token: 0x040011EB RID: 4587
		private global::System.Windows.Forms.Button btnDiCanTro;

		// Token: 0x040011EC RID: 4588
		private global::System.Windows.Forms.Button btnYTOExtend;

		// Token: 0x040011ED RID: 4589
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;

		// Token: 0x040011EE RID: 4590
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_33;

		// Token: 0x040011EF RID: 4591
		internal global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_34;

		// Token: 0x040011F0 RID: 4592
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_35;

		// Token: 0x040011F1 RID: 4593
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;

		// Token: 0x040011F2 RID: 4594
		private global::System.Windows.Forms.Label label44;

		// Token: 0x040011F3 RID: 4595
		private global::System.Windows.Forms.ComboBox cboQ12Xong;

		// Token: 0x040011F4 RID: 4596
		private global::System.Windows.Forms.Button btnQuaiKoDanh;

		// Token: 0x040011F5 RID: 4597
		private global::System.Windows.Forms.CheckBox cboxChoParty;

		// Token: 0x040011F6 RID: 4598
		private global::System.Windows.Forms.GroupBox groupItemUse;

		// Token: 0x040011F7 RID: 4599
		private global::System.Windows.Forms.Label label45;

		// Token: 0x040011F8 RID: 4600
		private global::System.Windows.Forms.ListView lvItemUse;

		// Token: 0x040011F9 RID: 4601
		private global::System.Windows.Forms.ColumnHeader columnHeader_36;

		// Token: 0x040011FA RID: 4602
		private global::System.Windows.Forms.ColumnHeader columnHeader_37;

		// Token: 0x040011FB RID: 4603
		private global::System.Windows.Forms.NumericUpDown numItemUse;

		// Token: 0x040011FC RID: 4604
		private global::System.Windows.Forms.Button btnItemUse;

		// Token: 0x040011FD RID: 4605
		private global::System.Windows.Forms.ComboBox cboItemUse;

		// Token: 0x040011FE RID: 4606
		private global::System.Windows.Forms.ComboBox cboLocDuoc;

		// Token: 0x040011FF RID: 4607
		private global::System.Windows.Forms.Label label47;

		// Token: 0x04001200 RID: 4608
		private global::System.Windows.Forms.CheckBox cboxNMUutienboc;

		// Token: 0x04001201 RID: 4609
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04001202 RID: 4610
		private global::System.Windows.Forms.Button btnMuaDoExpand;

		// Token: 0x04001203 RID: 4611
		private global::System.Windows.Forms.Button btnItemUseExpand;

		// Token: 0x04001204 RID: 4612
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_36;

		// Token: 0x04001205 RID: 4613
		private global::System.Windows.Forms.CheckBox cboxYTOGiaHan;

		// Token: 0x04001206 RID: 4614
		private global::System.Windows.Forms.Button btnYTO3h;

		// Token: 0x04001207 RID: 4615
		private global::System.Windows.Forms.Button btnYTO1h;

		// Token: 0x04001208 RID: 4616
		private global::System.Windows.Forms.Label lblYTOTimer;

		// Token: 0x04001209 RID: 4617
		private global::System.Windows.Forms.Button btnOpenLog;

		// Token: 0x0400120A RID: 4618
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem18;

		// Token: 0x0400120B RID: 4619
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_37;

		// Token: 0x0400120C RID: 4620
		private global::System.Windows.Forms.ToolStripMenuItem autoPKToolStripMenuItem;

		// Token: 0x0400120D RID: 4621
		private global::System.Windows.Forms.GroupBox groupScheduler;

		// Token: 0x0400120E RID: 4622
		private global::System.Windows.Forms.Button btnScheduler;

		// Token: 0x0400120F RID: 4623
		private global::System.Windows.Forms.Button btnNhiemVu2;

		// Token: 0x04001210 RID: 4624
		private global::System.Windows.Forms.Label label50;

		// Token: 0x04001211 RID: 4625
		internal global::System.Windows.Forms.CheckBox cboxScheduler;

		// Token: 0x04001212 RID: 4626
		internal global::System.Windows.Forms.CheckBox cboxIsTKC;

		// Token: 0x04001213 RID: 4627
		internal global::System.Windows.Forms.CheckBox cboxIsQ1;

		// Token: 0x04001214 RID: 4628
		internal global::System.Windows.Forms.CheckBox cboxIsAcTac;

		// Token: 0x04001215 RID: 4629
		internal global::System.Windows.Forms.CheckBox cboxIsTBB;

		// Token: 0x04001216 RID: 4630
		internal global::System.Windows.Forms.CheckBox cboxIsLinhThu;

		// Token: 0x04001217 RID: 4631
		internal global::System.Windows.Forms.CheckBox cboxIsPHLM;

		// Token: 0x04001218 RID: 4632
		internal global::System.Windows.Forms.CheckBox cboxKyCuoc;

		// Token: 0x04001219 RID: 4633
		internal global::System.Windows.Forms.CheckBox cboxIsAcBa;

		// Token: 0x0400121A RID: 4634
		internal global::System.Windows.Forms.CheckBox cboxIsQ2;

		// Token: 0x0400121B RID: 4635
		internal global::System.Windows.Forms.CheckBox cboxIsYTO;

		// Token: 0x0400121C RID: 4636
		internal global::System.Windows.Forms.CheckBox cboxIsBachHoaDuyen;

		// Token: 0x0400121D RID: 4637
		internal global::System.Windows.Forms.CheckBox cboxIsKhaiKhoang;

		// Token: 0x0400121E RID: 4638
		internal global::System.Windows.Forms.CheckBox cboxIsQSM;

		// Token: 0x0400121F RID: 4639
		private global::System.Windows.Forms.Button btnAutoPK;

		// Token: 0x04001220 RID: 4640
		internal global::System.Windows.Forms.CheckBox cboxAutoPK;

		// Token: 0x04001221 RID: 4641
		private global::System.Windows.Forms.ToolStripMenuItem buyHoursBlockToolStripMenuItem;

		// Token: 0x04001222 RID: 4642
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_38;

		// Token: 0x04001223 RID: 4643
		private global::System.Windows.Forms.CheckBox cboxPTYeu;

		// Token: 0x04001224 RID: 4644
		private global::System.Windows.Forms.NumericUpDown numGomMode;

		// Token: 0x04001225 RID: 4645
		private global::System.Windows.Forms.CheckBox cboxOnlyPet;

		// Token: 0x04001226 RID: 4646
		private global::System.Windows.Forms.Button btnSkillsOff;

		// Token: 0x04001227 RID: 4647
		private global::System.Windows.Forms.Button btnSkills;

		// Token: 0x04001228 RID: 4648
		private global::System.Windows.Forms.Label label51;

		// Token: 0x04001229 RID: 4649
		private global::System.Windows.Forms.Button btnHuyNow;

		// Token: 0x0400122A RID: 4650
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_39;

		// Token: 0x0400122B RID: 4651
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_40;

		// Token: 0x0400122C RID: 4652
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_41;

		// Token: 0x0400122D RID: 4653
		private global::System.Windows.Forms.Button btnBuyHour;

		// Token: 0x0400122E RID: 4654
		private global::System.Windows.Forms.CheckBox cboxTanThu;

		// Token: 0x0400122F RID: 4655
		private global::System.Windows.Forms.Button btnTanThu;

		// Token: 0x04001230 RID: 4656
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_42;

		// Token: 0x04001231 RID: 4657
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_43;

		// Token: 0x04001232 RID: 4658
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_44;

		// Token: 0x04001233 RID: 4659
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_45;

		// Token: 0x04001234 RID: 4660
		private global::System.Windows.Forms.ToolStripMenuItem muaToolStripMenuItem;

		// Token: 0x04001235 RID: 4661
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_46;

		// Token: 0x04001236 RID: 4662
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_47;

		// Token: 0x04001237 RID: 4663
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_48;

		// Token: 0x04001238 RID: 4664
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_49;

		// Token: 0x04001239 RID: 4665
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_50;

		// Token: 0x0400123A RID: 4666
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_51;

		// Token: 0x0400123B RID: 4667
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_52;

		// Token: 0x0400123C RID: 4668
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_53;

		// Token: 0x0400123D RID: 4669
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_54;

		// Token: 0x0400123E RID: 4670
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_55;

		// Token: 0x0400123F RID: 4671
		private global::System.Windows.Forms.ToolStripMenuItem lV2840ToolStripMenuItem;

		// Token: 0x04001240 RID: 4672
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_56;

		// Token: 0x04001241 RID: 4673
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_57;

		// Token: 0x04001242 RID: 4674
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_58;

		// Token: 0x04001243 RID: 4675
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_59;

		// Token: 0x04001244 RID: 4676
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_60;

		// Token: 0x04001245 RID: 4677
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_61;

		// Token: 0x04001246 RID: 4678
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_62;

		// Token: 0x04001247 RID: 4679
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_63;

		// Token: 0x04001248 RID: 4680
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04001249 RID: 4681
		private global::System.Windows.Forms.NumericUpDown numBHDBanKinh;

		// Token: 0x0400124A RID: 4682
		private global::System.Windows.Forms.Label label56;

		// Token: 0x0400124B RID: 4683
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_64;

		// Token: 0x0400124C RID: 4684
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_65;

		// Token: 0x0400124D RID: 4685
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_66;

		// Token: 0x0400124E RID: 4686
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_67;

		// Token: 0x0400124F RID: 4687
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_68;

		// Token: 0x04001250 RID: 4688
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_69;

		// Token: 0x04001251 RID: 4689
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_70;

		// Token: 0x04001252 RID: 4690
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_71;

		// Token: 0x04001253 RID: 4691
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_72;

		// Token: 0x04001254 RID: 4692
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_73;

		// Token: 0x04001255 RID: 4693
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_74;

		// Token: 0x04001256 RID: 4694
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_75;

		// Token: 0x04001257 RID: 4695
		private global::System.Windows.Forms.Label label64;

		// Token: 0x04001258 RID: 4696
		private global::System.Windows.Forms.NumericUpDown numQSMMax;

		// Token: 0x04001259 RID: 4697
		private global::System.Windows.Forms.CheckBox cboxATRunPP;

		// Token: 0x0400125A RID: 4698
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_76;

		// Token: 0x0400125B RID: 4699
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_77;

		// Token: 0x0400125C RID: 4700
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_78;

		// Token: 0x0400125D RID: 4701
		private global::System.Windows.Forms.ToolStripMenuItem facebookFanpageToolStripMenuItem;

		// Token: 0x0400125E RID: 4702
		private global::System.Windows.Forms.Button btnThuCommonGUI;

		// Token: 0x0400125F RID: 4703
		private global::System.Windows.Forms.CheckBox cboxBuonDuaHau;

		// Token: 0x04001260 RID: 4704
		private global::System.Windows.Forms.Label label63;

		// Token: 0x04001261 RID: 4705
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_79;

		// Token: 0x04001262 RID: 4706
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_80;

		// Token: 0x04001263 RID: 4707
		private global::System.Windows.Forms.RadioButton rdioNhatListIgnore;

		// Token: 0x04001264 RID: 4708
		private global::System.Windows.Forms.Button btnListNhatIgnore;

		// Token: 0x04001265 RID: 4709
		private global::System.Windows.Forms.Label lblCDCount;

		// Token: 0x04001266 RID: 4710
		private global::System.Windows.Forms.Label lblCDTime;

		// Token: 0x04001267 RID: 4711
		private global::System.Windows.Forms.CheckBox cboxVIPPM;

		// Token: 0x04001268 RID: 4712
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_81;

		// Token: 0x04001269 RID: 4713
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_82;

		// Token: 0x0400126A RID: 4714
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_83;

		// Token: 0x0400126B RID: 4715
		private global::System.Windows.Forms.CheckBox cboxNMBuffSelectTarget;

		// Token: 0x0400126C RID: 4716
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_84;

		// Token: 0x0400126D RID: 4717
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_85;

		// Token: 0x0400126E RID: 4718
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_86;

		// Token: 0x0400126F RID: 4719
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_87;

		// Token: 0x04001270 RID: 4720
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_88;

		// Token: 0x04001271 RID: 4721
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_89;

		// Token: 0x04001272 RID: 4722
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_90;

		// Token: 0x04001273 RID: 4723
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_91;

		// Token: 0x04001274 RID: 4724
		private global::System.Windows.Forms.ToolStripMenuItem lamToolStripMenuItem;

		// Token: 0x04001275 RID: 4725
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_92;

		// Token: 0x04001276 RID: 4726
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_93;

		// Token: 0x04001277 RID: 4727
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_94;

		// Token: 0x04001278 RID: 4728
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_95;

		// Token: 0x04001279 RID: 4729
		private global::System.Windows.Forms.Button btnSellNow;

		// Token: 0x0400127A RID: 4730
		private global::System.Windows.Forms.Label label67;

		// Token: 0x0400127B RID: 4731
		private global::System.Windows.Forms.NumericUpDown numBuffPhamVi;

		// Token: 0x0400127C RID: 4732
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_96;

		// Token: 0x0400127D RID: 4733
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_97;

		// Token: 0x0400127E RID: 4734
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_98;

		// Token: 0x0400127F RID: 4735
		private global::System.Windows.Forms.Button btnCD50acc;

		// Token: 0x04001280 RID: 4736
		private global::System.Windows.Forms.Button btnCD5acc;

		// Token: 0x04001281 RID: 4737
		private global::System.Windows.Forms.Button btnCD2acc;

		// Token: 0x04001282 RID: 4738
		private global::System.Windows.Forms.NumericUpDown numsoHangTrongHoa;

		// Token: 0x04001283 RID: 4739
		private global::System.Windows.Forms.Label label75;

		// Token: 0x04001284 RID: 4740
		internal global::System.Windows.Forms.CheckBox cboxPMP;

		// Token: 0x04001285 RID: 4741
		internal global::System.Windows.Forms.CheckBox cboxLLTB;

		// Token: 0x04001286 RID: 4742
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_99;

		// Token: 0x04001287 RID: 4743
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_100;

		// Token: 0x04001288 RID: 4744
		private global::System.Windows.Forms.CheckBox cboxHuyNVDanhQuai;

		// Token: 0x04001289 RID: 4745
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400128A RID: 4746
		private global::System.Windows.Forms.CheckBox cboxNhatTuyetDungIm;

		// Token: 0x0400128B RID: 4747
		private global::System.Windows.Forms.CheckBox cboxFixKetThanh;

		// Token: 0x0400128C RID: 4748
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_101;

		// Token: 0x0400128D RID: 4749
		private global::System.Windows.Forms.CheckBox cboxBHDThoatKhiXong;

		// Token: 0x0400128E RID: 4750
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_102;

		// Token: 0x0400128F RID: 4751
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_103;

		// Token: 0x04001290 RID: 4752
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_104;

		// Token: 0x04001291 RID: 4753
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_105;

		// Token: 0x04001292 RID: 4754
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_106;

		// Token: 0x04001293 RID: 4755
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_107;

		// Token: 0x04001294 RID: 4756
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_108;

		// Token: 0x04001295 RID: 4757
		private global::System.Windows.Forms.CheckBox cboxThuHoachHoaChinhMinh;

		// Token: 0x04001296 RID: 4758
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_109;

		// Token: 0x04001297 RID: 4759
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_110;

		// Token: 0x04001298 RID: 4760
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_111;

		// Token: 0x04001299 RID: 4761
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_112;

		// Token: 0x0400129A RID: 4762
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_113;

		// Token: 0x0400129B RID: 4763
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_114;

		// Token: 0x0400129C RID: 4764
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_115;

		// Token: 0x0400129D RID: 4765
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_116;

		// Token: 0x0400129E RID: 4766
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_117;

		// Token: 0x0400129F RID: 4767
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_118;

		// Token: 0x040012A0 RID: 4768
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_119;

		// Token: 0x040012A1 RID: 4769
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_120;

		// Token: 0x040012A2 RID: 4770
		private global::System.Windows.Forms.CheckBox cboxHuyNVNhatDo;

		// Token: 0x040012A3 RID: 4771
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_121;

		// Token: 0x040012A4 RID: 4772
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_122;

		// Token: 0x040012A5 RID: 4773
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_123;

		// Token: 0x040012A6 RID: 4774
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_124;

		// Token: 0x040012A7 RID: 4775
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_125;

		// Token: 0x040012A8 RID: 4776
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_126;

		// Token: 0x040012A9 RID: 4777
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_127;

		// Token: 0x040012AA RID: 4778
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_128;

		// Token: 0x040012AB RID: 4779
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_129;

		// Token: 0x040012AC RID: 4780
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_130;

		// Token: 0x040012AD RID: 4781
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_131;

		// Token: 0x040012AE RID: 4782
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_132;

		// Token: 0x040012AF RID: 4783
		private global::System.Windows.Forms.CheckBox cboxKyCuocNhanh;

		// Token: 0x040012B0 RID: 4784
		private global::System.Windows.Forms.CheckBox cboxLLTBNhanh;

		// Token: 0x040012B1 RID: 4785
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_133;

		// Token: 0x040012B2 RID: 4786
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_134;

		// Token: 0x040012B3 RID: 4787
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_135;

		// Token: 0x040012B4 RID: 4788
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_136;

		// Token: 0x040012B5 RID: 4789
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_137;

		// Token: 0x040012B6 RID: 4790
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_138;

		// Token: 0x040012B7 RID: 4791
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_139;

		// Token: 0x040012B8 RID: 4792
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_140;

		// Token: 0x040012B9 RID: 4793
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_141;

		// Token: 0x040012BA RID: 4794
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_142;

		// Token: 0x040012BB RID: 4795
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_143;

		// Token: 0x040012BC RID: 4796
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_144;

		// Token: 0x040012BD RID: 4797
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_145;

		// Token: 0x040012BE RID: 4798
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x040012BF RID: 4799
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_146;

		// Token: 0x040012C0 RID: 4800
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_147;

		// Token: 0x040012C1 RID: 4801
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_148;

		// Token: 0x040012C2 RID: 4802
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_149;

		// Token: 0x040012C3 RID: 4803
		private global::System.Windows.Forms.ToolStripMenuItem theoSauKeyToolStripMenuItem1;

		// Token: 0x040012C4 RID: 4804
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_150;

		// Token: 0x040012C5 RID: 4805
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x040012C6 RID: 4806
		internal global::System.Windows.Forms.NumericUpDown numGroupID;

		// Token: 0x040012C7 RID: 4807
		private global::System.Windows.Forms.ToolStripMenuItem testGameToolStripMenuItem;

		// Token: 0x040012C8 RID: 4808
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_151;

		// Token: 0x040012C9 RID: 4809
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_152;

		// Token: 0x040012CA RID: 4810
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_153;

		// Token: 0x040012CB RID: 4811
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_154;

		// Token: 0x040012CC RID: 4812
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_155;

		// Token: 0x040012CD RID: 4813
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;

		// Token: 0x040012CE RID: 4814
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_156;

		// Token: 0x040012CF RID: 4815
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_157;

		// Token: 0x040012D0 RID: 4816
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x040012D1 RID: 4817
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x040012D2 RID: 4818
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_158;

		// Token: 0x040012D3 RID: 4819
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_159;

		// Token: 0x040012D4 RID: 4820
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_160;

		// Token: 0x040012D5 RID: 4821
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_161;

		// Token: 0x040012D6 RID: 4822
		private global::System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;

		// Token: 0x040012D7 RID: 4823
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_162;

		// Token: 0x040012D8 RID: 4824
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_163;

		// Token: 0x040012D9 RID: 4825
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_164;

		// Token: 0x040012DA RID: 4826
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_165;

		// Token: 0x040012DB RID: 4827
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_166;

		// Token: 0x040012DC RID: 4828
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_167;

		// Token: 0x040012DD RID: 4829
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_168;

		// Token: 0x040012DE RID: 4830
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_169;

		// Token: 0x040012DF RID: 4831
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_170;

		// Token: 0x040012E0 RID: 4832
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;

		// Token: 0x040012E1 RID: 4833
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;

		// Token: 0x040012E2 RID: 4834
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;

		// Token: 0x040012E3 RID: 4835
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;

		// Token: 0x040012E4 RID: 4836
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;

		// Token: 0x040012E5 RID: 4837
		private global::System.Windows.Forms.Label lbTimeOnlineTest;

		// Token: 0x040012E6 RID: 4838
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_171;

		// Token: 0x040012E7 RID: 4839
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_172;

		// Token: 0x040012E8 RID: 4840
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_173;

		// Token: 0x040012E9 RID: 4841
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_174;

		// Token: 0x040012EA RID: 4842
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_175;

		// Token: 0x040012EB RID: 4843
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_176;

		// Token: 0x040012EC RID: 4844
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_177;

		// Token: 0x040012ED RID: 4845
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_178;

		// Token: 0x040012EE RID: 4846
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_179;

		// Token: 0x040012EF RID: 4847
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_180;

		// Token: 0x040012F0 RID: 4848
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_181;

		// Token: 0x040012F1 RID: 4849
		private global::System.Windows.Forms.ToolStripMenuItem tLCToolStripMenuItem;

		// Token: 0x040012F2 RID: 4850
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_182;

		// Token: 0x040012F3 RID: 4851
		private global::System.Windows.Forms.Button btnMuaNgay_KNB;

		// Token: 0x040012F4 RID: 4852
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_183;

		// Token: 0x040012F5 RID: 4853
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_184;

		// Token: 0x040012F6 RID: 4854
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_185;

		// Token: 0x040012F7 RID: 4855
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_186;

		// Token: 0x040012F8 RID: 4856
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_187;

		// Token: 0x040012F9 RID: 4857
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_188;

		// Token: 0x040012FA RID: 4858
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_189;

		// Token: 0x040012FB RID: 4859
		private global::System.Windows.Forms.TextBox tbXorString;

		// Token: 0x040012FC RID: 4860
		private global::System.Windows.Forms.Button btnXorString;

		// Token: 0x040012FD RID: 4861
		private global::System.Windows.Forms.ToolStripMenuItem kimLangToolStripMenuItem;

		// Token: 0x040012FE RID: 4862
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_190;
	}
}
