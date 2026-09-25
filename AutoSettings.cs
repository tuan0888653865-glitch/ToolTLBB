using System;
using System.Collections.Generic;
using System.Text;
using ns0;

namespace SmartBot
{
	// Token: 0x0200008E RID: 142
	[Serializable]
	internal sealed class AutoSettings : Class57
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00004ADE File Offset: 0x00002CDE
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004AE6 File Offset: 0x00002CE6
		public Class210<Class121> SkillPlayList
		{
			get
			{
				return this._SkillPlayerList;
			}
			set
			{
				this._SkillPlayerList = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00004AEF File Offset: 0x00002CEF
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004AF7 File Offset: 0x00002CF7
		public Class210<Class121> SkillBuffList
		{
			get
			{
				return this._SkillBuffList;
			}
			set
			{
				this._SkillBuffList = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00004B00 File Offset: 0x00002D00
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00004B08 File Offset: 0x00002D08
		public Class210<Class121> SkillPKList
		{
			get
			{
				return this._SkillPKList;
			}
			set
			{
				this._SkillPKList = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00004B11 File Offset: 0x00002D11
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004B19 File Offset: 0x00002D19
		public Class210<Class107> ListItemToUse
		{
			get
			{
				return this._ListItemToUse;
			}
			set
			{
				this._ListItemToUse = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00004B22 File Offset: 0x00002D22
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00004B2A File Offset: 0x00002D2A
		public Class210<Class106> ListItemToBuy
		{
			get
			{
				return this._ListItemToBuy;
			}
			set
			{
				this._ListItemToBuy = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00004B33 File Offset: 0x00002D33
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00004B3B File Offset: 0x00002D3B
		public Class57.NhatItemModes NhatItemMode
		{
			get
			{
				return this._NhatItemMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._NhatItemMode != value)
				{
					this.method_1("NhatItemMode", value.ToString(), "", new string[0]);
				}
				this._NhatItemMode = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00004B78 File Offset: 0x00002D78
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x00004B80 File Offset: 0x00002D80
		public Class210<GClass1> ListScheduler
		{
			get
			{
				return this._ListScheduler;
			}
			set
			{
				this._ListScheduler = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00004B89 File Offset: 0x00002D89
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00004B91 File Offset: 0x00002D91
		public bool AllInformationLoaded
		{
			get
			{
				return this._AllInformationLoaded;
			}
			set
			{
				this._AllInformationLoaded = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00004B9A File Offset: 0x00002D9A
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00004BA2 File Offset: 0x00002DA2
		public Class57.Enum14 AfterDeathSetting
		{
			get
			{
				return this._AfterDeathSetting;
			}
			set
			{
				if (this.AllInformationLoaded && this._AfterDeathSetting != value)
				{
					this.method_1("AfterDeathSetting", value.ToString(), "", new string[0]);
				}
				this._AfterDeathSetting = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00004BDF File Offset: 0x00002DDF
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public Class210<string> ListItemNhatIgnore
		{
			get
			{
				return this._ListItemNhatIgnore;
			}
			set
			{
				this._ListItemNhatIgnore = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00004BF0 File Offset: 0x00002DF0
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public Class57.AIModes AIMode
		{
			get
			{
				return this._AIMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._AIMode != value)
				{
					this.method_1("AIMode", value.ToString(), "", new string[0]);
				}
				this._AIMode = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00004C35 File Offset: 0x00002E35
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004C3D File Offset: 0x00002E3D
		public int NgaMiSkillBuffID
		{
			get
			{
				return this._NgaMiSkillID;
			}
			set
			{
				if (value == 424 && this.AllInformationLoaded && this._NgaMiSkillID != value)
				{
					this.method_1("NgaMiSkillBuffID", value.ToString(), "", new string[0]);
				}
				this._NgaMiSkillID = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x00004C7C File Offset: 0x00002E7C
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004C84 File Offset: 0x00002E84
		public int numNgaMyBuff
		{
			get
			{
				return this._numNgaMyBuff;
			}
			set
			{
				if (this.AllInformationLoaded && this._numNgaMyBuff != value)
				{
					this.method_1("numNgaMyBuff", value.ToString(), "", new string[0]);
				}
				this._numNgaMyBuff = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x00004CBB File Offset: 0x00002EBB
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004CC3 File Offset: 0x00002EC3
		public bool usePhatQuangPhoChieu
		{
			get
			{
				return this._usePhatQuangPhoChieu;
			}
			set
			{
				if (this.AllInformationLoaded && this._usePhatQuangPhoChieu != value)
				{
					this.method_1("usePhatQuangPhoChieu", value.ToString(), "", new string[0]);
				}
				this._usePhatQuangPhoChieu = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00004CFA File Offset: 0x00002EFA
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004D02 File Offset: 0x00002F02
		public bool cboxBuffPet
		{
			get
			{
				return this._cboxBuffPet;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBuffPet != value)
				{
					this.method_1("cboxBuffPet", value.ToString(), "", new string[0]);
				}
				this._cboxBuffPet = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000501 RID: 1281 RVA: 0x00004D39 File Offset: 0x00002F39
		// (set) Token: 0x06000502 RID: 1282 RVA: 0x00004D41 File Offset: 0x00002F41
		public int numBuffPet
		{
			get
			{
				return this._numBuffPet;
			}
			set
			{
				if (this.AllInformationLoaded && this._numBuffPet != value)
				{
					this.method_1("numBuffPet", value.ToString(), "", new string[0]);
				}
				this._numBuffPet = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x00004D78 File Offset: 0x00002F78
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00004D80 File Offset: 0x00002F80
		public Class57.NgaMyBuffModes nmBuffMode
		{
			get
			{
				return this._nmBuffMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._nmBuffMode != value)
				{
					this.method_1("nmBuffMode", value.ToString(), "", new string[0]);
				}
				this._nmBuffMode = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00004DBD File Offset: 0x00002FBD
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00004DC5 File Offset: 0x00002FC5
		public int numBuffPartyXH
		{
			get
			{
				return this._numBuffPartyXH;
			}
			set
			{
				if (this.AllInformationLoaded && this._numBuffPartyXH != value)
				{
					this.method_1("numBuffPartyXH", value.ToString(), "", new string[0]);
				}
				this._numBuffPartyXH = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00004DFC File Offset: 0x00002FFC
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x00004E04 File Offset: 0x00003004
		public bool cboxTuNhatVatPham
		{
			get
			{
				return this._cboxTuNhatVatPham;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTuNhatVatPham != value)
				{
					this.method_1("cboxTuNhatVatPham", value.ToString(), "", new string[0]);
				}
				this._cboxTuNhatVatPham = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x00004E3B File Offset: 0x0000303B
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x00004E43 File Offset: 0x00003043
		public bool cboxCongSinh
		{
			get
			{
				return this._cboxCongSinh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxCongSinh != value)
				{
					this.method_1("cboxCongSinh", value.ToString(), "", new string[0]);
				}
				this._cboxCongSinh = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00004E7A File Offset: 0x0000307A
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x00004E82 File Offset: 0x00003082
		public int numPetChoi
		{
			get
			{
				return this._numPetChoi;
			}
			set
			{
				if (this.AllInformationLoaded && this._numPetChoi != value)
				{
					this.method_1("numPetChoi", value.ToString(), "", new string[0]);
				}
				this._numPetChoi = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x00004EB9 File Offset: 0x000030B9
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x00004EC1 File Offset: 0x000030C1
		public int numPetHPPercent
		{
			get
			{
				return this._numPetHPPercent;
			}
			set
			{
				if (this.AllInformationLoaded && this._numPetHPPercent != value)
				{
					this.method_1("numPetHPPercent", value.ToString(), "", new string[0]);
				}
				this._numPetHPPercent = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x00004EF8 File Offset: 0x000030F8
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x00004F00 File Offset: 0x00003100
		public int cboTKCMaps
		{
			get
			{
				return this._cboTKCMaps;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTKCMaps != value)
				{
					this.method_1("cboTKCMaps", value.ToString(), "", new string[0]);
				}
				this._cboTKCMaps = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x00004F37 File Offset: 0x00003137
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x00004F3F File Offset: 0x0000313F
		public int numMPPercent
		{
			get
			{
				return this._numMPPercent;
			}
			set
			{
				if (this.AllInformationLoaded && this._numMPPercent != value)
				{
					this.method_1("numMPPercent", value.ToString(), "", new string[0]);
				}
				this._numMPPercent = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x00004F76 File Offset: 0x00003176
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x00004F7E File Offset: 0x0000317E
		public int numHPPercent
		{
			get
			{
				return this._numHPPercent;
			}
			set
			{
				if (this.AllInformationLoaded && this._numHPPercent != value)
				{
					this.method_1("numHPPercent", value.ToString(), "", new string[0]);
				}
				this._numHPPercent = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x00004FB5 File Offset: 0x000031B5
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x00004FBD File Offset: 0x000031BD
		public bool cboxTuUpLevel
		{
			get
			{
				return this._cboxTuUpLevel;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTuUpLevel != value)
				{
					this.method_1("cboxTuUpLevel", value.ToString(), "", new string[0]);
				}
				this._cboxTuUpLevel = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x00004FF4 File Offset: 0x000031F4
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x00004FFC File Offset: 0x000031FC
		public int numUpLevel
		{
			get
			{
				return this._numUpLevel;
			}
			set
			{
				if (this.AllInformationLoaded && this._numUpLevel != value)
				{
					this.method_1("numUpLevel", value.ToString(), "", new string[0]);
				}
				this._numUpLevel = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00005033 File Offset: 0x00003233
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0000503B File Offset: 0x0000323B
		public int numPhatQuangDelay
		{
			get
			{
				return this._numPhatQuangDelay;
			}
			set
			{
				if (this.AllInformationLoaded && this._numPhatQuangDelay != value)
				{
					this.method_1("numPhatQuangDelay", value.ToString(), "", new string[0]);
				}
				this._numPhatQuangDelay = value;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00005072 File Offset: 0x00003272
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0000507A File Offset: 0x0000327A
		public bool cboxVutDoKhiFull
		{
			get
			{
				return this._cboxVutDoKhiFull;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxVutDoKhiFull != value)
				{
					this.method_1("cboxVutDoKhiFull", value.ToString(), "", new string[0]);
				}
				this._cboxVutDoKhiFull = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x000050B1 File Offset: 0x000032B1
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000050B9 File Offset: 0x000032B9
		public bool cboxVeThanhKhiFull
		{
			get
			{
				return this._cboxVeThanhKhiFull;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxVeThanhKhiFull != value)
				{
					this.method_1("cboxVeThanhKhiFull", value.ToString(), "", new string[0]);
				}
				this._cboxVeThanhKhiFull = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000050F0 File Offset: 0x000032F0
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x000050F8 File Offset: 0x000032F8
		public bool cboxTuMuaBan
		{
			get
			{
				return this._cboxTuMuaBan;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTuMuaBan != value)
				{
					this.method_1("cboxTuMuaBan", value.ToString(), "", new string[0]);
				}
				this._cboxTuMuaBan = value;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0000512F File Offset: 0x0000332F
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x00005137 File Offset: 0x00003337
		public bool cboxVeThanhHetThucAn
		{
			get
			{
				return this._cboxVeThanhHetThucAn;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxVeThanhHetThucAn != value)
				{
					this.method_1("cboxVeThanhHetThucAn", value.ToString(), "", new string[0]);
				}
				this._cboxVeThanhHetThucAn = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0000516E File Offset: 0x0000336E
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00005176 File Offset: 0x00003376
		public bool cboxVeThanhHetBNM
		{
			get
			{
				return this._cboxVeThanhHetBNM;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxVeThanhHetBNM != value)
				{
					this.method_1("cboxVeThanhHetBNM", value.ToString(), "", new string[0]);
				}
				this._cboxVeThanhHetBNM = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x000051AD File Offset: 0x000033AD
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x000051B5 File Offset: 0x000033B5
		public int numVeThanhHP
		{
			get
			{
				return this._numVeThanhHP;
			}
			set
			{
				if (this.AllInformationLoaded && this._numVeThanhHP != value)
				{
					this.method_1("numVeThanhHP", value.ToString(), "", new string[0]);
				}
				this._numVeThanhHP = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x000051EC File Offset: 0x000033EC
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x000051F4 File Offset: 0x000033F4
		public int numVeThanhMP
		{
			get
			{
				return this._numVeThanhMP;
			}
			set
			{
				if (this.AllInformationLoaded && this._numVeThanhMP != value)
				{
					this.method_1("numVeThanhMP", value.ToString(), "", new string[0]);
				}
				this._numVeThanhMP = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000522B File Offset: 0x0000342B
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00005233 File Offset: 0x00003433
		public int HealMapID
		{
			get
			{
				return this._HealMapID;
			}
			set
			{
				if (this.AllInformationLoaded && this._HealMapID != value)
				{
					this.method_1("HealMapID", value.ToString(), "", new string[0]);
				}
				this._HealMapID = value;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0000526A File Offset: 0x0000346A
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00005272 File Offset: 0x00003472
		public int cboPetFoodType
		{
			get
			{
				return this._cboPetFoodType;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboPetFoodType != value)
				{
					this.method_1("cboPetFoodType", value.ToString(), "", new string[0]);
				}
				this._cboPetFoodType = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x000052A9 File Offset: 0x000034A9
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x000052B1 File Offset: 0x000034B1
		public bool cboxVeThanhHetMau
		{
			get
			{
				return this._cboxVeThanhHetMau;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxVeThanhHetMau != value)
				{
					this.method_1("cboxVeThanhHetMau", value.ToString(), "", new string[0]);
				}
				this._cboxVeThanhHetMau = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x000052E8 File Offset: 0x000034E8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x000052F0 File Offset: 0x000034F0
		public bool cboxHelpChat
		{
			get
			{
				return this._cboxHelpChat;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHelpChat != value)
				{
					this.method_1("cboxHelpChat", value.ToString(), "", new string[0]);
				}
				this._cboxHelpChat = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00005327 File Offset: 0x00003527
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x0000532F File Offset: 0x0000352F
		public int cboKenhChat
		{
			get
			{
				return this._cboKenhChat;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboKenhChat != value)
				{
					this.method_1("cboKenhChat", value.ToString(), "", new string[0]);
				}
				this._cboKenhChat = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00005366 File Offset: 0x00003566
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0000536E File Offset: 0x0000356E
		public int numAutoChat
		{
			get
			{
				return this._numAutoChat;
			}
			set
			{
				if (this.AllInformationLoaded && this._numAutoChat != value)
				{
					this.method_1("numAutoChat", value.ToString(), "", new string[0]);
				}
				this._numAutoChat = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000053A5 File Offset: 0x000035A5
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x000053AD File Offset: 0x000035AD
		public string AutoChatContent
		{
			get
			{
				return this._AutoChatContent;
			}
			set
			{
				if (this.AllInformationLoaded && this._AutoChatContent != value)
				{
					this.method_1("AutoChatContent", value.ToString(), "", new string[0]);
				}
				this._AutoChatContent = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000053E8 File Offset: 0x000035E8
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x000053F0 File Offset: 0x000035F0
		public int tboxIDBang
		{
			get
			{
				return this._tboxIDBang;
			}
			set
			{
				if (this.AllInformationLoaded && this._tboxIDBang != value)
				{
					this.method_1("tboxIDBang", value.ToString(), "", new string[0]);
				}
				this._tboxIDBang = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00005427 File Offset: 0x00003627
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0000542F File Offset: 0x0000362F
		public int tBoxIDFriend
		{
			get
			{
				return this._tBoxIDFriend;
			}
			set
			{
				if (this.AllInformationLoaded && this._tBoxIDFriend != value)
				{
					this.method_1("tBoxIDFriend", value.ToString(), "", new string[0]);
				}
				this._tBoxIDFriend = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00005466 File Offset: 0x00003666
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000546E File Offset: 0x0000366E
		public bool cboxTNFullAuto
		{
			get
			{
				return this._cboxTNFullAuto;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTNFullAuto != value)
				{
					this.method_1("cboxTNFullAuto", value.ToString(), "", new string[0]);
				}
				this._cboxTNFullAuto = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x000054A5 File Offset: 0x000036A5
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x000054AD File Offset: 0x000036AD
		public int numTNRounds
		{
			get
			{
				return this._numTNRounds;
			}
			set
			{
				if (this.AllInformationLoaded && this._numTNRounds != value)
				{
					this.method_1("numTNRounds", value.ToString(), "", new string[0]);
				}
				this._numTNRounds = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000054E4 File Offset: 0x000036E4
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x000054EC File Offset: 0x000036EC
		public bool cboxTNAlert
		{
			get
			{
				return this._cboxTNAlert;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTNAlert != value)
				{
					this.method_1("cboxTNAlert", value.ToString(), "", new string[0]);
				}
				this._cboxTNAlert = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00005523 File Offset: 0x00003723
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000552B File Offset: 0x0000372B
		public bool cboxTNAlertPK
		{
			get
			{
				return this._cboxTNAlertPK;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTNAlertPK != value)
				{
					this.method_1("cboxTNAlertPK", value.ToString(), "", new string[0]);
				}
				this._cboxTNAlertPK = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00005562 File Offset: 0x00003762
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0000556A File Offset: 0x0000376A
		public bool cboItemTuHuy
		{
			get
			{
				return this._cboItemTuHuy;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboItemTuHuy != value)
				{
					this.method_1("cboItemTuHuy", value.ToString(), "", new string[0]);
				}
				this._cboItemTuHuy = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x000055A1 File Offset: 0x000037A1
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x000055A9 File Offset: 0x000037A9
		public bool cboTNTuNhanPhieu
		{
			get
			{
				return this._cboTNTuNhanPhieu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTNTuNhanPhieu != value)
				{
					this.method_1("cboTNTuNhanPhieu", value.ToString(), "", new string[0]);
				}
				this._cboTNTuNhanPhieu = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000055E0 File Offset: 0x000037E0
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x000055E8 File Offset: 0x000037E8
		public bool cboxFullThungVE
		{
			get
			{
				return this._cboxFullThungVE;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxFullThungVE != value)
				{
					this.method_1("cboxFullThungVE", value.ToString(), "", new string[0]);
				}
				this._cboxFullThungVE = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0000561F File Offset: 0x0000381F
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00005627 File Offset: 0x00003827
		public int numFullThung
		{
			get
			{
				return this._numFullThung;
			}
			set
			{
				if (this.AllInformationLoaded && this._numFullThung != value)
				{
					this.method_1("numFullThung", value.ToString(), "", new string[0]);
				}
				this._numFullThung = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x0000565E File Offset: 0x0000385E
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00005666 File Offset: 0x00003866
		public int numBanKinhNhat
		{
			get
			{
				return this._numBanKinhNhat;
			}
			set
			{
				if (this.AllInformationLoaded && this._numBanKinhNhat != value)
				{
					this.method_1("numBanKinhNhat", value.ToString(), "", new string[0]);
				}
				this._numBanKinhNhat = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000569D File Offset: 0x0000389D
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x000056A5 File Offset: 0x000038A5
		public bool cboxFullStopNhat
		{
			get
			{
				return this._cboxFullStopNhat;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxFullStopNhat != value)
				{
					this.method_1("cboxFullStopNhat", value.ToString(), "", new string[0]);
				}
				this._cboxFullStopNhat = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000056DC File Offset: 0x000038DC
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x000056E4 File Offset: 0x000038E4
		public string TNLastDirection
		{
			get
			{
				return this._TNLastDirection;
			}
			set
			{
				if (this.AllInformationLoaded && this._TNLastDirection != value)
				{
					this.method_1("TNLastDirection", value, "TN chuyến cuối hướng nào", new string[0]);
				}
				this._TNLastDirection = value;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0000571A File Offset: 0x0000391A
		public void method_1(string string_0, string string_1, string string_2 = "", params string[] string_3)
		{
			Class161.smethod_4(this.method_2(), string_0, string_1, string_2, string_3);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0009576C File Offset: 0x0009396C
		public string AIModeDisplay
		{
			get
			{
				if (this.AIMode == Class57.AIModes.DANHQUANHDIEM)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Đánh quanh điểm";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Fight around spot";
					}
					return "围绕一个点打";
				}
				else if (this.AIMode == Class57.AIModes.DANHTUDO)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Đánh tự do";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Fight moving free";
					}
					return "自由移动和战斗";
				}
				else if (this.AIMode == Class57.AIModes.HOTRO)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Hỗ trợ tổ đội";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Team support";
					}
					return "支持团队";
				}
				else if (this.AIMode == Class57.AIModes.KHAIKHOANG_HAIDUOC)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "KK H. dược";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Mining - Picking";
					}
					return "采矿和香草采摘";
				}
				else if (this.AIMode == Class57.AIModes.SCRIPTING)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Theo kịch bản";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Scripted";
					}
					return "脚本";
				}
				else if (this.AIMode == Class57.AIModes.TRONGTROT)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Trồng trọt";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Planting";
					}
					return "作物";
				}
				else if (this.AIMode == Class57.AIModes.THUONGNHAN && this.TraderMode == Class57.Enum15.const_0)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "TN Chạy đi";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Trading forward";
					}
					return "交易去前进";
				}
				else if (this.AIMode == Class57.AIModes.THUONGNHAN && this.TraderMode == Class57.Enum15.const_1)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "TN Chạy về";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Trading backward";
					}
					return "交易落后";
				}
				else if (this.AIMode == Class57.AIModes.THUONGNHAN && this.TraderMode == Class57.Enum15.const_5)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "TN Mua bán";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Trading buy-sell";
					}
					return "交易买和卖";
				}
				else if (this.AIMode == Class57.AIModes.THUONGNHAN && this.TraderMode == Class57.Enum15.const_4)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "TN rảnh";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Trading idle";
					}
					return "交易袖手旁观";
				}
				else if (this.AIMode == Class57.AIModes.NHIEMVU)
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Nhiệm vụ";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Quest";
					}
					return "任务";
				}
				else
				{
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "VN")
					{
						return "Không biết";
					}
					if (frmLogin.class101_0.globalSettings_0.CompilingLanguage == "EN")
					{
						return "Unknown";
					}
					return "未知";
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0000572C File Offset: 0x0000392C
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00005734 File Offset: 0x00003934
		public List<Class67> PetSkillPlays
		{
			get
			{
				return this._PetSkillPlays;
			}
			set
			{
				this._PetSkillPlays = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0000573D File Offset: 0x0000393D
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00005745 File Offset: 0x00003945
		public bool cboxPetAOE
		{
			get
			{
				return this._cboxPetAOE;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPetAOE != value)
				{
					this.method_1("cboxPetAOE", value.ToString(), "Cho pet chơi AOE hay không", new string[0]);
				}
				this._cboxPetAOE = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0000577C File Offset: 0x0000397C
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00005784 File Offset: 0x00003984
		public int TKCLeftX
		{
			get
			{
				return this._TKCLeftX;
			}
			set
			{
				if (this.AllInformationLoaded && this._TKCLeftX != value)
				{
					this.method_1("TKCLeftX", value.ToString(), "", new string[0]);
				}
				this._TKCLeftX = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000057BB File Offset: 0x000039BB
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x000057C3 File Offset: 0x000039C3
		public int TKCLeftY
		{
			get
			{
				return this._TKCLeftY;
			}
			set
			{
				if (this.AllInformationLoaded && this._TKCLeftY != value)
				{
					this.method_1("TKCLeftY", value.ToString(), "", new string[0]);
				}
				this._TKCLeftY = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000057FA File Offset: 0x000039FA
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00005802 File Offset: 0x00003A02
		public int TKCRightX
		{
			get
			{
				return this._TKCRightX;
			}
			set
			{
				if (this.AllInformationLoaded && this._TKCRightX != value)
				{
					this.method_1("TKCRightX", value.ToString(), "", new string[0]);
				}
				this._TKCRightX = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00005839 File Offset: 0x00003A39
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00005841 File Offset: 0x00003A41
		public int TKCRightY
		{
			get
			{
				return this._TKCRightY;
			}
			set
			{
				if (this.AllInformationLoaded && this._TKCRightY != value)
				{
					this.method_1("TKCRightY", value.ToString(), "", new string[0]);
				}
				this._TKCRightY = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00005878 File Offset: 0x00003A78
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00005880 File Offset: 0x00003A80
		public double CenterX
		{
			get
			{
				return this._CenterX;
			}
			set
			{
				if (this.AllInformationLoaded && this._CenterX != value)
				{
					this.method_1("CenterX", value.ToString(), "", new string[0]);
				}
				this._CenterX = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x000058B7 File Offset: 0x00003AB7
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x000058BF File Offset: 0x00003ABF
		public double CenterY
		{
			get
			{
				return this._CenterY;
			}
			set
			{
				if (this.AllInformationLoaded && this._CenterY != value)
				{
					this.method_1("CenterY", value.ToString(), "", new string[0]);
				}
				this._CenterY = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000058F6 File Offset: 0x00003AF6
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x000058FE File Offset: 0x00003AFE
		public bool cboxHuyetTe
		{
			get
			{
				return this._cboxHuyetTe;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHuyetTe != value)
				{
					this.method_1("cboxHuyetTe", value.ToString(), "", new string[0]);
				}
				this._cboxHuyetTe = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00005935 File Offset: 0x00003B35
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x0000593D File Offset: 0x00003B3D
		public double Diameter4
		{
			get
			{
				return this._Diameter3;
			}
			set
			{
				if (this.AllInformationLoaded && this._Diameter3 != value)
				{
					this.method_1("Diameter4", value.ToString(), "", new string[0]);
				}
				this._Diameter3 = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00005974 File Offset: 0x00003B74
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0000597C File Offset: 0x00003B7C
		public double MoveRange
		{
			get
			{
				return this._MoveRange;
			}
			set
			{
				if (this.AllInformationLoaded && this._MoveRange != value)
				{
					this.method_1("MoveRange", value.ToString(), "", new string[0]);
				}
				this._MoveRange = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x000059B3 File Offset: 0x00003BB3
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x000059BB File Offset: 0x00003BBB
		public int MapID
		{
			get
			{
				return this._MapID;
			}
			set
			{
				if (this.AllInformationLoaded && this._MapID != value)
				{
					this.method_1("MapID", value.ToString(), "", new string[0]);
				}
				this._MapID = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x000059F2 File Offset: 0x00003BF2
		public string MapName
		{
			get
			{
				return Class83.smethod_133(this.MapID);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000059FF File Offset: 0x00003BFF
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00005A07 File Offset: 0x00003C07
		public int CharDBID
		{
			get
			{
				return this._CharDBID;
			}
			set
			{
				if (this._CharDBID != value)
				{
					this._CharDBID = value;
					this.method_1("CharDBID", value.ToString(), "", new string[0]);
				}
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00005A36 File Offset: 0x00003C36
		public string method_2()
		{
			return Class161.smethod_3(this.CharDBID);
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00005A43 File Offset: 0x00003C43
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00005A4B File Offset: 0x00003C4B
		public bool cboxCaptchaReset
		{
			get
			{
				return this._cboxCaptchaReset;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxCaptchaReset != value)
				{
					this.method_1("cboxCaptchaReset", value.ToString(), "", new string[0]);
				}
				this._cboxCaptchaReset = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00005A82 File Offset: 0x00003C82
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00005A8A File Offset: 0x00003C8A
		public bool cboxTheoSau
		{
			get
			{
				return this._cboxTheoSau;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTheoSau != value)
				{
					this.method_1("cboxTheoSau", value.ToString(), "", new string[0]);
				}
				this._cboxTheoSau = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00005AC1 File Offset: 0x00003CC1
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00005AC9 File Offset: 0x00003CC9
		public bool cboxTurboMode
		{
			get
			{
				return this._cboxTurboMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTurboMode != value)
				{
					this.method_1("cboxTurboMode", value.ToString(), "", new string[0]);
				}
				this._cboxTurboMode = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00005B00 File Offset: 0x00003D00
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00005B08 File Offset: 0x00003D08
		public int numGroupID
		{
			get
			{
				return this._numGroupID;
			}
			set
			{
				if (this.AllInformationLoaded && this._numGroupID != value)
				{
					this.method_1("numGroupID", value.ToString(), "", new string[0]);
				}
				this._numGroupID = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00005B3F File Offset: 0x00003D3F
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00005B47 File Offset: 0x00003D47
		public Class57.FightingModes FightMode
		{
			get
			{
				return this._FightMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._FightMode != value)
				{
					this.method_1("FightMode", value.ToString(), "", new string[0]);
				}
				this._FightMode = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00005B84 File Offset: 0x00003D84
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x00005B8C File Offset: 0x00003D8C
		public bool cboxDanhTheoKey
		{
			get
			{
				return this._cboxDanhTheoKey;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDanhTheoKey != value)
				{
					this.method_1("cboxDanhTheoKey", value.ToString(), "", new string[0]);
				}
				this._cboxDanhTheoKey = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00005BC3 File Offset: 0x00003DC3
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x00005BCB File Offset: 0x00003DCB
		public bool cboxTNChayNhanh
		{
			get
			{
				return this._cboxTNChayNhanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTNChayNhanh != value)
				{
					this.method_1("cboxTNChayNhanh", value.ToString(), "", new string[0]);
				}
				this._cboxTNChayNhanh = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00005C02 File Offset: 0x00003E02
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00005C0A File Offset: 0x00003E0A
		public int PartySavedPosX
		{
			get
			{
				return this._PartySavedPosX;
			}
			set
			{
				if (this.AllInformationLoaded && this._PartySavedPosX != value)
				{
					this.method_1("PartySavedPosX", value.ToString(), "", new string[0]);
				}
				this._PartySavedPosX = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00005C41 File Offset: 0x00003E41
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00005C49 File Offset: 0x00003E49
		public int PartySavedPosY
		{
			get
			{
				return this._PartySavedPosY;
			}
			set
			{
				if (this.AllInformationLoaded && this._PartySavedPosY != value)
				{
					this.method_1("PartySavedPosY", value.ToString(), "", new string[0]);
				}
				this._PartySavedPosY = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00005C80 File Offset: 0x00003E80
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00005C88 File Offset: 0x00003E88
		public Class210<string> PTBlacklist
		{
			get
			{
				return this._PTBlacklist;
			}
			set
			{
				this._PTBlacklist = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00005C91 File Offset: 0x00003E91
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00005C99 File Offset: 0x00003E99
		public Class210<string> QuaiNoAttackList
		{
			get
			{
				return this._QuaiNoAttackList;
			}
			set
			{
				this._QuaiNoAttackList = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00005CA2 File Offset: 0x00003EA2
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00005CAA File Offset: 0x00003EAA
		public Class210<string> AutoPartyList
		{
			get
			{
				return this._AutoPartyList;
			}
			set
			{
				this._AutoPartyList = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00005CB3 File Offset: 0x00003EB3
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00005CBB File Offset: 0x00003EBB
		public int PartySavedMapID
		{
			get
			{
				return this._PartySavedMapID;
			}
			set
			{
				if (this.AllInformationLoaded && this._PartySavedMapID != value)
				{
					this.method_1("PartySavedMapID", value.ToString(), "", new string[0]);
				}
				this._PartySavedMapID = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00005CF2 File Offset: 0x00003EF2
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00005CFA File Offset: 0x00003EFA
		public bool cboxTuVaoPT
		{
			get
			{
				return this._cboxTuVaoPT;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTuVaoPT != value)
				{
					this.method_1("cboxTuVaoPT", value.ToString(), "", new string[0]);
				}
				this._cboxTuVaoPT = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00005D31 File Offset: 0x00003F31
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00005D39 File Offset: 0x00003F39
		public bool cboxCanX2
		{
			get
			{
				return this._cboxCanX2;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxCanX2 != value)
				{
					this.method_1("cboxCanX2", value.ToString(), "", new string[0]);
				}
				this._cboxCanX2 = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00005D70 File Offset: 0x00003F70
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00005D78 File Offset: 0x00003F78
		public bool cboxNMBuffBang
		{
			get
			{
				return this._cboxNMBuffBang;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMBuffBang != value)
				{
					this.method_1("cboxNMBuffBang", value.ToString(), "", new string[0]);
				}
				this._cboxNMBuffBang = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00005DAF File Offset: 0x00003FAF
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00005DB7 File Offset: 0x00003FB7
		public int numTheoSau
		{
			get
			{
				return this._numTheoSau;
			}
			set
			{
				if (this.AllInformationLoaded && this._numTheoSau != value)
				{
					this.method_1("numTheoSau", value.ToString(), "", new string[0]);
				}
				this._numTheoSau = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00005DEE File Offset: 0x00003FEE
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00005DF6 File Offset: 0x00003FF6
		public bool cboxKhongResetGio
		{
			get
			{
				return this._cboxKhongResetGio;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxKhongResetGio != value)
				{
					this.method_1("cboxKhongResetGio", value.ToString(), "", new string[0]);
				}
				this._cboxKhongResetGio = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00005E2D File Offset: 0x0000402D
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00005E35 File Offset: 0x00004035
		public bool cboxPKTuVe
		{
			get
			{
				return this._cboxPKTuVe;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKTuVe != value)
				{
					this.method_1("cboxPKTuVe", value.ToString(), "", new string[0]);
				}
				this._cboxPKTuVe = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00005E6C File Offset: 0x0000406C
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00005E74 File Offset: 0x00004074
		public bool cboxThoLinhChau
		{
			get
			{
				return this._cboxThoLinhChau;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxThoLinhChau != value)
				{
					this.method_1("cboxThoLinhChau", value.ToString(), "", new string[0]);
				}
				this._cboxThoLinhChau = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00005EAB File Offset: 0x000040AB
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00005EB3 File Offset: 0x000040B3
		public bool cboxChoHoiSinh
		{
			get
			{
				return this._cboxChoHoiSinh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxChoHoiSinh != value)
				{
					this.method_1("cboxChoHoiSinh", value.ToString(), "", new string[0]);
				}
				this._cboxChoHoiSinh = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00005EEA File Offset: 0x000040EA
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00005EF2 File Offset: 0x000040F2
		public int numChoHoiSinh
		{
			get
			{
				return this._numChoHoiSinh;
			}
			set
			{
				if (this.AllInformationLoaded && this._numChoHoiSinh != value)
				{
					this.method_1("numChoHoiSinh", value.ToString(), "", new string[0]);
				}
				this._numChoHoiSinh = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00005F29 File Offset: 0x00004129
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00005F31 File Offset: 0x00004131
		public bool cboxNMHoiSinhPT
		{
			get
			{
				return this._cboxNMHoiSinhPT;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMHoiSinhPT != value)
				{
					this.method_1("cboxNMHoiSinhPT", value.ToString(), "", new string[0]);
				}
				this._cboxNMHoiSinhPT = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00005F68 File Offset: 0x00004168
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00005F70 File Offset: 0x00004170
		public bool cboTTThuHoach
		{
			get
			{
				return this._cboTTThuHoach;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTTThuHoach != value)
				{
					this.method_1("cboTTThuHoach", value.ToString(), "", new string[0]);
				}
				this._cboTTThuHoach = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00005FA7 File Offset: 0x000041A7
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00005FAF File Offset: 0x000041AF
		public int txtTTNPC1_ID
		{
			get
			{
				return this._txtTTNPC1_ID;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTTNPC1_ID != value)
				{
					this.method_1("txtTTNPC1_ID", value.ToString(), "", new string[0]);
				}
				this._txtTTNPC1_ID = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00005FE6 File Offset: 0x000041E6
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00005FEE File Offset: 0x000041EE
		public int txtTTNPC1_X
		{
			get
			{
				return this._txtTTNPC1_X;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTTNPC1_X != value)
				{
					this.method_1("txtTTNPC1_X", value.ToString(), "", new string[0]);
				}
				this._txtTTNPC1_X = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00006025 File Offset: 0x00004225
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000602D File Offset: 0x0000422D
		public int txtTTNPC1_Y
		{
			get
			{
				return this._txtTTNPC1_Y;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTTNPC1_Y != value)
				{
					this.method_1("txtTTNPC1_Y", value.ToString(), "", new string[0]);
				}
				this._txtTTNPC1_Y = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00006064 File Offset: 0x00004264
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x0000606C File Offset: 0x0000426C
		public int txtTTNPC2_ID
		{
			get
			{
				return this._txtTTNPC2_ID;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTTNPC2_ID != value)
				{
					this.method_1("txtTTNPC2_ID", value.ToString(), "", new string[0]);
				}
				this._txtTTNPC2_ID = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x000060A3 File Offset: 0x000042A3
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000060AB File Offset: 0x000042AB
		public int txtTTNPC2_X
		{
			get
			{
				return this._txtTTNPC2_X;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTTNPC2_X != value)
				{
					this.method_1("txtTTNPC2_X", value.ToString(), "", new string[0]);
				}
				this._txtTTNPC2_X = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x000060E2 File Offset: 0x000042E2
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x000060EA File Offset: 0x000042EA
		public int txtTTNPC2_Y
		{
			get
			{
				return this._txtTTNPC2_Y;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTTNPC2_Y != value)
				{
					this.method_1("txtTTNPC2_Y", value.ToString(), "", new string[0]);
				}
				this._txtTTNPC2_Y = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00006121 File Offset: 0x00004321
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00006129 File Offset: 0x00004329
		public long TrongTrotNPCTime1
		{
			get
			{
				return this._TrongTrotNPCTime1;
			}
			set
			{
				if (this.AllInformationLoaded && this._TrongTrotNPCTime1 != value)
				{
					this.method_1("TrongTrotNPCTime1", value.ToString(), "", new string[0]);
				}
				this._TrongTrotNPCTime1 = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00006160 File Offset: 0x00004360
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00006168 File Offset: 0x00004368
		public long TrongTrotNPCTime2
		{
			get
			{
				return this._TrongTrotNPCTime2;
			}
			set
			{
				if (this.AllInformationLoaded && this._TrongTrotNPCTime2 != value)
				{
					this.method_1("TrongTrotNPCTime2", value.ToString(), "", new string[0]);
				}
				this._TrongTrotNPCTime2 = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0000619F File Offset: 0x0000439F
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000061A7 File Offset: 0x000043A7
		public bool cboxDanhHoTro
		{
			get
			{
				return this._cboxDanhHoTro;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDanhHoTro != value)
				{
					this.method_1("cboxDanhHoTro", value.ToString(), "", new string[0]);
				}
				this._cboxDanhHoTro = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000061DE File Offset: 0x000043DE
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000061E6 File Offset: 0x000043E6
		public string TrongTrotTime
		{
			get
			{
				return this._TrongTrotTime;
			}
			set
			{
				if (this.AllInformationLoaded && this._TrongTrotTime != value)
				{
					this.method_1("TrongTrotTime", value.ToString(), "", new string[0]);
				}
				this._TrongTrotTime = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00006221 File Offset: 0x00004421
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00006229 File Offset: 0x00004429
		public int TrongTrotMapID
		{
			get
			{
				return this._TrongTrotMapID;
			}
			set
			{
				if (this.AllInformationLoaded && this._TrongTrotMapID != value)
				{
					this.method_1("TrongTrotMapID", value.ToString(), "", new string[0]);
				}
				this._TrongTrotMapID = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00006260 File Offset: 0x00004460
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00006268 File Offset: 0x00004468
		public int TTLoaiThuHoach
		{
			get
			{
				return this._TTLoaiThuHoach;
			}
			set
			{
				if (this.AllInformationLoaded && this._TTLoaiThuHoach != value)
				{
					this.method_1("TTLoaiThuHoach", value.ToString(), "", new string[0]);
				}
				this._TTLoaiThuHoach = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0000629F File Offset: 0x0000449F
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x000062A7 File Offset: 0x000044A7
		public string TTCaySeTrong
		{
			get
			{
				return this._TTCaySeTrong;
			}
			set
			{
				if (this.AllInformationLoaded && this._TTCaySeTrong != value)
				{
					this.method_1("TTCaySeTrong", value.ToString(), "", new string[0]);
				}
				this._TTCaySeTrong = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000062E2 File Offset: 0x000044E2
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x000062EA File Offset: 0x000044EA
		public bool cboxKhaiKhoang
		{
			get
			{
				return this._cboxKhaiKhoang;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxKhaiKhoang != value)
				{
					this.method_1("cboxKhaiKhoang", value.ToString(), "", new string[0]);
				}
				this._cboxKhaiKhoang = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00006321 File Offset: 0x00004521
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00006329 File Offset: 0x00004529
		public bool cboxHaiDuoc
		{
			get
			{
				return this._cboxHaiDuoc;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHaiDuoc != value)
				{
					this.method_1("cboxHaiDuoc", value.ToString(), "", new string[0]);
				}
				this._cboxHaiDuoc = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00006360 File Offset: 0x00004560
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00006368 File Offset: 0x00004568
		public bool cboxKhoangDuoc { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00006371 File Offset: 0x00004571
		public string KhoangDuocMapName
		{
			get
			{
				return Class83.smethod_133(this.KhoangDuocMapID);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0000637E File Offset: 0x0000457E
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00006386 File Offset: 0x00004586
		public int KhoangDuocMapID
		{
			get
			{
				return this._KhoangDuocMapID;
			}
			set
			{
				if (this.AllInformationLoaded && this._KhoangDuocMapID != value)
				{
					this.method_1("KhoangDuocMapID", value.ToString(), "", new string[0]);
				}
				this._KhoangDuocMapID = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x000063BD File Offset: 0x000045BD
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x000063C5 File Offset: 0x000045C5
		public int cboxDuaHauCity
		{
			get
			{
				return this._cboxDuaHauCity;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDuaHauCity != value)
				{
					this.method_1("cboxDuaHauCity", value.ToString(), "", new string[0]);
				}
				this._cboxDuaHauCity = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000063FC File Offset: 0x000045FC
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00006404 File Offset: 0x00004604
		public bool cboDHAlertTuu
		{
			get
			{
				return this._cboDHAlertTuu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboDHAlertTuu != value)
				{
					this.method_1("cboDHAlertTuu", value.ToString(), "", new string[0]);
				}
				this._cboDHAlertTuu = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0000643B File Offset: 0x0000463B
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00006443 File Offset: 0x00004643
		public bool cboDHAutoNV
		{
			get
			{
				return this._cboDHAutoNV;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboDHAutoNV != value)
				{
					this.method_1("cboDHAutoNV", value.ToString(), "", new string[0]);
				}
				this._cboDHAutoNV = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0000647A File Offset: 0x0000467A
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00006482 File Offset: 0x00004682
		public bool cboDHAutoPick
		{
			get
			{
				return this._cboDHAutoPick;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboDHAutoPick != value)
				{
					this.method_1("cboDHAutoPick", value.ToString(), "", new string[0]);
				}
				this._cboDHAutoPick = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x000064B9 File Offset: 0x000046B9
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x000064C1 File Offset: 0x000046C1
		public bool cboDHFromCity
		{
			get
			{
				return this._cboDHFromCity;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboDHFromCity != value)
				{
					this.method_1("cboDHFromCity", value.ToString(), "", new string[0]);
				}
				this._cboDHFromCity = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060005CC RID: 1484 RVA: 0x000064F8 File Offset: 0x000046F8
		// (set) Token: 0x060005CD RID: 1485 RVA: 0x00006500 File Offset: 0x00004700
		public int cboxDuaHauMaps
		{
			get
			{
				return this._cboxDuaHauMaps;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDuaHauMaps != value)
				{
					this.method_1("cboxDuaHauMaps", value.ToString(), "", new string[0]);
				}
				this._cboxDuaHauMaps = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00006537 File Offset: 0x00004737
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x0000653F File Offset: 0x0000473F
		public int txtDHBangID
		{
			get
			{
				return this._txtDHBangID;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtDHBangID != value)
				{
					this.method_1("txtDHBangID", value.ToString(), "", new string[0]);
				}
				this._txtDHBangID = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00006576 File Offset: 0x00004776
		// (set) Token: 0x060005D1 RID: 1489 RVA: 0x0000657E File Offset: 0x0000477E
		public bool cboxNMPKBuff
		{
			get
			{
				return this._cboxNMPKBuff;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMPKBuff != value)
				{
					this.method_1("cboxNMPKBuff", value.ToString(), "", new string[0]);
				}
				this._cboxNMPKBuff = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x000065B5 File Offset: 0x000047B5
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x000065BD File Offset: 0x000047BD
		public int cboATMaps
		{
			get
			{
				return this._cboATMaps;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboATMaps != value)
				{
					this.method_1("cboATMaps", value.ToString(), "", new string[0]);
				}
				this._cboATMaps = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x000065F4 File Offset: 0x000047F4
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x000065FC File Offset: 0x000047FC
		public int TNBuyingMode
		{
			get
			{
				return this._TNBuyingMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._TNBuyingMode != value)
				{
					this.method_1("TNBuyingMode", value.ToString(), "", new string[0]);
				}
				this._TNBuyingMode = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00006633 File Offset: 0x00004833
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x0000663B File Offset: 0x0000483B
		public bool cboxTNMinhGiaHigher
		{
			get
			{
				return this._cboxTNMinhGiaHigher;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTNMinhGiaHigher != value)
				{
					this.method_1("cboxTNMinhGiaHigher", value.ToString(), "", new string[0]);
				}
				this._cboxTNMinhGiaHigher = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00006672 File Offset: 0x00004872
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x0000667A File Offset: 0x0000487A
		public bool cboxTNFriendGiaHigher
		{
			get
			{
				return this._cboxTNFriendGiaHigher;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTNFriendGiaHigher != value)
				{
					this.method_1("cboxTNFriendGiaHigher", value.ToString(), "", new string[0]);
				}
				this._cboxTNFriendGiaHigher = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000066B1 File Offset: 0x000048B1
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x000066B9 File Offset: 0x000048B9
		public int txtTNMinhGiaHigher
		{
			get
			{
				return this._txtTNMinhGiaHigher;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTNMinhGiaHigher != value)
				{
					this.method_1("txtTNMinhGiaHigher", value.ToString(), "", new string[0]);
				}
				this._txtTNMinhGiaHigher = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x000066F8 File Offset: 0x000048F8
		public int txtTNFriendGia
		{
			get
			{
				return this._txtTNFriendGia;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTNFriendGia != value)
				{
					this.method_1("txtTNFriendGia", value.ToString(), "", new string[0]);
				}
				this._txtTNFriendGia = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0000672F File Offset: 0x0000492F
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00006737 File Offset: 0x00004937
		public int cboTNMinhItem
		{
			get
			{
				return this._cboTNMinhItem;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTNMinhItem != value)
				{
					this.method_1("cboTNMinhItem", value.ToString(), "", new string[0]);
				}
				this._cboTNMinhItem = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x0000676E File Offset: 0x0000496E
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00006776 File Offset: 0x00004976
		public int cboTNFriendItem
		{
			get
			{
				return this._cboTNFriendItem;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTNFriendItem != value)
				{
					this.method_1("cboTNFriendItem", value.ToString(), "", new string[0]);
				}
				this._cboTNFriendItem = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000067AD File Offset: 0x000049AD
		public string cboTNMinhItemName
		{
			get
			{
				return Class83.smethod_145(this.cboTNMinhItem);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x000067BA File Offset: 0x000049BA
		public string cboTNFriendItemName
		{
			get
			{
				return Class83.smethod_145(this.cboTNFriendItem);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000067C7 File Offset: 0x000049C7
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x000067CF File Offset: 0x000049CF
		public bool cboxCanX4
		{
			get
			{
				return this._cboxCanX4;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxCanX4 != value)
				{
					this.method_1("cboxCanX4", value.ToString(), "", new string[0]);
				}
				this._cboxCanX4 = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00006806 File Offset: 0x00004A06
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x0000680E File Offset: 0x00004A0E
		public bool cboxNMBuffQuanDoan
		{
			get
			{
				return this._cboxNMBuffQuanDoan;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMBuffQuanDoan != value)
				{
					this.method_1("cboxNMBuffQuanDoan", value.ToString(), "", new string[0]);
				}
				this._cboxNMBuffQuanDoan = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00006845 File Offset: 0x00004A45
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x0000684D File Offset: 0x00004A4D
		public bool cboxBuffQuanDoan
		{
			get
			{
				return this._cboxBuffQuanDoan;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBuffQuanDoan != value)
				{
					this.method_1("cboxBuffQuanDoan", value.ToString(), "", new string[0]);
				}
				this._cboxBuffQuanDoan = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00006884 File Offset: 0x00004A84
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x0000688C File Offset: 0x00004A8C
		public bool cboxNMBuffList
		{
			get
			{
				return this._cboxNMBuffList;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMBuffList != value)
				{
					this.method_1("cboxNMBuffList", value.ToString(), "", new string[0]);
				}
				this._cboxNMBuffList = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x000068C3 File Offset: 0x00004AC3
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x000068CB File Offset: 0x00004ACB
		public bool cboxBuffHoTroOnOff
		{
			get
			{
				return this._cboxBuffHoTroOnOff;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBuffHoTroOnOff != value)
				{
					this.method_1("cboxBuffHoTroOnOff", value.ToString(), "", new string[0]);
				}
				this._cboxBuffHoTroOnOff = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00006902 File Offset: 0x00004B02
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0000690A File Offset: 0x00004B0A
		public bool cboxSkillOnOff
		{
			get
			{
				return this._cboxSkillOnOff;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxSkillOnOff != value)
				{
					this.method_1("cboxSkillOnOff", value.ToString(), "", new string[0]);
				}
				this._cboxSkillOnOff = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00006941 File Offset: 0x00004B41
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00006949 File Offset: 0x00004B49
		public int PTTheoSauMode
		{
			get
			{
				return this._PTTheoSauMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._PTTheoSauMode != value)
				{
					this.method_1("PTTheoSauMode", value.ToString(), "", new string[0]);
				}
				this._PTTheoSauMode = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00006980 File Offset: 0x00004B80
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00006988 File Offset: 0x00004B88
		public string txtTheoSauName
		{
			get
			{
				return this._txtTheoSauName;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtTheoSauName != value)
				{
					this.method_1("txtTheoSauName", value.ToString(), "", new string[0]);
				}
				this._txtTheoSauName = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00095B60 File Offset: 0x00093D60
		public string txtTrainExpMode
		{
			get
			{
				int cboTrainExpMode = this.cboTrainExpMode;
				if (cboTrainExpMode != 1)
				{
					if (cboTrainExpMode != 2)
					{
						if (frmLogin.string_0 == "VN")
						{
							return "giờ";
						}
						if (frmLogin.string_0 == "EN")
						{
							return "hour";
						}
						return "小时";
					}
					else
					{
						if (frmLogin.string_0 == "VN")
						{
							return "1 phút";
						}
						if (frmLogin.string_0 == "EN")
						{
							return "1 min";
						}
						return "1 分钟";
					}
				}
				else
				{
					if (frmLogin.string_0 == "VN")
					{
						return "5 phút";
					}
					if (frmLogin.string_0 == "EN")
					{
						return "5 mins";
					}
					return "5 分钟";
				}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000069C3 File Offset: 0x00004BC3
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000069CB File Offset: 0x00004BCB
		public int cboTrainExpMode
		{
			get
			{
				return this._cboTrainExpMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTrainExpMode != value)
				{
					this.method_1("cboTrainExpMode", value.ToString(), "", new string[0]);
				}
				this._cboTrainExpMode = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00006A02 File Offset: 0x00004C02
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00006A0A File Offset: 0x00004C0A
		public bool cboxPhuVeThanh
		{
			get
			{
				return this._cboxPhuVeThanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPhuVeThanh != value)
				{
					this.method_1("cboxPhuVeThanh", value.ToString(), "", new string[0]);
				}
				this._cboxPhuVeThanh = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00006A41 File Offset: 0x00004C41
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00006A49 File Offset: 0x00004C49
		public bool cboxPassCap2
		{
			get
			{
				return this._cboxPassCap2;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPassCap2 != value)
				{
					this.method_1("cboxPassCap2", value.ToString(), "", new string[0]);
				}
				this._cboxPassCap2 = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00006A88 File Offset: 0x00004C88
		public bool cboxTuClickYes2
		{
			get
			{
				return this._cboxTuClickYes;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTuClickYes != value)
				{
					this.method_1("cboxTuClickYes2", value.ToString(), "", new string[0]);
				}
				this._cboxTuClickYes = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00006ABF File Offset: 0x00004CBF
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00095C18 File Offset: 0x00093E18
		public string txtPassCap2
		{
			get
			{
				return this._txtPassCap2;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtPassCap2 != value)
				{
					string text = string.Format("Peter{0}mary", value);
					text = Class83.smethod_73(text, "8u43!29");
					text = Convert.ToBase64String(Encoding.ASCII.GetBytes(text), 0, text.Length);
					this.method_1("txtPassCap2", text, "", new string[0]);
				}
				this._txtPassCap2 = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00006AC7 File Offset: 0x00004CC7
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00006ACF File Offset: 0x00004CCF
		public bool cboxPKThoatGame
		{
			get
			{
				return this._cboxPKThoatGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKThoatGame != value)
				{
					this.method_1("cboxPKThoatGame", value.ToString(), "", new string[0]);
				}
				this._cboxPKThoatGame = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00006B06 File Offset: 0x00004D06
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00006B0E File Offset: 0x00004D0E
		public int numPKThoatGame
		{
			get
			{
				return this._numPKThoatGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._numPKThoatGame != value)
				{
					this.method_1("numPKThoatGame", value.ToString(), "", new string[0]);
				}
				this._numPKThoatGame = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00006B45 File Offset: 0x00004D45
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00006B4D File Offset: 0x00004D4D
		public bool cboxTANhanNV
		{
			get
			{
				return this._cboxTANhanNV;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTANhanNV != value)
				{
					this.method_1("cboxTANhanNV", value.ToString(), "", new string[0]);
				}
				this._cboxTANhanNV = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00006B84 File Offset: 0x00004D84
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00006B8C File Offset: 0x00004D8C
		public bool cboxTAHoiPhuc
		{
			get
			{
				return this._cboxTAHoiPhuc;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTAHoiPhuc != value)
				{
					this.method_1("cboxTAHoiPhuc", value.ToString(), "", new string[0]);
				}
				this._cboxTAHoiPhuc = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00006BC3 File Offset: 0x00004DC3
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00006BCB File Offset: 0x00004DCB
		public bool cboxTADungPhu
		{
			get
			{
				return this._cboxTADungPhu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTADungPhu != value)
				{
					this.method_1("cboxTADungPhu", value.ToString(), "", new string[0]);
				}
				this._cboxTADungPhu = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00006C02 File Offset: 0x00004E02
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00006C0A File Offset: 0x00004E0A
		public bool cboxPhuQuaLD
		{
			get
			{
				return this._cboxPhuQuaLD;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPhuQuaLD != value)
				{
					this.method_1("cboxPhuQuaLD", value.ToString(), "", new string[0]);
				}
				this._cboxPhuQuaLD = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00006C41 File Offset: 0x00004E41
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x00006C49 File Offset: 0x00004E49
		public bool cboxPhuQuaDaiLy
		{
			get
			{
				return this._cboxPhuQuaDaiLy;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPhuQuaDaiLy != value)
				{
					this.method_1("cboxPhuQuaDaiLy", value.ToString(), "", new string[0]);
				}
				this._cboxPhuQuaDaiLy = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00006C80 File Offset: 0x00004E80
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00006C88 File Offset: 0x00004E88
		public bool cboxLKTuNhanNV
		{
			get
			{
				return this._cboxLKTuNhanNV;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxLKTuNhanNV != value)
				{
					this.method_1("cboxLKTuNhanNV", value.ToString(), "", new string[0]);
				}
				this._cboxLKTuNhanNV = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00006CBF File Offset: 0x00004EBF
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00006CC7 File Offset: 0x00004EC7
		public int txtKNB50
		{
			get
			{
				return this._txtKNB50;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtKNB50 != value)
				{
					this.method_1("txtKNB50", value.ToString(), "", new string[0]);
				}
				this._txtKNB50 = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00006CFE File Offset: 0x00004EFE
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00006D06 File Offset: 0x00004F06
		public int txtKNB200
		{
			get
			{
				return this._txtKNB200;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtKNB200 != value)
				{
					this.method_1("txtKNB200", value.ToString(), "", new string[0]);
				}
				this._txtKNB200 = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00006D3D File Offset: 0x00004F3D
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00006D45 File Offset: 0x00004F45
		public int txtKNB500
		{
			get
			{
				return this._txtKNB500;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtKNB500 != value)
				{
					this.method_1("txtKNB500", value.ToString(), "", new string[0]);
				}
				this._txtKNB500 = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00006D84 File Offset: 0x00004F84
		public bool cboxXayDung
		{
			get
			{
				return this._cboxXayDung;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxXayDung != value)
				{
					this.method_1("cboxXayDung", value.ToString(), "", new string[0]);
				}
				this._cboxXayDung = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00006DBB File Offset: 0x00004FBB
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x00006DC3 File Offset: 0x00004FC3
		public bool cboxXayDungPhu
		{
			get
			{
				return this._cboxXayDungPhu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxXayDungPhu != value)
				{
					this.method_1("cboxXayDungPhu", value.ToString(), "", new string[0]);
				}
				this._cboxXayDungPhu = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00006DFA File Offset: 0x00004FFA
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x00006E02 File Offset: 0x00005002
		public bool cboxPTChoVao
		{
			get
			{
				return this._cboxPTChoVao;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPTChoVao != value)
				{
					this.method_1("cboxPTChoVao", value.ToString(), "", new string[0]);
				}
				this._cboxPTChoVao = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00006E39 File Offset: 0x00005039
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x00006E41 File Offset: 0x00005041
		public bool cboxPTLevel
		{
			get
			{
				return this._cboxPTLevel;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPTLevel != value)
				{
					this.method_1("cboxPTLevel", value.ToString(), "", new string[0]);
				}
				this._cboxPTLevel = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00006E78 File Offset: 0x00005078
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x00006E80 File Offset: 0x00005080
		public int numPTLevel
		{
			get
			{
				return this._numPTLevel;
			}
			set
			{
				if (this.AllInformationLoaded && this._numPTLevel != value)
				{
					this.method_1("numPTLevel", value.ToString(), "", new string[0]);
				}
				this._numPTLevel = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00006EB7 File Offset: 0x000050B7
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x00006EBF File Offset: 0x000050BF
		public bool cboxXDHoiMau
		{
			get
			{
				return this._cboxXDHoiMau;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxXDHoiMau != value)
				{
					this.method_1("cboxXDHoiMau", value.ToString(), "", new string[0]);
				}
				this._cboxXDHoiMau = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00006EF6 File Offset: 0x000050F6
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x00006EFE File Offset: 0x000050FE
		public bool cboxTBBPhiThuy
		{
			get
			{
				return this._cboxTBBPhiThuy;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTBBPhiThuy != value)
				{
					this.method_1("cboxTBBPhiThuy", value.ToString(), "", new string[0]);
				}
				this._cboxTBBPhiThuy = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00006F35 File Offset: 0x00005135
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x00006F3D File Offset: 0x0000513D
		public bool cboxNMBuff
		{
			get
			{
				return this._cboxNMBuff;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMBuff != value)
				{
					this.method_1("cboxNMBuff", value.ToString(), "", new string[0]);
				}
				this._cboxNMBuff = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00006F74 File Offset: 0x00005174
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x00006F7C File Offset: 0x0000517C
		public bool cboxXDXaPhu
		{
			get
			{
				return this._cboxXDXaPhu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxXDXaPhu != value)
				{
					this.method_1("cboxXDXaPhu", value.ToString(), "", new string[0]);
				}
				this._cboxXDXaPhu = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00006FB3 File Offset: 0x000051B3
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x00006FBB File Offset: 0x000051BB
		public bool cboxTAXaPhu
		{
			get
			{
				return this._cboxTAXaPhu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTAXaPhu != value)
				{
					this.method_1("cboxTAXaPhu", value.ToString(), "", new string[0]);
				}
				this._cboxTAXaPhu = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00006FF2 File Offset: 0x000051F2
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x00006FFA File Offset: 0x000051FA
		public int cboTuDuongCon
		{
			get
			{
				return this._cboTuDuongCon;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTuDuongCon != value)
				{
					this.method_1("cboTuDuongCon", value.ToString(), "", new string[0]);
				}
				this._cboTuDuongCon = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00007031 File Offset: 0x00005231
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00007039 File Offset: 0x00005239
		public bool cboxLTNhanVN
		{
			get
			{
				return this._cboxLTNhanVN;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxLTNhanVN != value)
				{
					this.method_1("cboxLTNhanVN", value.ToString(), "", new string[0]);
				}
				this._cboxLTNhanVN = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00007070 File Offset: 0x00005270
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00007078 File Offset: 0x00005278
		public bool cboxDanhTheoAi
		{
			get
			{
				return this._cboxDanhTheoAi;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDanhTheoAi != value)
				{
					this.method_1("cboxDanhTheoAi", value.ToString(), "", new string[0]);
				}
				this._cboxDanhTheoAi = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x000070AF File Offset: 0x000052AF
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x000070B7 File Offset: 0x000052B7
		public string txtDanhTheoAi
		{
			get
			{
				return this._txtDanhTheoAi;
			}
			set
			{
				if (this.AllInformationLoaded && this._txtDanhTheoAi != value)
				{
					this.method_1("txtDanhTheoAi", value.ToString(), "", new string[0]);
				}
				this._txtDanhTheoAi = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x000070F2 File Offset: 0x000052F2
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x000070FA File Offset: 0x000052FA
		public int cboTuBaoBon
		{
			get
			{
				return this._cboTuBaoBon;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboTuBaoBon != value)
				{
					this.method_1("cboTuBaoBon", value.ToString(), "", new string[0]);
				}
				this._cboTuBaoBon = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00007131 File Offset: 0x00005331
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00007139 File Offset: 0x00005339
		public bool cboxDanhQuai
		{
			get
			{
				return this._cboxDanhQuai;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDanhQuai != value)
				{
					this.method_1("cboxDanhQuai", value.ToString(), "", new string[0]);
				}
				this._cboxDanhQuai = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00007170 File Offset: 0x00005370
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00007178 File Offset: 0x00005378
		public bool cboxBanKinh
		{
			get
			{
				return this._cboxBanKinh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBanKinh != value)
				{
					this.method_1("cboxBanKinh", value.ToString(), "", new string[0]);
				}
				this._cboxBanKinh = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000071AF File Offset: 0x000053AF
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x000071B7 File Offset: 0x000053B7
		public bool cboxTBBchaynhanh
		{
			get
			{
				return this._cboxTBBchaynhanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTBBchaynhanh != value)
				{
					this.method_1("cboxTBBchaynhanh", value.ToString(), "", new string[0]);
				}
				this._cboxTBBchaynhanh = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000071EE File Offset: 0x000053EE
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x000071F6 File Offset: 0x000053F6
		public bool cboxAOE
		{
			get
			{
				return this._cboxAOE;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxAOE != value)
				{
					this.method_1("cboxAOE", value.ToString(), "", new string[0]);
				}
				this._cboxAOE = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x0000722D File Offset: 0x0000542D
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00007235 File Offset: 0x00005435
		public bool cboxNMUutienself { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0000723E File Offset: 0x0000543E
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00007246 File Offset: 0x00005446
		public bool cboxGiuVuKhi
		{
			get
			{
				return this._cboxGiuVuKhi;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxGiuVuKhi != value)
				{
					this.method_1("cboxGiuVuKhi", value.ToString(), "", new string[0]);
				}
				this._cboxGiuVuKhi = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0000727D File Offset: 0x0000547D
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00007285 File Offset: 0x00005485
		public bool cboxDuY
		{
			get
			{
				return this._cboxDuY;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDuY != value)
				{
					this.method_1("cboxDuY", value.ToString(), "", new string[0]);
				}
				this._cboxDuY = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000072BC File Offset: 0x000054BC
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x000072C4 File Offset: 0x000054C4
		public int numBHDMax
		{
			get
			{
				return this._numBHDMax;
			}
			set
			{
				if (this.AllInformationLoaded && this._numBHDMax != value)
				{
					this.method_1("numBHDMax", value.ToString(), "", new string[0]);
				}
				this._numBHDMax = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000072FB File Offset: 0x000054FB
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00007303 File Offset: 0x00005503
		public int numBHDBanKinh
		{
			get
			{
				return this._numBHDBanKinh;
			}
			set
			{
				if (this.AllInformationLoaded && this._numBHDBanKinh != value)
				{
					this.method_1("numBHDBanKinh", value.ToString(), "", new string[0]);
				}
				this._numBHDBanKinh = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0000733A File Offset: 0x0000553A
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00007342 File Offset: 0x00005542
		public bool cboxBTDPhuVe
		{
			get
			{
				return this._cboxBTDPhuVe;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBTDPhuVe != value)
				{
					this.method_1("cboxBTDPhuVe", value.ToString(), "", new string[0]);
				}
				this._cboxBTDPhuVe = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00007379 File Offset: 0x00005579
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00007381 File Offset: 0x00005581
		public bool cboxTKCNhanh
		{
			get
			{
				return this._cboxTKCNhanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTKCNhanh != value)
				{
					this.method_1("cboxTKCNhanh", value.ToString(), "", new string[0]);
				}
				this._cboxTKCNhanh = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000073B8 File Offset: 0x000055B8
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x000073C0 File Offset: 0x000055C0
		public string PathPointSection
		{
			get
			{
				return this._PathPointSection;
			}
			set
			{
				if (this.AllInformationLoaded && this._PathPointSection != value)
				{
					this.method_1("PathPointSection", value.ToString(), "", new string[0]);
				}
				this._PathPointSection = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x000073FB File Offset: 0x000055FB
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00007403 File Offset: 0x00005603
		public bool cboxBTDXaPhu
		{
			get
			{
				return this._cboxBTDXaPhu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBTDXaPhu != value)
				{
					this.method_1("cboxBTDXaPhu", value.ToString(), "", new string[0]);
				}
				this._cboxBTDXaPhu = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0000743A File Offset: 0x0000563A
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00007442 File Offset: 0x00005642
		public bool cboxPetList
		{
			get
			{
				return this._cboxPetList;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPetList != value)
				{
					this.method_1("cboxPetList", value.ToString(), "", new string[0]);
				}
				this._cboxPetList = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00007479 File Offset: 0x00005679
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00007481 File Offset: 0x00005681
		public bool cboxNhatHop
		{
			get
			{
				return this._cboxNhatHop;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNhatHop != value)
				{
					this.method_1("cboxNhatHop", value.ToString(), "", new string[0]);
				}
				this._cboxNhatHop = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000074B8 File Offset: 0x000056B8
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x000074C0 File Offset: 0x000056C0
		public bool cboxNhanHop
		{
			get
			{
				return this._cboxNhanHop;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNhanHop != value)
				{
					this.method_1("cboxNhanHop", value.ToString(), "", new string[0]);
				}
				this._cboxNhanHop = value;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000074F7 File Offset: 0x000056F7
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x000074FF File Offset: 0x000056FF
		public int cboBaoRuongMap
		{
			get
			{
				return this._cboBaoRuongMap;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboBaoRuongMap != value)
				{
					this.method_1("cboBaoRuongMap", value.ToString(), "", new string[0]);
				}
				this._cboBaoRuongMap = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00007536 File Offset: 0x00005736
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0000753E File Offset: 0x0000573E
		public bool cboxBRXaPhu
		{
			get
			{
				return this._cboxBRXaPhu;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBRXaPhu != value)
				{
					this.method_1("cboxBRXaPhu", value.ToString(), "", new string[0]);
				}
				this._cboxBRXaPhu = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00007575 File Offset: 0x00005775
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0000757D File Offset: 0x0000577D
		public bool cboxBRTLC
		{
			get
			{
				return this._cboxBRTLC;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBRTLC != value)
				{
					this.method_1("cboxBRTLC", value.ToString(), "", new string[0]);
				}
				this._cboxBRTLC = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x000075B4 File Offset: 0x000057B4
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x000075BC File Offset: 0x000057BC
		public bool cboxDongMon
		{
			get
			{
				return this._cboxDongMon;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDongMon != value)
				{
					this.method_1("cboxDongMon", value.ToString(), "", new string[0]);
				}
				this._cboxDongMon = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x000075F3 File Offset: 0x000057F3
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x000075FB File Offset: 0x000057FB
		public string cboItemCheDo
		{
			get
			{
				return this._cboItemCheDo;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboItemCheDo != value)
				{
					this.method_1("cboItemCheDo", value, "", new string[0]);
				}
				this._cboItemCheDo = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00007631 File Offset: 0x00005831
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x00007639 File Offset: 0x00005839
		public string cboCheDoDTD
		{
			get
			{
				return this._cboCheDoDTD;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboCheDoDTD != value)
				{
					this.method_1("cboCheDoDTD", value, "", new string[0]);
				}
				this._cboCheDoDTD = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0000766F File Offset: 0x0000586F
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00007677 File Offset: 0x00005877
		public int cboCheDoMap
		{
			get
			{
				return this._cboCheDoMap;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboCheDoMap != value)
				{
					this.method_1("cboCheDoMap", value.ToString(), "", new string[0]);
				}
				this._cboCheDoMap = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x000076AE File Offset: 0x000058AE
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x000076B6 File Offset: 0x000058B6
		public string cboCheDoXong
		{
			get
			{
				return this._cboCheDoXong;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboCheDoXong != value)
				{
					this.method_1("cboCheDoXong", value, "", new string[0]);
				}
				this._cboCheDoXong = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000076EC File Offset: 0x000058EC
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x000076F4 File Offset: 0x000058F4
		public int numCheDoAmount
		{
			get
			{
				return this._numCheDoAmount;
			}
			set
			{
				if (this.AllInformationLoaded && this._numCheDoAmount != value)
				{
					this.method_1("numCheDoAmount", value.ToString(), "", new string[0]);
				}
				this._numCheDoAmount = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0000772B File Offset: 0x0000592B
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00007733 File Offset: 0x00005933
		public bool cboxHuyCheDo
		{
			get
			{
				return this._cboxHuyCheDo;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHuyCheDo != value)
				{
					this.method_1("cboxHuyCheDo", value.ToString(), "", new string[0]);
				}
				this._cboxHuyCheDo = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0000776A File Offset: 0x0000596A
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00007772 File Offset: 0x00005972
		public bool cboxBanChoNPC
		{
			get
			{
				return this._cboxBanChoNPC;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBanChoNPC != value)
				{
					this.method_1("cboxBanChoNPC", value.ToString(), "", new string[0]);
				}
				this._cboxBanChoNPC = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000077A9 File Offset: 0x000059A9
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x000077B1 File Offset: 0x000059B1
		public bool cboxHuyNLThua
		{
			get
			{
				return this._cboxHuyNLThua;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHuyNLThua != value)
				{
					this.method_1("cboxHuyNLThua", value.ToString(), "", new string[0]);
				}
				this._cboxHuyNLThua = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000077E8 File Offset: 0x000059E8
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x000077F0 File Offset: 0x000059F0
		public int numCheDoSao
		{
			get
			{
				return this._numCheDoSao;
			}
			set
			{
				if (this.AllInformationLoaded && this._numCheDoSao != value)
				{
					this.method_1("numCheDoSao", value.ToString(), "", new string[0]);
				}
				this._numCheDoSao = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00007827 File Offset: 0x00005A27
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000782F File Offset: 0x00005A2F
		public int numCheDoDong
		{
			get
			{
				return this._numCheDoDong;
			}
			set
			{
				if (this.AllInformationLoaded && this._numCheDoDong != value)
				{
					this.method_1("numCheDoDong", value.ToString(), "", new string[0]);
				}
				this._numCheDoDong = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00007866 File Offset: 0x00005A66
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0000786E File Offset: 0x00005A6E
		public int numCheDoChiSo
		{
			get
			{
				return this._numCheDoChiSo;
			}
			set
			{
				if (this.AllInformationLoaded && this._numCheDoChiSo != value)
				{
					this.method_1("numCheDoChiSo", value.ToString(), "", new string[0]);
				}
				this._numCheDoChiSo = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x000078A5 File Offset: 0x00005AA5
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x000078AD File Offset: 0x00005AAD
		public int numCheDoSLmua
		{
			get
			{
				return this._numCheDoSLmua;
			}
			set
			{
				if (this.AllInformationLoaded && this._numCheDoSLmua != value)
				{
					this.method_1("numCheDoSLmua", value.ToString(), "", new string[0]);
				}
				this._numCheDoSLmua = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x000078E4 File Offset: 0x00005AE4
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x000078EC File Offset: 0x00005AEC
		public bool cboxGiu2DongTM
		{
			get
			{
				return this._cboxGiu2DongTM;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxGiu2DongTM != value)
				{
					this.method_1("cboxGiu2DongTM", value.ToString(), "", new string[0]);
				}
				this._cboxGiu2DongTM = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00007923 File Offset: 0x00005B23
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x0000792B File Offset: 0x00005B2B
		public string cboQ1Cau
		{
			get
			{
				return this._cboQ1Cau;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboQ1Cau != value)
				{
					this.method_1("cboQ1Cau", value, "", new string[0]);
				}
				this._cboQ1Cau = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00007961 File Offset: 0x00005B61
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00007969 File Offset: 0x00005B69
		public bool cboxTuHuyNV
		{
			get
			{
				return this._cboxTuHuyNV;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTuHuyNV != value)
				{
					this.method_1("cboxTuHuyNV", value.ToString(), "", new string[0]);
				}
				this._cboxTuHuyNV = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000079A0 File Offset: 0x00005BA0
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x000079A8 File Offset: 0x00005BA8
		public bool cboxHongQPT
		{
			get
			{
				return this._cboxHongQPT;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHongQPT != value)
				{
					this.method_1("cboxHongQPT", value.ToString(), "", new string[0]);
				}
				this._cboxHongQPT = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000079DF File Offset: 0x00005BDF
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x000079E7 File Offset: 0x00005BE7
		public bool cboxDiTheoPP
		{
			get
			{
				return this._cboxDiTheoPP;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxDiTheoPP != value)
				{
					this.method_1("cboxDiTheoPP", value.ToString(), "", new string[0]);
				}
				this._cboxDiTheoPP = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00007A1E File Offset: 0x00005C1E
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00007A26 File Offset: 0x00005C26
		public int numQ12ChoPT
		{
			get
			{
				return this._numQ12ChoPT;
			}
			set
			{
				if (this.AllInformationLoaded && this._numQ12ChoPT != value)
				{
					this.method_1("numQ12ChoPT", value.ToString(), "", new string[0]);
				}
				this._numQ12ChoPT = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00007A5D File Offset: 0x00005C5D
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00007A65 File Offset: 0x00005C65
		public string cboQ12Xong
		{
			get
			{
				return this._cboQ12Xong;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboQ12Xong != value)
				{
					this.method_1("cboQ12Xong", value, "", new string[0]);
				}
				this._cboQ12Xong = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00007A9B File Offset: 0x00005C9B
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00007AA3 File Offset: 0x00005CA3
		public bool cboxChoParty
		{
			get
			{
				return this._cboxChoParty;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxChoParty != value)
				{
					this.method_1("cboxChoParty", value.ToString(), "", new string[0]);
				}
				this._cboxChoParty = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00007ADA File Offset: 0x00005CDA
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00007AE2 File Offset: 0x00005CE2
		public string cboLocDuoc
		{
			get
			{
				return this._cboLocDuoc;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboLocDuoc != value)
				{
					this.method_1("cboLocDuoc", value.ToString(), "", new string[0]);
				}
				this._cboLocDuoc = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00007B1D File Offset: 0x00005D1D
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00007B25 File Offset: 0x00005D25
		public bool cboxNMUutienboc
		{
			get
			{
				return this._cboxNMUutienboc;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNMUutienboc != value)
				{
					this.method_1("cboxNMUutienboc", value.ToString(), "", new string[0]);
				}
				this._cboxNMUutienboc = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00007B5C File Offset: 0x00005D5C
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00007B64 File Offset: 0x00005D64
		public bool cboxPKAnyOne
		{
			get
			{
				return this._cboxPKAnyOne;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKAnyOne != value)
				{
					this.method_1("cboxPKAnyOne", value.ToString(), "", new string[0]);
				}
				this._cboxPKAnyOne = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00007B9B File Offset: 0x00005D9B
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00007BA3 File Offset: 0x00005DA3
		public bool cboxPKNgaMyFirst
		{
			get
			{
				return this._cboxPKNgaMyFirst;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKNgaMyFirst != value)
				{
					this.method_1("cboxPKNgaMyFirst", value.ToString(), "", new string[0]);
				}
				this._cboxPKNgaMyFirst = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00007BDA File Offset: 0x00005DDA
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00007BE2 File Offset: 0x00005DE2
		public bool cboxPKThieuLamLast
		{
			get
			{
				return this._cboxPKThieuLamLast;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKThieuLamLast != value)
				{
					this.method_1("cboxPKThieuLamLast", value.ToString(), "", new string[0]);
				}
				this._cboxPKThieuLamLast = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00007C19 File Offset: 0x00005E19
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00007C21 File Offset: 0x00005E21
		public bool cboxPKPlayerList
		{
			get
			{
				return this._cboxPKPlayerList;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKPlayerList != value)
				{
					this.method_1("cboxPKPlayerList", value.ToString(), "", new string[0]);
				}
				this._cboxPKPlayerList = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00007C58 File Offset: 0x00005E58
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00007C60 File Offset: 0x00005E60
		public bool cboxPKBangList
		{
			get
			{
				return this._cboxPKBangList;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxPKBangList != value)
				{
					this.method_1("cboxPKBangList", value.ToString(), "", new string[0]);
				}
				this._cboxPKBangList = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00007C97 File Offset: 0x00005E97
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00007C9F File Offset: 0x00005E9F
		public Class210<string> PKPlayerList
		{
			get
			{
				return this._PKPlayerList;
			}
			set
			{
				this._PKPlayerList = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00007CA8 File Offset: 0x00005EA8
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00007CB0 File Offset: 0x00005EB0
		public Class210<string> PKBlackList
		{
			get
			{
				return this._PKBlackList;
			}
			set
			{
				this._PKBlackList = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00007CB9 File Offset: 0x00005EB9
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00007CC1 File Offset: 0x00005EC1
		public Class210<int> PKBangList
		{
			get
			{
				return this._PKBangList;
			}
			set
			{
				this._PKBangList = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00007CCA File Offset: 0x00005ECA
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00007CD2 File Offset: 0x00005ED2
		public int numGomMode
		{
			get
			{
				return this._numGomMode;
			}
			set
			{
				if (this.AllInformationLoaded && this._numGomMode != value)
				{
					this.method_1("numGomMode", value.ToString(), "", new string[0]);
				}
				this._numGomMode = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00007D09 File Offset: 0x00005F09
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00007D11 File Offset: 0x00005F11
		public bool cboxOnlyPet
		{
			get
			{
				return this._cboxOnlyPet;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxOnlyPet != value)
				{
					this.method_1("cboxOnlyPet", value.ToString(), "", new string[0]);
				}
				this._cboxOnlyPet = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00007D48 File Offset: 0x00005F48
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00007D50 File Offset: 0x00005F50
		public bool PTYeu
		{
			get
			{
				return this._ptYeu;
			}
			set
			{
				if (this.AllInformationLoaded && this._ptYeu != value)
				{
					this.method_1("PTYeu", value.ToString(), "", new string[0]);
				}
				this._ptYeu = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00007D87 File Offset: 0x00005F87
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00007D8F File Offset: 0x00005F8F
		public bool cboxBlacklist
		{
			get
			{
				return this._cboxBlacklist;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBlacklist != value)
				{
					this.method_1("cboxBlacklist", value.ToString(), "", new string[0]);
				}
				this._cboxBlacklist = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00007DC6 File Offset: 0x00005FC6
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00007DCE File Offset: 0x00005FCE
		public bool ChatAlert
		{
			get
			{
				return this._ChatAlert;
			}
			set
			{
				if (this.AllInformationLoaded && this._ChatAlert != value)
				{
					this.method_1("ChatAlert", value.ToString(), "", new string[0]);
				}
				this._ChatAlert = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00007E05 File Offset: 0x00006005
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00007E0D File Offset: 0x0000600D
		public int numBuffPhamVi
		{
			get
			{
				return this._numBuffPhamVi;
			}
			set
			{
				if (this.AllInformationLoaded && this._numBuffPhamVi != value)
				{
					this.method_1("numBuffPhamVi", value.ToString(), "", new string[0]);
				}
				this._numBuffPhamVi = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00007E44 File Offset: 0x00006044
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00007E4C File Offset: 0x0000604C
		public bool cboxHuyNVDanhQuai
		{
			get
			{
				return this._cboxHuyNVDanhQuai;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHuyNVDanhQuai != value)
				{
					this.method_1("cboxHuyNVDanhQuai", value.ToString(), "", new string[0]);
				}
				this._cboxHuyNVDanhQuai = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00007E83 File Offset: 0x00006083
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00007E8B File Offset: 0x0000608B
		public bool cboxHuyNVNhatDo
		{
			get
			{
				return this._cboxHuyNVNhatDo;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxHuyNVNhatDo != value)
				{
					this.method_1("cboxHuyNVNhatDo", value.ToString(), "", new string[0]);
				}
				this._cboxHuyNVNhatDo = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00007EC2 File Offset: 0x000060C2
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00007ECA File Offset: 0x000060CA
		public bool cboxThuHoachHoaChinhMinh
		{
			get
			{
				return this._cboxThuHoachHoaChinhMinh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxThuHoachHoaChinhMinh != value)
				{
					this.method_1("cboxThuHoachHoaChinhMinh", value.ToString(), "", new string[0]);
				}
				this._cboxThuHoachHoaChinhMinh = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00007F01 File Offset: 0x00006101
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00007F09 File Offset: 0x00006109
		public bool cboxBHDThoatKhiXong
		{
			get
			{
				return this._cboxBHDThoatKhiXong;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxBHDThoatKhiXong != value)
				{
					this.method_1("cboxBHDThoatKhiXong", value.ToString(), "", new string[0]);
				}
				this._cboxBHDThoatKhiXong = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00007F40 File Offset: 0x00006140
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00007F48 File Offset: 0x00006148
		public bool cboxNhatTuyetDungIm
		{
			get
			{
				return this._cboxNhatTuyetDungIm;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxNhatTuyetDungIm != value)
				{
					this.method_1("cboxNhatTuyetDungIm", value.ToString(), "", new string[0]);
				}
				this._cboxNhatTuyetDungIm = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00007F7F File Offset: 0x0000617F
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00007F87 File Offset: 0x00006187
		public bool FixLoiCuongChe
		{
			get
			{
				return this._FixLoiCuongChe;
			}
			set
			{
				if (this.AllInformationLoaded && this._FixLoiCuongChe != value)
				{
					this.method_1("FixLoiCuongChe", value.ToString(), "", new string[0]);
				}
				this._FixLoiCuongChe = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00007FBE File Offset: 0x000061BE
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00007FC6 File Offset: 0x000061C6
		public bool cboxKyCuocNhanh
		{
			get
			{
				return this._cboxKyCuocNhanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxKyCuocNhanh != value)
				{
					this.method_1("cboxKyCuocNhanh", value.ToString(), "", new string[0]);
				}
				this._cboxKyCuocNhanh = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00007FFD File Offset: 0x000061FD
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00008005 File Offset: 0x00006205
		public bool cboxLLTBNhanh
		{
			get
			{
				return this._cboxLLTBNhanh;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxLLTBNhanh != value)
				{
					this.method_1("cboxLLTBNhanh", value.ToString(), "", new string[0]);
				}
				this._cboxLLTBNhanh = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0000803C File Offset: 0x0000623C
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00008044 File Offset: 0x00006244
		public bool menuTestGame
		{
			get
			{
				return this._menuTestGame;
			}
			set
			{
				if (this.AllInformationLoaded && this._menuTestGame != value)
				{
					this.method_1("menuTestGame", value.ToString(), "", new string[0]);
				}
				this._menuTestGame = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0000807B File Offset: 0x0000627B
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00008083 File Offset: 0x00006283
		public bool menuTestBanDo
		{
			get
			{
				return this._menuTestBanDo;
			}
			set
			{
				if (this.AllInformationLoaded && this._menuTestBanDo != value)
				{
					this.method_1("menuTestBanDo", value.ToString(), "", new string[0]);
				}
				this._menuTestBanDo = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000080BA File Offset: 0x000062BA
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x000080C2 File Offset: 0x000062C2
		public bool cboxTiepTucNhiemVuNgay
		{
			get
			{
				return this._cboxTiepTucNhiemVuNgay;
			}
			set
			{
				if (this.AllInformationLoaded && this._cboxTiepTucNhiemVuNgay != value)
				{
					this.method_1("cboxTiepTucNhiemVuNgay", value.ToString(), "", new string[0]);
				}
				this._cboxTiepTucNhiemVuNgay = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x000080F9 File Offset: 0x000062F9
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00008101 File Offset: 0x00006301
		public Class57.Menpais savedMenpai
		{
			get
			{
				return this._savedMenpai;
			}
			set
			{
				if (this._savedMenpai != value)
				{
					this.method_1("savedMenpai", value.ToString(), "", new string[0]);
				}
				this._savedMenpai = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00008136 File Offset: 0x00006336
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x0000813E File Offset: 0x0000633E
		public bool LamChuParty
		{
			get
			{
				return this._LamChuParty;
			}
			set
			{
				if (this.AllInformationLoaded && this._LamChuParty != value)
				{
					this.method_1("LamChuParty", value.ToString(), "", new string[0]);
				}
				this._LamChuParty = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00008175 File Offset: 0x00006375
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x0000817D File Offset: 0x0000637D
		public bool TuMuaX2KNBKhoa
		{
			get
			{
				return this._TuMuaX2KNBKhoa;
			}
			set
			{
				if (this.AllInformationLoaded && this._TuMuaX2KNBKhoa != value)
				{
					this.method_1("TuMuaX2KNBKhoa", value.ToString(), "", new string[0]);
				}
				this._TuMuaX2KNBKhoa = value;
			}
		}

		// Token: 0x0400035D RID: 861
		private Class210<Class121> _SkillPlayerList = new Class210<Class121>();

		// Token: 0x0400035E RID: 862
		private Class210<Class121> _SkillBuffList = new Class210<Class121>();

		// Token: 0x0400035F RID: 863
		private Class210<Class121> _SkillPKList = new Class210<Class121>();

		// Token: 0x04000360 RID: 864
		private Class210<Class107> _ListItemToUse = new Class210<Class107>();

		// Token: 0x04000361 RID: 865
		private Class210<Class106> _ListItemToBuy = new Class210<Class106>();

		// Token: 0x04000362 RID: 866
		private Class57.NhatItemModes _NhatItemMode;

		// Token: 0x04000363 RID: 867
		private Class210<GClass1> _ListScheduler = new Class210<GClass1>();

		// Token: 0x04000364 RID: 868
		private bool _AllInformationLoaded;

		// Token: 0x04000365 RID: 869
		private Class57.Enum14 _AfterDeathSetting = Class57.Enum14.const_1;

		// Token: 0x04000366 RID: 870
		private Class210<string> _ListItemNhatIgnore = frmLogin.Class210_2;

		// Token: 0x04000367 RID: 871
		private Class57.AIModes _AIMode = Class57.AIModes.DANHTUDO;

		// Token: 0x04000368 RID: 872
		private int _NgaMiSkillID;

		// Token: 0x04000369 RID: 873
		private int _numNgaMyBuff = 80;

		// Token: 0x0400036A RID: 874
		private bool _usePhatQuangPhoChieu;

		// Token: 0x0400036B RID: 875
		private bool _cboxBuffPet;

		// Token: 0x0400036C RID: 876
		private int _numBuffPet = 50;

		// Token: 0x0400036D RID: 877
		private Class57.NgaMyBuffModes _nmBuffMode = Class57.NgaMyBuffModes.BuffParty;

		// Token: 0x0400036E RID: 878
		public bool cboxNMBuffParty = true;

		// Token: 0x0400036F RID: 879
		private int _numBuffPartyXH = 70;

		// Token: 0x04000370 RID: 880
		private bool _cboxTuNhatVatPham = true;

		// Token: 0x04000371 RID: 881
		private bool _cboxCongSinh;

		// Token: 0x04000372 RID: 882
		private int _numPetChoi = 85;

		// Token: 0x04000373 RID: 883
		private int _numPetHPPercent = 80;

		// Token: 0x04000374 RID: 884
		private int _cboTKCMaps = 24;

		// Token: 0x04000375 RID: 885
		private int _numMPPercent = 65;

		// Token: 0x04000376 RID: 886
		private int _numHPPercent = 60;

		// Token: 0x04000377 RID: 887
		public int MultiAccPatch = 4221135;

		// Token: 0x04000378 RID: 888
		public bool AIWhileLoop = true;

		// Token: 0x04000379 RID: 889
		private bool _cboxTuUpLevel;

		// Token: 0x0400037A RID: 890
		private int _numUpLevel = 30;

		// Token: 0x0400037B RID: 891
		private int _numPhatQuangDelay = 5;

		// Token: 0x0400037C RID: 892
		public int numGiuDoSao = 4;

		// Token: 0x0400037D RID: 893
		public int numGiuDoDong = 10;

        // Token: 0x0400037E RID: 894
        private bool _cboxVutDoKhiFull;

        // Token: 0x0400037F RID: 895
        private bool _cboxVeThanhKhiFull = true;

		// Token: 0x04000380 RID: 896
		private bool _cboxTuMuaBan = true;

		// Token: 0x04000381 RID: 897
		private bool _cboxVeThanhHetThucAn;

		// Token: 0x04000382 RID: 898
		private bool _cboxVeThanhHetBNM;

		// Token: 0x04000383 RID: 899
		private int _numVeThanhHP = 10;

		// Token: 0x04000384 RID: 900
		private int _numVeThanhMP = 5;

		// Token: 0x04000385 RID: 901
		private int _HealMapID;

		// Token: 0x04000386 RID: 902
		private int _cboPetFoodType = 2;

		// Token: 0x04000387 RID: 903
		private bool _cboxVeThanhHetMau;

		// Token: 0x04000388 RID: 904
		private bool _cboxHelpChat = true;

		// Token: 0x04000389 RID: 905
		public bool cboxAutoChat;

		// Token: 0x0400038A RID: 906
		private int _cboKenhChat = 2;

		// Token: 0x0400038B RID: 907
		private int _numAutoChat = 185;

		// Token: 0x0400038C RID: 908
		private string _AutoChatContent = "";

		// Token: 0x0400038D RID: 909
		private int _tboxIDBang = -1;

		// Token: 0x0400038E RID: 910
		private int _tBoxIDFriend = -1;

		// Token: 0x0400038F RID: 911
		private bool _cboxTNFullAuto = true;

		// Token: 0x04000390 RID: 912
		public Class57.Enum15 TraderMode = Class57.Enum15.const_4;

		// Token: 0x04000391 RID: 913
		public Class57.Enum13 TraderStatus;

		// Token: 0x04000392 RID: 914
		private int _numTNRounds = 20;

		// Token: 0x04000393 RID: 915
		private bool _cboxTNAlert = true;

		// Token: 0x04000394 RID: 916
		private bool _cboxTNAlertPK = true;

		// Token: 0x04000395 RID: 917
		private bool _cboItemTuHuy = true;

		// Token: 0x04000396 RID: 918
		private bool _cboTNTuNhanPhieu = true;

		// Token: 0x04000397 RID: 919
		public bool cboxFixKetThanh;

		// Token: 0x04000398 RID: 920
		private bool _cboxFullThungVE;

		// Token: 0x04000399 RID: 921
		private int _numFullThung = 1;

		// Token: 0x0400039A RID: 922
		private int _numBanKinhNhat = 30;

		// Token: 0x0400039B RID: 923
		private bool _cboxFullStopNhat;

		// Token: 0x0400039C RID: 924
		private string _TNLastDirection = "";

		// Token: 0x0400039D RID: 925
		public int numPetAOE = 20;

		// Token: 0x0400039E RID: 926
		public int PetAOESkillID;

		// Token: 0x0400039F RID: 927
		private List<Class67> _PetSkillPlays = new List<Class67>();

		// Token: 0x040003A0 RID: 928
		public int PetAOEDBID;

		// Token: 0x040003A1 RID: 929
		private bool _cboxPetAOE;

		// Token: 0x040003A2 RID: 930
		public string AOEPetName = "";

		// Token: 0x040003A3 RID: 931
		public string PetAOESkillName;

		// Token: 0x040003A4 RID: 932
		private int _TKCLeftX = 26;

		// Token: 0x040003A5 RID: 933
		private int _TKCLeftY = 63;

		// Token: 0x040003A6 RID: 934
		private int _TKCRightX = 99;

		// Token: 0x040003A7 RID: 935
		private int _TKCRightY = 57;

		// Token: 0x040003A8 RID: 936
		private double _CenterX;

		// Token: 0x040003A9 RID: 937
		private double _CenterY;

		// Token: 0x040003AA RID: 938
		private bool _cboxHuyetTe;

		// Token: 0x040003AB RID: 939
		private double _Diameter3 = 30.0;

		// Token: 0x040003AC RID: 940
		private double _MoveRange = 7.0;

		// Token: 0x040003AD RID: 941
		private int _MapID = -1;

		// Token: 0x040003AE RID: 942
		public float SavedPosX;

		// Token: 0x040003AF RID: 943
		public float SavedPosY;

		// Token: 0x040003B0 RID: 944
		public int SavedMapID = -1;

		// Token: 0x040003B1 RID: 945
		private int _CharDBID;

		// Token: 0x040003B2 RID: 946
		private bool _cboxCaptchaReset = true;

		// Token: 0x040003B3 RID: 947
		public bool cboxTangHinh = true;

		// Token: 0x040003B4 RID: 948
		private bool _cboxTheoSau;

		// Token: 0x040003B5 RID: 949
		private bool _cboxTurboMode = true;

		// Token: 0x040003B6 RID: 950
		public int numGomQuai = 99;

		// Token: 0x040003B7 RID: 951
		private int _numGroupID = 1;

		// Token: 0x040003B8 RID: 952
		private Class57.FightingModes _FightMode;

		// Token: 0x040003B9 RID: 953
		private bool _cboxDanhTheoKey;

		// Token: 0x040003BA RID: 954
		private bool _cboxTNChayNhanh = true;

		// Token: 0x040003BB RID: 955
		public bool cboxTuTheoDoi = true;

		// Token: 0x040003BC RID: 956
		private int _PartySavedPosX;

		// Token: 0x040003BD RID: 957
		private int _PartySavedPosY;

		// Token: 0x040003BE RID: 958
		private int _PartySavedMapID = -1;

		// Token: 0x040003BF RID: 959
		private Class210<string> _PTBlacklist = new Class210<string>();

		// Token: 0x040003C0 RID: 960
		private Class210<string> _QuaiNoAttackList = new Class210<string>();

		// Token: 0x040003C1 RID: 961
		private Class210<string> _AutoPartyList = new Class210<string>();

		// Token: 0x040003C2 RID: 962
		private bool _cboxTuVaoPT;

		// Token: 0x040003C3 RID: 963
		private bool _cboxCanX2;

		// Token: 0x040003C4 RID: 964
		public bool cboxNMBuffSelf = true;

		// Token: 0x040003C5 RID: 965
		private bool _cboxNMBuffBang;

		// Token: 0x040003C6 RID: 966
		private int _numTheoSau = 7;

		// Token: 0x040003C7 RID: 967
		private bool _cboxKhongResetGio;

		// Token: 0x040003C8 RID: 968
		private bool _cboxPKTuVe = true;

		// Token: 0x040003C9 RID: 969
		public bool cboxPKGiupDoAuto;

		// Token: 0x040003CA RID: 970
		public bool cboxPhuDaiLy = true;

		// Token: 0x040003CB RID: 971
		public bool cboxPhuMonPhai = true;

		// Token: 0x040003CC RID: 972
		public bool cboxDinhViPhu = true;

        // Token: 0x040003CD RID: 973
        private bool _cboxThoLinhChau = true;

        // Token: 0x040003CE RID: 974
        private bool _cboxChoHoiSinh;

        // Token: 0x040003CF RID: 975
        private int _numChoHoiSinh = 30;

		// Token: 0x040003D0 RID: 976
		private bool _cboxNMHoiSinhPT = true;

		// Token: 0x040003D1 RID: 977
		private bool _cboTTThuHoach = true;

		// Token: 0x040003D2 RID: 978
		private int _txtTTNPC1_ID = -1;

		// Token: 0x040003D3 RID: 979
		private int _txtTTNPC1_X;

		// Token: 0x040003D4 RID: 980
		private int _txtTTNPC1_Y;

		// Token: 0x040003D5 RID: 981
		private int _txtTTNPC2_ID = -1;

		// Token: 0x040003D6 RID: 982
		private int _txtTTNPC2_X;

		// Token: 0x040003D7 RID: 983
		private int _txtTTNPC2_Y;

		// Token: 0x040003D8 RID: 984
		private long _TrongTrotNPCTime1;

		// Token: 0x040003D9 RID: 985
		private long _TrongTrotNPCTime2;

		// Token: 0x040003DA RID: 986
		private bool _cboxDanhHoTro;

		// Token: 0x040003DB RID: 987
		private string _TrongTrotTime = "";

		// Token: 0x040003DC RID: 988
		private int _TrongTrotMapID = -1;

		// Token: 0x040003DD RID: 989
		private int _TTLoaiThuHoach = 1;

		// Token: 0x040003DE RID: 990
		private string _TTCaySeTrong = "";

		// Token: 0x040003DF RID: 991
		private bool _cboxKhaiKhoang = true;

		// Token: 0x040003E0 RID: 992
		private bool _cboxHaiDuoc = true;

		// Token: 0x040003E2 RID: 994
		private int _KhoangDuocMapID = -1;

		// Token: 0x040003E3 RID: 995
		public bool cboxATAB;

		// Token: 0x040003E4 RID: 996
		private int _cboxDuaHauCity = 2;

		// Token: 0x040003E5 RID: 997
		private bool _cboDHAlertTuu = true;

		// Token: 0x040003E6 RID: 998
		private bool _cboDHAutoNV = true;

		// Token: 0x040003E7 RID: 999
		private bool _cboDHAutoPick;

		// Token: 0x040003E8 RID: 1000
		private bool _cboDHFromCity = true;

		// Token: 0x040003E9 RID: 1001
		private int _cboxDuaHauMaps = 24;

		// Token: 0x040003EA RID: 1002
		private int _txtDHBangID = -1;

		// Token: 0x040003EB RID: 1003
		public long txtDHBangIDStamp;

		// Token: 0x040003EC RID: 1004
		public long txtDHBangIDStampFalse;

		// Token: 0x040003ED RID: 1005
		public long nhathopDuaHauStamp;

		// Token: 0x040003EE RID: 1006
		private bool _cboxNMPKBuff = true;

		// Token: 0x040003EF RID: 1007
		private int _cboATMaps = 4;

		// Token: 0x040003F0 RID: 1008
		private int _TNBuyingMode;

		// Token: 0x040003F1 RID: 1009
		private bool _cboxTNMinhGiaHigher = true;

		// Token: 0x040003F2 RID: 1010
		private bool _cboxTNFriendGiaHigher = true;

		// Token: 0x040003F3 RID: 1011
		private int _txtTNMinhGiaHigher = 6500;

		// Token: 0x040003F4 RID: 1012
		private int _txtTNFriendGia = 6500;

		// Token: 0x040003F5 RID: 1013
		private int _cboTNMinhItem = 20400069;

		// Token: 0x040003F6 RID: 1014
		private int _cboTNFriendItem = 20400069;

		// Token: 0x040003F7 RID: 1015
		private bool _cboxCanX4;

		// Token: 0x040003F8 RID: 1016
		public bool cboxGomQuaiKS = true;

		// Token: 0x040003F9 RID: 1017
		private bool _cboxNMBuffQuanDoan;

		// Token: 0x040003FA RID: 1018
		private bool _cboxBuffQuanDoan;

		// Token: 0x040003FB RID: 1019
		private bool _cboxNMBuffList;

		// Token: 0x040003FC RID: 1020
		private bool _cboxBuffHoTroOnOff = true;

		// Token: 0x040003FD RID: 1021
		public bool cboxTNRunOnly;

		// Token: 0x040003FE RID: 1022
		private bool _cboxSkillOnOff = true;

		// Token: 0x040003FF RID: 1023
		private int _PTTheoSauMode;

		// Token: 0x04000400 RID: 1024
		private string _txtTheoSauName = "";

		// Token: 0x04000401 RID: 1025
		private int _cboTrainExpMode;

		// Token: 0x04000402 RID: 1026
		private bool _cboxPhuVeThanh;

		// Token: 0x04000403 RID: 1027
		public bool cboxNoTheoSau;

		// Token: 0x04000404 RID: 1028
		private bool _cboxPassCap2;

		// Token: 0x04000405 RID: 1029
		public bool cboxGomXongVeTam = true;

		// Token: 0x04000406 RID: 1030
		private bool _cboxTuClickYes;

		// Token: 0x04000407 RID: 1031
		private string _txtPassCap2 = "";

		// Token: 0x04000408 RID: 1032
		private bool _cboxPKThoatGame;

		// Token: 0x04000409 RID: 1033
		private int _numPKThoatGame = 30;

		// Token: 0x0400040A RID: 1034
		private bool _cboxTANhanNV = true;

		// Token: 0x0400040B RID: 1035
		private bool _cboxTAHoiPhuc = true;

		// Token: 0x0400040C RID: 1036
		private bool _cboxTADungPhu = true;

		// Token: 0x0400040D RID: 1037
		private bool _cboxPhuQuaLD;

		// Token: 0x0400040E RID: 1038
		private bool _cboxPhuQuaDaiLy;

		// Token: 0x0400040F RID: 1039
		private bool _cboxLKTuNhanNV = true;

		// Token: 0x04000410 RID: 1040
		private int _txtKNB50 = 30;

		// Token: 0x04000411 RID: 1041
		private int _txtKNB200 = 120;

		// Token: 0x04000412 RID: 1042
		private int _txtKNB500 = 220;

		// Token: 0x04000413 RID: 1043
		private bool _cboxXayDung = true;

		// Token: 0x04000414 RID: 1044
		public bool cboxLuyenKimCham;

		// Token: 0x04000415 RID: 1045
		private bool _cboxXayDungPhu = true;

		// Token: 0x04000416 RID: 1046
		private bool _cboxPTChoVao;

		// Token: 0x04000417 RID: 1047
		private bool _cboxPTLevel;

		// Token: 0x04000418 RID: 1048
		private int _numPTLevel = 1;

		// Token: 0x04000419 RID: 1049
		private bool _cboxXDHoiMau = true;

		// Token: 0x0400041A RID: 1050
		private bool _cboxTBBPhiThuy = true;

		// Token: 0x0400041B RID: 1051
		public int cboABMaps = -1;

		// Token: 0x0400041C RID: 1052
		public int cboABMenuID;

		// Token: 0x0400041D RID: 1053
		private bool _cboxNMBuff = true;

		// Token: 0x0400041E RID: 1054
		public bool cboxDebugLog;

		// Token: 0x0400041F RID: 1055
		private bool _cboxXDXaPhu = true;

		// Token: 0x04000420 RID: 1056
		private bool _cboxTAXaPhu = true;

		// Token: 0x04000421 RID: 1057
		private int _cboTuDuongCon = 1;

		// Token: 0x04000422 RID: 1058
		public string AcBaPhai = frmMain.String_427;

		// Token: 0x04000423 RID: 1059
		public bool cboxABChayTim = true;

		// Token: 0x04000424 RID: 1060
		private bool _cboxLTNhanVN = true;

		// Token: 0x04000425 RID: 1061
		public long AcBaPhaiStamp;

		// Token: 0x04000426 RID: 1062
		private bool _cboxDanhTheoAi;

		// Token: 0x04000427 RID: 1063
		private string _txtDanhTheoAi = "";

		// Token: 0x04000428 RID: 1064
		private int _cboTuBaoBon;

		// Token: 0x04000429 RID: 1065
		private bool _cboxDanhQuai = true;

		// Token: 0x0400042A RID: 1066
		private bool _cboxBanKinh;

		// Token: 0x0400042B RID: 1067
		private bool _cboxAOE = true;

		// Token: 0x0400042C RID: 1068
		private bool _cboxTBBchaynhanh;

		// Token: 0x0400042D RID: 1069
		private bool _cboxNMUutienself = true;

		// Token: 0x0400042E RID: 1070
		public bool checkDanhHieu;

		// Token: 0x04000430 RID: 1072
		private bool _cboxGiuVuKhi;

		// Token: 0x04000431 RID: 1073
		private bool _cboxDuY = true;

		// Token: 0x04000432 RID: 1074
		private int _numBHDMax = 100;

		// Token: 0x04000433 RID: 1075
		private int _numBHDBanKinh = 30;

		// Token: 0x04000434 RID: 1076
		private bool _cboxBTDPhuVe = true;

		// Token: 0x04000435 RID: 1077
		private bool _cboxTKCNhanh = true;

		// Token: 0x04000436 RID: 1078
		private string _PathPointSection = "Chưa có";

		// Token: 0x04000437 RID: 1079
		private bool _cboxBTDXaPhu = true;

		// Token: 0x04000438 RID: 1080
		private bool _cboxPetList;

		// Token: 0x04000439 RID: 1081
		private bool _cboxNhatHop;

		// Token: 0x0400043A RID: 1082
		private bool _cboxNhanHop;

		// Token: 0x0400043B RID: 1083
		private int _cboBaoRuongMap = -1;

		// Token: 0x0400043C RID: 1084
		private bool _cboxBRXaPhu = true;

		// Token: 0x0400043D RID: 1085
		private bool _cboxBRTLC;

		// Token: 0x0400043E RID: 1086
		private bool _cboxDongMon = true;

		// Token: 0x0400043F RID: 1087
		private string _cboItemCheDo = "Nón";

		// Token: 0x04000440 RID: 1088
		private string _cboCheDoDTD = "Cấp 10";

		// Token: 0x04000441 RID: 1089
		private int _cboCheDoMap;

		// Token: 0x04000442 RID: 1090
		private string _cboCheDoXong = frmMain.String_704;

		// Token: 0x04000443 RID: 1091
		private int _numCheDoAmount = 50;

		// Token: 0x04000444 RID: 1092
		private bool _cboxHuyCheDo = true;

		// Token: 0x04000445 RID: 1093
		private bool _cboxBanChoNPC = true;

		// Token: 0x04000446 RID: 1094
		private bool _cboxHuyNLThua;

		// Token: 0x04000447 RID: 1095
		private int _numCheDoSao = 8;

		// Token: 0x04000448 RID: 1096
		private int _numCheDoDong = 7;

		// Token: 0x04000449 RID: 1097
		private int _numCheDoChiSo;

		// Token: 0x0400044A RID: 1098
		private int _numCheDoSLmua = 35;

		// Token: 0x0400044B RID: 1099
		private bool _cboxGiu2DongTM;

		// Token: 0x0400044C RID: 1100
		private string _cboQ1Cau = frmMain.String_694;

		// Token: 0x0400044D RID: 1101
		private bool _cboxTuHuyNV;

		// Token: 0x0400044E RID: 1102
		private bool _cboxHongQPT;

		// Token: 0x0400044F RID: 1103
		private bool _cboxDiTheoPP;

		// Token: 0x04000450 RID: 1104
		private int _numQ12ChoPT = 3;

		// Token: 0x04000451 RID: 1105
		public bool cboxChatSavedMsg;

		// Token: 0x04000452 RID: 1106
		private string _cboQ12Xong = frmMain.String_704;

		// Token: 0x04000453 RID: 1107
		private bool _cboxChoParty = true;

		// Token: 0x04000454 RID: 1108
		private string _cboLocDuoc = frmMain.String_397;

		// Token: 0x04000455 RID: 1109
		private bool _cboxNMUutienboc = true;

		// Token: 0x04000456 RID: 1110
		public bool _cboxPKAnyOne;

		// Token: 0x04000457 RID: 1111
		public bool _cboxPKNgaMyFirst = true;

		// Token: 0x04000458 RID: 1112
		public bool _cboxPKThieuLamLast = true;

		// Token: 0x04000459 RID: 1113
		public bool _cboxPKPlayerList;

		// Token: 0x0400045A RID: 1114
		public bool _cboxPKBangList;

		// Token: 0x0400045B RID: 1115
		public bool cboxPKEnable;

		// Token: 0x0400045C RID: 1116
		private Class210<string> _PKPlayerList = new Class210<string>();

		// Token: 0x0400045D RID: 1117
		private Class210<string> _PKBlackList = new Class210<string>();

		// Token: 0x0400045E RID: 1118
		private Class210<int> _PKBangList = new Class210<int>();

		// Token: 0x0400045F RID: 1119
		private int _numGomMode = 1;

		// Token: 0x04000460 RID: 1120
		private bool _cboxOnlyPet;

		// Token: 0x04000461 RID: 1121
		private bool _ptYeu;

		// Token: 0x04000462 RID: 1122
		private bool _cboxBlacklist = true;

		// Token: 0x04000463 RID: 1123
		private bool _ChatAlert = true;

		// Token: 0x04000464 RID: 1124
		public bool DungNgua = true;

		// Token: 0x04000465 RID: 1125
		public bool cboxVIPPM;

		// Token: 0x04000466 RID: 1126
		private int _numBuffPhamVi = 25;

		// Token: 0x04000467 RID: 1127
		private bool _cboxHuyNVDanhQuai;

		// Token: 0x04000468 RID: 1128
		private bool _cboxHuyNVNhatDo;

		// Token: 0x04000469 RID: 1129
		private bool _cboxThuHoachHoaChinhMinh;

		// Token: 0x0400046A RID: 1130
		private bool _cboxBHDThoatKhiXong = true;

		// Token: 0x0400046B RID: 1131
		private bool _cboxNhatTuyetDungIm;

		// Token: 0x0400046C RID: 1132
		private bool _FixLoiCuongChe;

		// Token: 0x0400046D RID: 1133
		private bool _cboxKyCuocNhanh;

		// Token: 0x0400046E RID: 1134
		private bool _cboxLLTBNhanh;

		// Token: 0x0400046F RID: 1135
		private bool _menuTestGame;

		// Token: 0x04000470 RID: 1136
		private bool _menuTestBanDo;

		// Token: 0x04000471 RID: 1137
		private bool _cboxTiepTucNhiemVuNgay = true;

		// Token: 0x04000472 RID: 1138
		private Class57.Menpais _savedMenpai = Class57.Menpais.NOMENPAI;

		// Token: 0x04000473 RID: 1139
		private bool _LamChuParty;

		// Token: 0x04000474 RID: 1140
		private bool _TuMuaX2KNBKhoa;
	}
}
