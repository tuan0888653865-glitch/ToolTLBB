using System;
using System.Collections.Generic;

namespace ns0
{
	// Token: 0x0200006C RID: 108
	internal sealed class Class75
	{
		// Token: 0x06000393 RID: 915 RVA: 0x0006CAB4 File Offset: 0x0006ACB4
		internal Class75(Class58 class58_1)
		{
			this.class58_0 = class58_1;
			this.list_4.Add(new Class75.Class78
			{
				int_0 = 38001527,
				string_0 = "Kẹo"
			});
			this.list_4.Add(new Class75.Class78
			{
				int_0 = 38001528,
				string_0 = "Gấu Con"
			});
			this.list_4.Add(new Class75.Class78
			{
				int_0 = 38001529,
				string_0 = "Socola"
			});
			this.list_4.Add(new Class75.Class78
			{
				int_0 = 38001530,
				string_0 = "Bóng Màu"
			});
			this.list_4.Add(new Class75.Class78
			{
				int_0 = 38001531,
				string_0 = "Ruy Băng"
			});
			this.list_4.Add(new Class75.Class78
			{
				int_0 = 38001532,
				string_0 = "Táo"
			});
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00004255 File Offset: 0x00002455
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0006CCA0 File Offset: 0x0006AEA0
		internal bool Boolean_0
		{
			get
			{
				return this.bool_11;
			}
			set
			{
				if (value != this.bool_11)
				{
					this.bool_11 = value;
					if (this.class58_0 != null && this.class58_0.gclass2_0 != null)
					{
						this.class58_0.gclass2_0.GameStarted = value;
						if (value && this.class58_0.gclass2_0.imgCaptcha != null)
						{
							this.class58_0.gclass2_0.imgCaptcha = null;
						}
					}
				}
			}
		}

		// Token: 0x040001F7 RID: 503
		internal Class58 class58_0;

		// Token: 0x040001F8 RID: 504
		internal bool bool_0;

		// Token: 0x040001F9 RID: 505
		internal long long_0;

		// Token: 0x040001FA RID: 506
		internal long long_1;

		// Token: 0x040001FB RID: 507
		internal int int_0;

		// Token: 0x040001FC RID: 508
		internal int int_1;

		// Token: 0x040001FD RID: 509
		internal int int_2;

		// Token: 0x040001FE RID: 510
		internal int int_3;

		// Token: 0x040001FF RID: 511
		internal int int_4;

		// Token: 0x04000200 RID: 512
		internal int int_5;

		// Token: 0x04000201 RID: 513
		internal int int_6;

		// Token: 0x04000202 RID: 514
		internal int int_7;

		// Token: 0x04000203 RID: 515
		internal object object_0 = new object();

		// Token: 0x04000204 RID: 516
		internal int int_8;

		// Token: 0x04000205 RID: 517
		internal long long_2;

		// Token: 0x04000206 RID: 518
		internal bool bool_1;

		// Token: 0x04000207 RID: 519
		internal bool bool_2;

		// Token: 0x04000208 RID: 520
		internal bool bool_3;

		// Token: 0x04000209 RID: 521
		internal bool bool_4;

		// Token: 0x0400020A RID: 522
		internal int int_9;

		// Token: 0x0400020B RID: 523
		internal int int_10;

		// Token: 0x0400020C RID: 524
		internal int int_11;

		// Token: 0x0400020D RID: 525
		internal long long_3;

		// Token: 0x0400020E RID: 526
		internal long long_4;

		// Token: 0x0400020F RID: 527
		internal long long_5;

		// Token: 0x04000210 RID: 528
		internal long long_6;

		// Token: 0x04000211 RID: 529
		internal long long_7;

		// Token: 0x04000212 RID: 530
		internal long long_8;

		// Token: 0x04000213 RID: 531
		internal long long_9;

		// Token: 0x04000214 RID: 532
		internal long long_10;

		// Token: 0x04000215 RID: 533
		internal long long_11;

		// Token: 0x04000216 RID: 534
		internal long long_12;

		// Token: 0x04000217 RID: 535
		internal long long_13;

		// Token: 0x04000218 RID: 536
		internal long long_14;

		// Token: 0x04000219 RID: 537
		internal long long_15;

		// Token: 0x0400021A RID: 538
		internal int int_12;

		// Token: 0x0400021B RID: 539
		internal long long_16;

		// Token: 0x0400021C RID: 540
		internal long long_17;

		// Token: 0x0400021D RID: 541
		internal long long_18;

		// Token: 0x0400021E RID: 542
		internal bool bool_5;

		// Token: 0x0400021F RID: 543
		internal int int_13;

		// Token: 0x04000220 RID: 544
		internal bool bool_6;

		// Token: 0x04000221 RID: 545
		internal bool bool_7;

		// Token: 0x04000222 RID: 546
		internal List<string> list_0 = new List<string>();

		// Token: 0x04000223 RID: 547
		internal byte[] byte_0 = new byte[577];

		// Token: 0x04000224 RID: 548
		internal long long_19;

		// Token: 0x04000225 RID: 549
		internal bool bool_8;

		// Token: 0x04000226 RID: 550
		internal Class57.FightingModes fightingModes_0 = Class57.FightingModes.DANHPETONLY;

		// Token: 0x04000227 RID: 551
		internal int int_14;

		// Token: 0x04000228 RID: 552
		internal bool bool_9;

		// Token: 0x04000229 RID: 553
		internal bool bool_10;

		// Token: 0x0400022A RID: 554
		internal long long_20;

		// Token: 0x0400022B RID: 555
		internal long long_21;

		// Token: 0x0400022C RID: 556
		private bool bool_11;

		// Token: 0x0400022D RID: 557
		internal int int_15;

		// Token: 0x0400022E RID: 558
		internal int int_16 = -1;

		// Token: 0x0400022F RID: 559
		internal long long_22;

		// Token: 0x04000230 RID: 560
		internal bool bool_12 = true;

		// Token: 0x04000231 RID: 561
		internal bool bool_13;

		// Token: 0x04000232 RID: 562
		internal int int_17;

		// Token: 0x04000233 RID: 563
		internal int int_18;

		// Token: 0x04000234 RID: 564
		internal int int_19;

		// Token: 0x04000235 RID: 565
		internal long long_23;

		// Token: 0x04000236 RID: 566
		internal bool bool_14;

		// Token: 0x04000237 RID: 567
		internal bool bool_15;

		// Token: 0x04000238 RID: 568
		internal long long_24;

		// Token: 0x04000239 RID: 569
		internal bool bool_16;

		// Token: 0x0400023A RID: 570
		internal long long_25;

		// Token: 0x0400023B RID: 571
		internal long long_26;

		// Token: 0x0400023C RID: 572
		internal bool bool_17;

		// Token: 0x0400023D RID: 573
		internal bool bool_18;

		// Token: 0x0400023E RID: 574
		internal bool bool_19;

		// Token: 0x0400023F RID: 575
		internal long long_27;

		// Token: 0x04000240 RID: 576
		internal bool bool_20;

		// Token: 0x04000241 RID: 577
		internal int int_20;

		// Token: 0x04000242 RID: 578
		internal long long_28;

		// Token: 0x04000243 RID: 579
		internal int int_21;

		// Token: 0x04000244 RID: 580
		internal bool bool_21;

		// Token: 0x04000245 RID: 581
		internal int int_22;

		// Token: 0x04000246 RID: 582
		internal long long_29;

		// Token: 0x04000247 RID: 583
		internal int int_23;

		// Token: 0x04000248 RID: 584
		internal long long_30;

		// Token: 0x04000249 RID: 585
		internal long long_31;

		// Token: 0x0400024A RID: 586
		internal long long_32;

		// Token: 0x0400024B RID: 587
		internal int int_24;

		// Token: 0x0400024C RID: 588
		internal int int_25 = -1;

		// Token: 0x0400024D RID: 589
		internal int int_26 = -1;

		// Token: 0x0400024E RID: 590
		internal long long_33;

		// Token: 0x0400024F RID: 591
		internal long long_34;

		// Token: 0x04000250 RID: 592
		internal long long_35;

		// Token: 0x04000251 RID: 593
		internal bool bool_22;

		// Token: 0x04000252 RID: 594
		internal string string_0;

		// Token: 0x04000253 RID: 595
		internal long long_36;

		// Token: 0x04000254 RID: 596
		internal long long_37;

		// Token: 0x04000255 RID: 597
		internal long long_38;

		// Token: 0x04000256 RID: 598
		internal int int_27;

		// Token: 0x04000257 RID: 599
		internal int int_28;

		// Token: 0x04000258 RID: 600
		internal int int_29;

		// Token: 0x04000259 RID: 601
		internal int int_30;

		// Token: 0x0400025A RID: 602
		internal int int_31;

		// Token: 0x0400025B RID: 603
		internal int int_32;

		// Token: 0x0400025C RID: 604
		internal int int_33;

		// Token: 0x0400025D RID: 605
		internal bool bool_23;

		// Token: 0x0400025E RID: 606
		internal long long_39;

		// Token: 0x0400025F RID: 607
		internal int int_34;

		// Token: 0x04000260 RID: 608
		internal long long_40;

		// Token: 0x04000261 RID: 609
		internal bool bool_24;

		// Token: 0x04000262 RID: 610
		internal long long_41;

		// Token: 0x04000263 RID: 611
		internal long long_42;

		// Token: 0x04000264 RID: 612
		internal long long_43;

		// Token: 0x04000265 RID: 613
		internal long long_44;

		// Token: 0x04000266 RID: 614
		internal bool bool_25;

		// Token: 0x04000267 RID: 615
		internal bool bool_26;

		// Token: 0x04000268 RID: 616
		internal bool bool_27;

		// Token: 0x04000269 RID: 617
		internal bool bool_28;

		// Token: 0x0400026A RID: 618
		internal int int_35;

		// Token: 0x0400026B RID: 619
		internal bool bool_29;

		// Token: 0x0400026C RID: 620
		internal object object_1 = new object();

		// Token: 0x0400026D RID: 621
		internal long long_45;

		// Token: 0x0400026E RID: 622
		internal long long_46;

		// Token: 0x0400026F RID: 623
		internal long long_47;

		// Token: 0x04000270 RID: 624
		internal int int_36;

		// Token: 0x04000271 RID: 625
		internal int int_37 = 402276;

		// Token: 0x04000272 RID: 626
		internal long long_48;

		// Token: 0x04000273 RID: 627
		internal int int_38;

		// Token: 0x04000274 RID: 628
		internal long long_49;

		// Token: 0x04000275 RID: 629
		internal int int_39;

		// Token: 0x04000276 RID: 630
		internal int int_40 = 10;

		// Token: 0x04000277 RID: 631
		internal int int_41;

		// Token: 0x04000278 RID: 632
		internal long long_50;

		// Token: 0x04000279 RID: 633
		internal float float_0;

		// Token: 0x0400027A RID: 634
		internal float float_1;

		// Token: 0x0400027B RID: 635
		internal int int_42;

		// Token: 0x0400027C RID: 636
		internal int int_43;

		// Token: 0x0400027D RID: 637
		internal List<long> list_1 = new List<long>();

		// Token: 0x0400027E RID: 638
		internal bool bool_30;

		// Token: 0x0400027F RID: 639
		internal List<Class75.Class76> list_2 = new List<Class75.Class76>();

		// Token: 0x04000280 RID: 640
		internal int int_44 = 100;

		// Token: 0x04000281 RID: 641
		internal int int_45;

		// Token: 0x04000282 RID: 642
		internal int int_46;

		// Token: 0x04000283 RID: 643
		internal int int_47;

		// Token: 0x04000284 RID: 644
		internal int int_48;

		// Token: 0x04000285 RID: 645
		internal int int_49;

		// Token: 0x04000286 RID: 646
		internal long long_51;

		// Token: 0x04000287 RID: 647
		internal int int_50;

		// Token: 0x04000288 RID: 648
		internal object object_2 = new object();

		// Token: 0x04000289 RID: 649
		internal long long_52;

		// Token: 0x0400028A RID: 650
		internal object object_3 = new object();

		// Token: 0x0400028B RID: 651
		internal int int_51;

		// Token: 0x0400028C RID: 652
		internal long long_53;

		// Token: 0x0400028D RID: 653
		internal long long_54;

		// Token: 0x0400028E RID: 654
		internal object object_4 = new object();

		// Token: 0x0400028F RID: 655
		internal int int_52 = -1;

		// Token: 0x04000290 RID: 656
		internal int int_53 = -1;

		// Token: 0x04000291 RID: 657
		internal int int_54 = -1;

		// Token: 0x04000292 RID: 658
		internal long long_55;

		// Token: 0x04000293 RID: 659
		internal List<Class75.Class77> list_3 = new List<Class75.Class77>();

		// Token: 0x04000294 RID: 660
		internal int int_55;

		// Token: 0x04000295 RID: 661
		internal long long_56;

		// Token: 0x04000296 RID: 662
		internal long long_57;

		// Token: 0x04000297 RID: 663
		public long long_58;

		// Token: 0x04000298 RID: 664
		internal List<Class75.Class78> list_4 = new List<Class75.Class78>();

		// Token: 0x04000299 RID: 665
		public int int_56;

		// Token: 0x0400029A RID: 666
		public long long_59;

		// Token: 0x0400029B RID: 667
		public int int_57 = -1;

		// Token: 0x0400029C RID: 668
		public int int_58;

		// Token: 0x0400029D RID: 669
		public int int_59;

		// Token: 0x0400029E RID: 670
		internal long long_60;

		// Token: 0x0400029F RID: 671
		internal long long_61;

		// Token: 0x040002A0 RID: 672
		internal string string_1 = "";

		// Token: 0x040002A1 RID: 673
		internal int int_60;

		// Token: 0x040002A2 RID: 674
		internal string string_2 = "";

		// Token: 0x0200006D RID: 109
		internal sealed class Class76
		{
			// Token: 0x040002A3 RID: 675
			internal float float_0;

			// Token: 0x040002A4 RID: 676
			internal float float_1;

			// Token: 0x040002A5 RID: 677
			internal long long_0;
		}

		// Token: 0x0200006E RID: 110
		internal sealed class Class77
		{
			// Token: 0x040002A6 RID: 678
			internal long long_0;

			// Token: 0x040002A7 RID: 679
			internal int int_0 = 3000;
		}

		// Token: 0x0200006F RID: 111
		internal sealed class Class78
		{
			// Token: 0x040002A8 RID: 680
			internal int int_0;

			// Token: 0x040002A9 RID: 681
			internal string string_0 = "";
		}
	}
}
