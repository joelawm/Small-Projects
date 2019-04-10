using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy_ASCII_Writing
{
	class Program
	{
		//Place Holder for conversion name
		static string name = "WELCOME MR. MEYER";

		static string FinalOutput1;
		static string FinalOutput2;
		static string FinalOutput3;
		static string FinalOutput4;
		static string FinalOutput5;
		static string FinalOutput6;
		static string FinalOutput7;
		//Main Event
		static void Main(string[] args)
		{
			//Finds the value!
			foreach(char c in name)
			{
				//Console.WriteLine(c);
				if (c == 'A')
				{
					string A1 = "   #    ";
					string A2 = "  # #   ";
					string A3 = " #   #  ";
					string A4 = "#     # ";
					string A5 = "####### ";
					string A6 = "#     # ";
					string A7 = "#     # ";

					FinalOutput1 += A1;
					FinalOutput2 += A2;
					FinalOutput3 += A3;
					FinalOutput4 += A4;
					FinalOutput5 += A5;
					FinalOutput6 += A6;
					FinalOutput7 += A7;
				}

				if (c == 'B')
				{
					string B1 = "######  ";
					string B2 = "#     # ";
					string B3 = "#     # ";
					string B4 = "######  ";
					string B5 = "#     # ";
					string B6 = "#     # ";
					string B7 = "######  ";

					FinalOutput1 += B1;
					FinalOutput2 += B2;
					FinalOutput3 += B3;
					FinalOutput4 += B4;
					FinalOutput5 += B5;
					FinalOutput6 += B6;
					FinalOutput7 += B7;
				}
				if (c == 'C')
				{
					string A1 = " #####  ";
					string A2 = "#     # ";
					string A3 = "#       ";
					string A4 = "#       ";
					string A5 = "#       ";
					string A6 = "#     # ";
					string A7 = " #####  ";

					FinalOutput1 += A1;
					FinalOutput2 += A2;
					FinalOutput3 += A3;
					FinalOutput4 += A4;
					FinalOutput5 += A5;
					FinalOutput6 += A6;
					FinalOutput7 += A7;
				}
				if (c == 'D')
				{
                    string D1 = "######  ";
                    string D2 = "#     # ";
                    string D3 = "#     # ";
                    string D4 = "#     # ";
                    string D5 = "#     # ";
                    string D6 = "#     # ";
                    string D7 = "######  ";

                    FinalOutput1 += D1;
                    FinalOutput2 += D2;
                    FinalOutput3 += D3;
                    FinalOutput4 += D4;
                    FinalOutput5 += D5;
                    FinalOutput6 += D6;
                    FinalOutput7 += D7;
                }
				if (c == 'E')
				{
                    string E1 = "####### ";
                    string E2 = "#       ";
                    string E3 = "#       ";
                    string E4 = "#####   ";
                    string E5 = "#       ";
                    string E6 = "#       ";
                    string E7 = "####### ";

                    FinalOutput1 += E1;
                    FinalOutput2 += E2;
                    FinalOutput3 += E3;
                    FinalOutput4 += E4;
                    FinalOutput5 += E5;
                    FinalOutput6 += E6;
                    FinalOutput7 += E7;
                }
				if (c == 'F')
				{
                    string F1 = "####### ";
                    string F2 = "#       ";
                    string F3 = "#       ";
                    string F4 = "#####   ";
                    string F5 = "#       ";
                    string F6 = "#       ";
                    string F7 = "#       ";

                    FinalOutput1 += F1;
                    FinalOutput2 += F2;
                    FinalOutput3 += F3;
                    FinalOutput4 += F4;
                    FinalOutput5 += F5;
                    FinalOutput6 += F6;
                    FinalOutput7 += F7;
                }
				if (c == 'G')
				{
                    string G1 = " #####  ";
                    string G2 = "#     # ";
                    string G3 = "#       ";
                    string G4 = "#  #### ";
                    string G5 = "#     # ";
                    string G6 = "#     # ";
                    string G7 = " #####  ";

                    FinalOutput1 += G1;
                    FinalOutput2 += G2;
                    FinalOutput3 += G3;
                    FinalOutput4 += G4;
                    FinalOutput5 += G5;
                    FinalOutput6 += G6;
                    FinalOutput7 += G7;
                }
				if (c == 'H')
				{
                    string H1 = "#     # ";
                    string H2 = "#     # ";
                    string H3 = "#     # ";
                    string H4 = "####### ";
                    string H5 = "#     # ";
                    string H6 = "#     # ";
                    string H7 = "#     # ";

                    FinalOutput1 += H1;
                    FinalOutput2 += H2;
                    FinalOutput3 += H3;
                    FinalOutput4 += H4;
                    FinalOutput5 += H5;
                    FinalOutput6 += H6;
                    FinalOutput7 += H7;
                }
				if (c == 'I')
				{
                    string I1 = "### ";
                    string I2 = " #  ";
                    string I3 = " #  ";
                    string I4 = " #  ";
                    string I5 = " #  ";
                    string I6 = " #  ";
                    string I7 = "### ";

                    FinalOutput1 += I1;
                    FinalOutput2 += I2;
                    FinalOutput3 += I3;
                    FinalOutput4 += I4;
                    FinalOutput5 += I5;
                    FinalOutput6 += I6;
                    FinalOutput7 += I7;
                }
				if (c == 'J')
				{
                    string J1 = "      # ";
                    string J2 = "      # ";
                    string J3 = "      # ";
                    string J4 = "      # ";
                    string J5 = "#     # ";
                    string J6 = "#     # ";
                    string J7 = "######  ";

                    FinalOutput1 += J1;
                    FinalOutput2 += J2;
                    FinalOutput3 += J3;
                    FinalOutput4 += J4;
                    FinalOutput5 += J5;
                    FinalOutput6 += J6;
                    FinalOutput7 += J7;
                }
				if (c == 'K')
				{
                    string K1 = "#    # ";
                    string K2 = "#   #  ";
                    string K3 = "#  #   ";
                    string K4 = "###    ";
                    string K5 = "#  #   ";
                    string K6 = "#   #  ";
                    string K7 = "#    # ";

                    FinalOutput1 += K1;
                    FinalOutput2 += K2;
                    FinalOutput3 += K3;
                    FinalOutput4 += K4;
                    FinalOutput5 += K5;
                    FinalOutput6 += K6;
                    FinalOutput7 += K7;
                }
				if (c == 'L')
				{
                    string L1 = "#       ";
                    string L2 = "#       ";
                    string L3 = "#       ";
                    string L4 = "#       ";
                    string L5 = "#       ";
                    string L6 = "#       ";
                    string L7 = "####### ";

                    FinalOutput1 += L1;
                    FinalOutput2 += L2;
                    FinalOutput3 += L3;
                    FinalOutput4 += L4;
                    FinalOutput5 += L5;
                    FinalOutput6 += L6;
                    FinalOutput7 += L7;
                }
				if (c == 'M')
				{
                    string M1 = "#     # ";
                    string M2 = "##   ## ";
                    string M3 = "# # # # ";
                    string M4 = "#  #  # ";
                    string M5 = "#     # ";
                    string M6 = "#     # ";
                    string M7 = "#     # ";

                    FinalOutput1 += M1;
                    FinalOutput2 += M2;
                    FinalOutput3 += M3;
                    FinalOutput4 += M4;
                    FinalOutput5 += M5;
                    FinalOutput6 += M6;
                    FinalOutput7 += M7;
                }
				if (c == 'N')
				{
                    string N1 = "#     # ";
                    string N2 = "##    # ";
                    string N3 = "# #   # ";
                    string N4 = "#  #  # ";
                    string N5 = "#   # # ";
                    string N6 = "#    ## ";
                    string N7 = "#     # ";

                    FinalOutput1 += N1;
                    FinalOutput2 += N2;
                    FinalOutput3 += N3;
                    FinalOutput4 += N4;
                    FinalOutput5 += N5;
                    FinalOutput6 += N6;
                    FinalOutput7 += N7;
                }
				if (c == 'O')
				{
                    string O1 = "####### ";
                    string O2 = "#     # ";
                    string O3 = "#     # ";
                    string O4 = "#     # ";
                    string O5 = "#     # ";
                    string O6 = "#     # ";
                    string O7 = "####### ";

                    FinalOutput1 += O1;
                    FinalOutput2 += O2;
                    FinalOutput3 += O3;
                    FinalOutput4 += O4;
                    FinalOutput5 += O5;
                    FinalOutput6 += O6;
                    FinalOutput7 += O7;
                }
				if (c == 'P')
				{
                    string P1 = "######  ";
                    string P2 = "#     # ";
                    string P3 = "#     # ";
                    string P4 = "######  ";
                    string P5 = "#       ";
                    string P6 = "#       ";
                    string P7 = "#       ";

                    FinalOutput1 += P1;
                    FinalOutput2 += P2;
                    FinalOutput3 += P3;
                    FinalOutput4 += P4;
                    FinalOutput5 += P5;
                    FinalOutput6 += P6;
                    FinalOutput7 += P7;
                }
				if (c == 'Q')
				{
                    string Q1 = "######  ";
                    string Q2 = "#     # ";
                    string Q3 = "#     # ";
                    string Q4 = "#     # ";
                    string Q5 = "#   # # ";
                    string Q6 = "#    #  ";
                    string Q7 = "##### # ";

                    FinalOutput1 += Q1;
                    FinalOutput2 += Q2;
                    FinalOutput3 += Q3;
                    FinalOutput4 += Q4;
                    FinalOutput5 += Q5;
                    FinalOutput6 += Q6;
                    FinalOutput7 += Q7;
                }
				if (c == 'R')
				{
                    string R1 = "######  ";
                    string R2 = "#     # ";
                    string R3 = "#     # ";
                    string R4 = "######  ";
                    string R5 = "#   #   ";
                    string R6 = "#    #  ";
                    string R7 = "#     # ";

                    FinalOutput1 += R1;
                    FinalOutput2 += R2;
                    FinalOutput3 += R3;
                    FinalOutput4 += R4;
                    FinalOutput5 += R5;
                    FinalOutput6 += R6;
                    FinalOutput7 += R7;
                }
				if (c == 'S')
				{
                    string S1 = " #####  ";
                    string S2 = "#     # ";
                    string S3 = "#       ";
                    string S4 = "######  ";
                    string S5 = "      # ";
                    string S6 = "#     # ";
                    string S7 = " #####  ";

                    FinalOutput1 += S1;
                    FinalOutput2 += S2;
                    FinalOutput3 += S3;
                    FinalOutput4 += S4;
                    FinalOutput5 += S5;
                    FinalOutput6 += S6;
                    FinalOutput7 += S7;
                }
				if (c == 'T')
				{
                    string T1 = "####### ";
                    string T2 = "   #    ";
                    string T3 = "   #    ";
                    string T4 = "   #    ";
                    string T5 = "   #    ";
                    string T6 = "   #    ";
                    string T7 = "   #    ";

                    FinalOutput1 += T1;
                    FinalOutput2 += T2;
                    FinalOutput3 += T3;
                    FinalOutput4 += T4;
                    FinalOutput5 += T5;
                    FinalOutput6 += T6;
                    FinalOutput7 += T7;
                }
				if (c == 'U')
				{
                    string U1 = "#     # ";
                    string U2 = "#     # ";
                    string U3 = "#     # ";
                    string U4 = "#     # ";
                    string U5 = "#     # ";
                    string U6 = "#     # ";
                    string U7 = " #####  ";

                    FinalOutput1 += U1;
                    FinalOutput2 += U2;
                    FinalOutput3 += U3;
                    FinalOutput4 += U4;
                    FinalOutput5 += U5;
                    FinalOutput6 += U6;
                    FinalOutput7 += U7;
                }
				if (c =='V')
				{
                    string V1 = "#     # ";
                    string V2 = "#     # ";
                    string V3 = "#     # ";
                    string V4 = "#     # ";
                    string V5 = " #   #  ";
                    string V6 = "  # #   ";
                    string V7 = "   #    ";

                    FinalOutput1 += V1;
                    FinalOutput2 += V2;
                    FinalOutput3 += V3;
                    FinalOutput4 += V4;
                    FinalOutput5 += V5;
                    FinalOutput6 += V6;
                    FinalOutput7 += V7;
                }
				if (c =='W')
				{
                    string W1 = "#     # ";
                    string W2 = "#  #  # ";
                    string W3 = "#  #  # ";
                    string W4 = "#  #  # ";
                    string W5 = "#  #  # ";
                    string W6 = "#  #  # ";
                    string W7 = "####### ";

                    FinalOutput1 += W1;
                    FinalOutput2 += W2;
                    FinalOutput3 += W3;
                    FinalOutput4 += W4;
                    FinalOutput5 += W5;
                    FinalOutput6 += W6;
                    FinalOutput7 += W7;
                }
				if (c == 'X')
				{
                    string X1 = "#     # ";
                    string X2 = " #   #  ";
                    string X3 = "  # #   ";
                    string X4 = "   #    ";
                    string X5 = "  # #   ";
                    string X6 = " #   #  ";
                    string X7 = "#     # ";

                    FinalOutput1 += X1;
                    FinalOutput2 += X2;
                    FinalOutput3 += X3;
                    FinalOutput4 += X4;
                    FinalOutput5 += X5;
                    FinalOutput6 += X6;
                    FinalOutput7 += X7;
                }
				if (c == 'Y')
				{
                    string Y1 = "#     # ";
                    string Y2 = " #   #  ";
                    string Y3 = "  # #   ";
                    string Y4 = "   #    ";
                    string Y5 = "   #    ";
                    string Y6 = "   #    ";
                    string Y7 = "   #    ";

                    FinalOutput1 += Y1;
                    FinalOutput2 += Y2;
                    FinalOutput3 += Y3;
                    FinalOutput4 += Y4;
                    FinalOutput5 += Y5;
                    FinalOutput6 += Y6;
                    FinalOutput7 += Y7;
                }
				if (c == 'Z')
				{
                    string Z1 = "####### ";
                    string Z2 = "     #  ";
                    string Z3 = "    #   ";
                    string Z4 = "   #    ";
                    string Z5 = "  #     ";
                    string Z6 = " #      ";
                    string Z7 = "####### ";

                    FinalOutput1 += Z1;
                    FinalOutput2 += Z2;
                    FinalOutput3 += Z3;
                    FinalOutput4 += Z4;
                    FinalOutput5 += Z5;
                    FinalOutput6 += Z6;
                    FinalOutput7 += Z7;
                }
				if (c == '.')
				{
					string Period1 = "        ";
					string Period2 = "        ";
					string Period3 = "        ";
					string Period4 = "        ";
					string Period5 = "        ";
					string Period6 = "####### ";
					string Period7 = "####### ";

					FinalOutput1 += Period1;
					FinalOutput2 += Period2;
					FinalOutput3 += Period3;
					FinalOutput4 += Period4;
					FinalOutput5 += Period5;
					FinalOutput6 += Period6;
					FinalOutput7 += Period7;
				}
                if (c == ' ')
                {
                    string Space1 = " ";
                    string Space2 = " ";
                    string Space3 = " ";
                    string Space4 = " ";
                    string Space5 = " ";
                    string Space6 = " ";
                    string Space7 = " ";

                    FinalOutput1 += Space1;
                    FinalOutput2 += Space2;
                    FinalOutput3 += Space3;
                    FinalOutput4 += Space4;
                    FinalOutput5 += Space5;
                    FinalOutput6 += Space6;
                    FinalOutput7 += Space7;
                }
            }

			//Writes the final output
			Console.WriteLine(FinalOutput1);
			Console.WriteLine(FinalOutput2);
			Console.WriteLine(FinalOutput3);
			Console.WriteLine(FinalOutput4);
			Console.WriteLine(FinalOutput5);
			Console.WriteLine(FinalOutput6);
			Console.WriteLine(FinalOutput7);
			//Reads the Ouptut
			Console.ReadLine();
		}
	}
}
