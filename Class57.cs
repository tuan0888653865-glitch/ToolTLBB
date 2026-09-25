using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000047 RID: 71
	internal abstract class Class57 : INotifyPropertyChanged
	{
		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000361 RID: 865 RVA: 0x0006AEDC File Offset: 0x000690DC
		// (remove) Token: 0x06000362 RID: 866 RVA: 0x0006AF14 File Offset: 0x00069114
		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0006AF4C File Offset: 0x0006914C
		protected void method_0(string string_0)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(string_0));
			}
		}

		// Token: 0x0400012F RID: 303
		[CompilerGenerated]
		private PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x02000048 RID: 72
		internal enum Enum1
		{
			// Token: 0x04000131 RID: 305
			const_0 = 1,
			// Token: 0x04000132 RID: 306
			const_1,
			// Token: 0x04000133 RID: 307
			const_2,
			// Token: 0x04000134 RID: 308
			const_3,
			// Token: 0x04000135 RID: 309
			const_4,
			// Token: 0x04000136 RID: 310
			const_5,
			// Token: 0x04000137 RID: 311
			const_6,
			// Token: 0x04000138 RID: 312
			const_7,
			// Token: 0x04000139 RID: 313
			const_8
		}

		// Token: 0x02000049 RID: 73
		internal enum Enum2
		{
			// Token: 0x0400013B RID: 315
			const_0,
			// Token: 0x0400013C RID: 316
			const_1 = 2,
			// Token: 0x0400013D RID: 317
			const_2 = 4,
			// Token: 0x0400013E RID: 318
			const_3
		}

		// Token: 0x0200004A RID: 74
		internal enum Enum3
		{
			// Token: 0x04000140 RID: 320
			const_0,
			// Token: 0x04000141 RID: 321
			const_1,
			// Token: 0x04000142 RID: 322
			const_2,
			// Token: 0x04000143 RID: 323
			const_3,
			// Token: 0x04000144 RID: 324
			const_4
		}

		// Token: 0x0200004B RID: 75
		internal enum Enum4
		{
			// Token: 0x04000146 RID: 326
			const_0,
			// Token: 0x04000147 RID: 327
			const_1,
			// Token: 0x04000148 RID: 328
			const_2,
			// Token: 0x04000149 RID: 329
			const_3,
			// Token: 0x0400014A RID: 330
			const_4,
			// Token: 0x0400014B RID: 331
			const_5,
			// Token: 0x0400014C RID: 332
			const_6,
			// Token: 0x0400014D RID: 333
			const_7
		}

		// Token: 0x0200004C RID: 76
		internal enum Enum5
		{
			// Token: 0x0400014F RID: 335
			const_0,
			// Token: 0x04000150 RID: 336
			const_1,
			// Token: 0x04000151 RID: 337
			const_2,
			// Token: 0x04000152 RID: 338
			const_3
		}

		// Token: 0x0200004D RID: 77
		internal enum NgaMyBuffModes
		{
			// Token: 0x04000154 RID: 340
			BuffSelfOnly,
			// Token: 0x04000155 RID: 341
			BuffParty
		}

		// Token: 0x0200004E RID: 78
		internal enum Enum6
		{
			// Token: 0x04000157 RID: 343
			const_0,
			// Token: 0x04000158 RID: 344
			const_1
		}

		// Token: 0x0200004F RID: 79
		internal enum Enum7
		{
			// Token: 0x0400015A RID: 346
			const_0,
			// Token: 0x0400015B RID: 347
			const_1,
			// Token: 0x0400015C RID: 348
			const_2,
			// Token: 0x0400015D RID: 349
			const_3,
			// Token: 0x0400015E RID: 350
			const_4 = 21,
			// Token: 0x0400015F RID: 351
			const_5
		}

		// Token: 0x02000050 RID: 80
		internal enum Enum8
		{
			// Token: 0x04000161 RID: 353
			const_0 = 5,
			// Token: 0x04000162 RID: 354
			const_1 = 1045820,
			// Token: 0x04000163 RID: 355
			const_2 = 4088
		}

		// Token: 0x02000051 RID: 81
		internal enum Enum9
		{
			// Token: 0x04000165 RID: 357
			const_0 = 1,
			// Token: 0x04000166 RID: 358
			const_1
		}

		// Token: 0x02000052 RID: 82
		internal enum Enum10
		{
			// Token: 0x04000168 RID: 360
			const_0,
			// Token: 0x04000169 RID: 361
			const_1,
			// Token: 0x0400016A RID: 362
			const_2
		}

		// Token: 0x02000053 RID: 83
		internal enum Enum11
		{
			// Token: 0x0400016C RID: 364
			const_0,
			// Token: 0x0400016D RID: 365
			const_1
		}

		// Token: 0x02000054 RID: 84
		internal enum Menpais
		{
			// Token: 0x0400016F RID: 367
			[Description("Chưa vào phái")]
			NOMENPAI = 9,
			// Token: 0x04000170 RID: 368
			[Description("Nga My")]
			NGAMI = 4,
			// Token: 0x04000171 RID: 369
			[Description("Minh Giáo")]
			MINHGIAO = 1,
			// Token: 0x04000172 RID: 370
			CAIBANG,
			// Token: 0x04000173 RID: 371
			VODANG,
			// Token: 0x04000174 RID: 372
			TINHTUC = 5,
			// Token: 0x04000175 RID: 373
			THIENSON = 7,
			// Token: 0x04000176 RID: 374
			THIENLONG = 6,
			// Token: 0x04000177 RID: 375
			QUYCOC = 12,
			// Token: 0x04000178 RID: 376
			THIEULAM = 0,
			// Token: 0x04000179 RID: 377
			[Description("Tiêu Dao")]
			TIEUDAO = 8,
			// Token: 0x0400017A RID: 378
			MODUNG = 10,
			// Token: 0x0400017B RID: 379
			DUONGMON,
			// Token: 0x0400017C RID: 380
			DAOHOA = 13,
			// Token: 0x0400017D RID: 381
			TUYETTINH,
			// Token: 0x0400017E RID: 382
			ALLPHAI = 99
		}

		// Token: 0x02000055 RID: 85
		internal enum Enum12
		{
			// Token: 0x04000180 RID: 384
			const_0 = 1,
			// Token: 0x04000181 RID: 385
			const_1,
			// Token: 0x04000182 RID: 386
			const_2
		}

		// Token: 0x02000056 RID: 86
		internal enum Enum13
		{
			// Token: 0x04000184 RID: 388
			const_0,
			// Token: 0x04000185 RID: 389
			const_1 = 2,
			// Token: 0x04000186 RID: 390
			const_2 = 100,
			// Token: 0x04000187 RID: 391
			const_3,
			// Token: 0x04000188 RID: 392
			const_4,
			// Token: 0x04000189 RID: 393
			const_5 = 200,
			// Token: 0x0400018A RID: 394
			const_6,
			// Token: 0x0400018B RID: 395
			const_7 = 205,
			// Token: 0x0400018C RID: 396
			const_8 = 250,
			// Token: 0x0400018D RID: 397
			const_9,
			// Token: 0x0400018E RID: 398
			const_10 = 350,
			// Token: 0x0400018F RID: 399
			const_11,
			// Token: 0x04000190 RID: 400
			const_12,
			// Token: 0x04000191 RID: 401
			const_13,
			// Token: 0x04000192 RID: 402
			const_14,
			// Token: 0x04000193 RID: 403
			const_15 = 9996,
			// Token: 0x04000194 RID: 404
			const_16,
			// Token: 0x04000195 RID: 405
			const_17,
			// Token: 0x04000196 RID: 406
			const_18,
			// Token: 0x04000197 RID: 407
			const_19,
			// Token: 0x04000198 RID: 408
			const_20,
			// Token: 0x04000199 RID: 409
			const_21
		}

		// Token: 0x02000057 RID: 87
		internal enum Enum14
		{
			// Token: 0x0400019B RID: 411
			const_0,
			// Token: 0x0400019C RID: 412
			const_1,
			// Token: 0x0400019D RID: 413
			const_2
		}

		// Token: 0x02000058 RID: 88
		internal enum NhatItemModes
		{
			// Token: 0x0400019F RID: 415
			NHATHET,
			// Token: 0x040001A0 RID: 416
			NHATLIST,
			// Token: 0x040001A1 RID: 417
			NHATLOAITRU
		}

		// Token: 0x02000059 RID: 89
		internal enum FightingModes
		{
			// Token: 0x040001A3 RID: 419
			DANHTUNGCON,
			// Token: 0x040001A4 RID: 420
			DANHGOMQUAI,
			// Token: 0x040001A5 RID: 421
			DANHPETONLY
		}

		// Token: 0x0200005A RID: 90
		internal enum Enum15
		{
			// Token: 0x040001A7 RID: 423
			const_0,
			// Token: 0x040001A8 RID: 424
			const_1,
			// Token: 0x040001A9 RID: 425
			const_2,
			// Token: 0x040001AA RID: 426
			const_3,
			// Token: 0x040001AB RID: 427
			const_4,
			// Token: 0x040001AC RID: 428
			const_5
		}

		// Token: 0x0200005B RID: 91
		internal enum AIModes
		{
			// Token: 0x040001AE RID: 430
			DANHQUANHDIEM,
			// Token: 0x040001AF RID: 431
			DANHTUDO,
			// Token: 0x040001B0 RID: 432
			HOTRO,
			// Token: 0x040001B1 RID: 433
			KHAIKHOANG_HAIDUOC,
			// Token: 0x040001B2 RID: 434
			TRONGTROT,
			// Token: 0x040001B3 RID: 435
			THUONGNHAN,
			// Token: 0x040001B4 RID: 436
			SCRIPTING,
			// Token: 0x040001B5 RID: 437
			NHIEMVU
		}
	}
}
