using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentsApp
{
    internal class Model
    {
        private static int getPriority(double[] ContInputs)
        {
            //"Input Variable" comment is added beside Input(Response) variables.

            int Cont_idx = 0;

            double _Par_Inc1__ = ContInputs[Cont_idx++];
            double _Par_Inc2__ = ContInputs[Cont_idx++];
            double _Par_Inc3__ = ContInputs[Cont_idx++];
            double _Par_Inc4__ = ContInputs[Cont_idx++];
            double _Par_Inc5__ = ContInputs[Cont_idx++];
            double _Par_Inc6__ = ContInputs[Cont_idx++];
            double _Par_Inc7__ = ContInputs[Cont_idx++];
            double _Par_Inc8__ = ContInputs[Cont_idx++];
            double _Par_Inc9__ = ContInputs[Cont_idx++];
            double _Par_Inc10__ = ContInputs[Cont_idx++];
            double _Par_Inc11__ = ContInputs[Cont_idx++];
            double _Par_Inc12__ = ContInputs[Cont_idx++];
            double _Par_Inc13__ = ContInputs[Cont_idx++];
            double _Par_Inc14__ = ContInputs[Cont_idx++];
            double _Par_Inc15__ = ContInputs[Cont_idx++];
            double _Par_Inc16__ = ContInputs[Cont_idx++];
            double _Par_Inc17__ = ContInputs[Cont_idx++];
            double _Par_Inc18__ = ContInputs[Cont_idx++];
            double _Par_Inc19__ = ContInputs[Cont_idx++];
            double _Par_Inc20__ = ContInputs[Cont_idx++];
            double _Par_Inc21__ = ContInputs[Cont_idx++];
            double _Par_Inc22__ = ContInputs[Cont_idx++];
            double _Par_Inc23__ = ContInputs[Cont_idx++];
            double _Par_Inc24__ = ContInputs[Cont_idx++];
            double _Par_Inc25__ = ContInputs[Cont_idx++];
            double _Par_Inc26__ = ContInputs[Cont_idx++];
            double _Par_Inc27__ = ContInputs[Cont_idx++];
            double _Par_Inc28__ = ContInputs[Cont_idx++];
            double _Par_Inc29__ = ContInputs[Cont_idx++];
            double _Par_Inc30__ = ContInputs[Cont_idx++];
            double _Par_Inc31__ = ContInputs[Cont_idx++];
            double _Par_Inc32__ = ContInputs[Cont_idx++];
            double _Par_Inc33__ = ContInputs[Cont_idx++];
            double _Par_Inc34__ = ContInputs[Cont_idx++];
            double _Par_Inc35__ = ContInputs[Cont_idx++];

            double[] __statist_inputs = new double[35];
            double[] __statist_outputs = new double[3];

            for (int __statist_i = 0; __statist_i < 3; __statist_i++)
            {
                __statist_outputs[__statist_i] = -1.0e+307;
            }

            double[] __statist_min_input = new double[35];

            __statist_min_input[0] = 2.00000000000000e+000;
            __statist_min_input[1] = 0.00000000000000e+000;
            __statist_min_input[2] = 0.00000000000000e+000;
            __statist_min_input[3] = 0.00000000000000e+000;
            __statist_min_input[4] = 0.00000000000000e+000;
            __statist_min_input[5] = 0.00000000000000e+000;
            __statist_min_input[6] = 0.00000000000000e+000;
            __statist_min_input[7] = 0.00000000000000e+000;
            __statist_min_input[8] = 0.00000000000000e+000;
            __statist_min_input[9] = 0.00000000000000e+000;
            __statist_min_input[10] = 0.00000000000000e+000;
            __statist_min_input[11] = 0.00000000000000e+000;
            __statist_min_input[12] = 0.00000000000000e+000;
            __statist_min_input[13] = 0.00000000000000e+000;
            __statist_min_input[14] = 0.00000000000000e+000;
            __statist_min_input[15] = 1.90000000000000e+001;
            __statist_min_input[16] = 7.20000000000000e+000;
            __statist_min_input[17] = 4.00000000000000e-001;
            __statist_min_input[18] = 1.00000000000000e+000;
            __statist_min_input[19] = 1.00000000000000e+000;
            __statist_min_input[20] = 0.00000000000000e+000;
            __statist_min_input[21] = 0.00000000000000e+000;
            __statist_min_input[22] = 0.00000000000000e+000;
            __statist_min_input[23] = 0.00000000000000e+000;
            __statist_min_input[24] = 0.00000000000000e+000;
            __statist_min_input[25] = 1.90000000000000e+001;
            __statist_min_input[26] = 7.20000000000000e+000;
            __statist_min_input[27] = 4.00000000000000e-001;
            __statist_min_input[28] = 1.00000000000000e+000;
            __statist_min_input[29] = 1.00000000000000e+000;
            __statist_min_input[30] = 0.00000000000000e+000;
            __statist_min_input[31] = 0.00000000000000e+000;
            __statist_min_input[32] = 0.00000000000000e+000;
            __statist_min_input[33] = 0.00000000000000e+000;
            __statist_min_input[34] = 0.00000000000000e+000;

            double[] __statist_max_input = new double[35];

            __statist_max_input[0] = 1.00000000000000e+002;
            __statist_max_input[1] = 1.00000000000000e+000;
            __statist_max_input[2] = 1.00000000000000e+000;
            __statist_max_input[3] = 1.00000000000000e+000;
            __statist_max_input[4] = 1.00000000000000e+000;
            __statist_max_input[5] = 1.00000000000000e+000;
            __statist_max_input[6] = 1.00000000000000e+000;
            __statist_max_input[7] = 1.00000000000000e+000;
            __statist_max_input[8] = 1.00000000000000e+000;
            __statist_max_input[9] = 1.00000000000000e+000;
            __statist_max_input[10] = 3.00000000000000e+000;
            __statist_max_input[11] = 1.00000000000000e+000;
            __statist_max_input[12] = 1.00000000000000e+000;
            __statist_max_input[13] = 1.00000000000000e+000;
            __statist_max_input[14] = 1.00000000000000e+000;
            __statist_max_input[15] = 7.00000000000000e+001;
            __statist_max_input[16] = 3.63663000000000e+003;
            __statist_max_input[17] = 2.00000000000000e+001;
            __statist_max_input[18] = 3.76000000000000e+002;
            __statist_max_input[19] = 1.59000000000000e+002;
            __statist_max_input[20] = 9.80000000000000e+001;
            __statist_max_input[21] = 7.60000000000000e+001;
            __statist_max_input[22] = 1.10000000000000e+001;
            __statist_max_input[23] = 5.90000000000000e+001;
            __statist_max_input[24] = 1.73000000000000e+002;
            __statist_max_input[25] = 7.00000000000000e+001;
            __statist_max_input[26] = 3.63663000000000e+003;
            __statist_max_input[27] = 2.00000000000000e+001;
            __statist_max_input[28] = 3.76000000000000e+002;
            __statist_max_input[29] = 1.59000000000000e+002;
            __statist_max_input[30] = 9.80000000000000e+001;
            __statist_max_input[31] = 7.60000000000000e+001;
            __statist_max_input[32] = 1.10000000000000e+001;
            __statist_max_input[33] = 5.90000000000000e+001;
            __statist_max_input[34] = 1.73000000000000e+002;

            double[,] __statist_sofmWeights = new double[3, 35];

            __statist_sofmWeights[0, 0] = 0.450900987046565;
            __statist_sofmWeights[0, 1] = 0.570610879503424;
            __statist_sofmWeights[0, 2] = 0.179318490775440;
            __statist_sofmWeights[0, 3] = 0.408858030094718;
            __statist_sofmWeights[0, 4] = 0.725661532251336;
            __statist_sofmWeights[0, 5] = 0.145192462013196;
            __statist_sofmWeights[0, 6] = 0.605388255101552;
            __statist_sofmWeights[0, 7] = 0.762138527835026;
            __statist_sofmWeights[0, 8] = 0.411807683304396;
            __statist_sofmWeights[0, 9] = 0.487123105371980;
            __statist_sofmWeights[0, 10] = 0.317923771082676;
            __statist_sofmWeights[0, 11] = 0.668016238490158;
            __statist_sofmWeights[0, 12] = 0.803394310046609;
            __statist_sofmWeights[0, 13] = 0.139872803568234;
            __statist_sofmWeights[0, 14] = 0.736471581404506;
            __statist_sofmWeights[0, 15] = 0.507837745432595;
            __statist_sofmWeights[0, 16] = 0.104372103221106;
            __statist_sofmWeights[0, 17] = 0.176867279405308;
            __statist_sofmWeights[0, 18] = 0.152637456521289;
            __statist_sofmWeights[0, 19] = 0.354697104943016;
            __statist_sofmWeights[0, 20] = 0.027094685822596;
            __statist_sofmWeights[0, 21] = 0.142866149079891;
            __statist_sofmWeights[0, 22] = 0.034099744342895;
            __statist_sofmWeights[0, 23] = 0.172545242104452;
            __statist_sofmWeights[0, 24] = 0.093375975697990;
            __statist_sofmWeights[0, 25] = 0.507837745432595;
            __statist_sofmWeights[0, 26] = 0.104372103221106;
            __statist_sofmWeights[0, 27] = 0.176867279405308;
            __statist_sofmWeights[0, 28] = 0.152637456521289;
            __statist_sofmWeights[0, 29] = 0.354697104943016;
            __statist_sofmWeights[0, 30] = 0.027094685822596;
            __statist_sofmWeights[0, 31] = 0.142866149079891;
            __statist_sofmWeights[0, 32] = 0.034099744342895;
            __statist_sofmWeights[0, 33] = 0.172545242104452;
            __statist_sofmWeights[0, 34] = 0.093375975697990;

            __statist_sofmWeights[1, 0] = 0.543140547712194;
            __statist_sofmWeights[1, 1] = 0.588951567708367;
            __statist_sofmWeights[1, 2] = 0.850040968057353;
            __statist_sofmWeights[1, 3] = 0.293996574392762;
            __statist_sofmWeights[1, 4] = 0.612537383202192;
            __statist_sofmWeights[1, 5] = 0.485650752946792;
            __statist_sofmWeights[1, 6] = 0.760538316755040;
            __statist_sofmWeights[1, 7] = 0.482316246807399;
            __statist_sofmWeights[1, 8] = 0.424837339548298;
            __statist_sofmWeights[1, 9] = 0.286947786332212;
            __statist_sofmWeights[1, 10] = 0.266487406287074;
            __statist_sofmWeights[1, 11] = 0.354310616260713;
            __statist_sofmWeights[1, 12] = 0.407055537656294;
            __statist_sofmWeights[1, 13] = 0.166525432124553;
            __statist_sofmWeights[1, 14] = 0.422642688897777;
            __statist_sofmWeights[1, 15] = 0.390392563043080;
            __statist_sofmWeights[1, 16] = 0.158937344024524;
            __statist_sofmWeights[1, 17] = 0.209211873950492;
            __statist_sofmWeights[1, 18] = 0.171748551621515;
            __statist_sofmWeights[1, 19] = 0.505811175147024;
            __statist_sofmWeights[1, 20] = 0.077348280577748;
            __statist_sofmWeights[1, 21] = 0.095337150806468;
            __statist_sofmWeights[1, 22] = 0.038364761274256;
            __statist_sofmWeights[1, 23] = 0.174901976002813;
            __statist_sofmWeights[1, 24] = 0.123523127631550;
            __statist_sofmWeights[1, 25] = 0.390392563043080;
            __statist_sofmWeights[1, 26] = 0.158937344024524;
            __statist_sofmWeights[1, 27] = 0.209211873950492;
            __statist_sofmWeights[1, 28] = 0.171748551621515;
            __statist_sofmWeights[1, 29] = 0.505811175147024;
            __statist_sofmWeights[1, 30] = 0.077348280577748;
            __statist_sofmWeights[1, 31] = 0.095337150806468;
            __statist_sofmWeights[1, 32] = 0.038364761274256;
            __statist_sofmWeights[1, 33] = 0.174901976002813;
            __statist_sofmWeights[1, 34] = 0.123523127631550;

            __statist_sofmWeights[2, 0] = 0.451467726747102;
            __statist_sofmWeights[2, 1] = 0.344623118876891;
            __statist_sofmWeights[2, 2] = 0.286958701923110;
            __statist_sofmWeights[2, 3] = 0.659940971004966;
            __statist_sofmWeights[2, 4] = 0.195107829768348;
            __statist_sofmWeights[2, 5] = 0.749374852378988;
            __statist_sofmWeights[2, 6] = 0.284944749407378;
            __statist_sofmWeights[2, 7] = 0.267819576486951;
            __statist_sofmWeights[2, 8] = 0.607466525915384;
            __statist_sofmWeights[2, 9] = 0.613182843339444;
            __statist_sofmWeights[2, 10] = 0.204455517434373;
            __statist_sofmWeights[2, 11] = 0.518347653652718;
            __statist_sofmWeights[2, 12] = 0.353015545219917;
            __statist_sofmWeights[2, 13] = 0.256556662823904;
            __statist_sofmWeights[2, 14] = 0.658736254571116;
            __statist_sofmWeights[2, 15] = 0.434825909380872;
            __statist_sofmWeights[2, 16] = 0.165413342532237;
            __statist_sofmWeights[2, 17] = 0.219467859325688;
            __statist_sofmWeights[2, 18] = 0.187939092025526;
            __statist_sofmWeights[2, 19] = 0.451950040675829;
            __statist_sofmWeights[2, 20] = 0.092246419413488;
            __statist_sofmWeights[2, 21] = 0.094314390390066;
            __statist_sofmWeights[2, 22] = 0.019846432495247;
            __statist_sofmWeights[2, 23] = 0.184405501814948;
            __statist_sofmWeights[2, 24] = 0.170577524240051;
            __statist_sofmWeights[2, 25] = 0.434825909380872;
            __statist_sofmWeights[2, 26] = 0.165413342532237;
            __statist_sofmWeights[2, 27] = 0.219467859325688;
            __statist_sofmWeights[2, 28] = 0.187939092025526;
            __statist_sofmWeights[2, 29] = 0.451950040675829;
            __statist_sofmWeights[2, 30] = 0.092246419413488;
            __statist_sofmWeights[2, 31] = 0.094314390390066;
            __statist_sofmWeights[2, 32] = 0.019846432495247;
            __statist_sofmWeights[2, 33] = 0.184405501814948;
            __statist_sofmWeights[2, 34] = 0.170577524240051;

            __statist_inputs[0] = _Par_Inc1__;
            __statist_inputs[1] = _Par_Inc2__;
            __statist_inputs[2] = _Par_Inc3__;
            __statist_inputs[3] = _Par_Inc4__;
            __statist_inputs[4] = _Par_Inc5__;
            __statist_inputs[5] = _Par_Inc6__;
            __statist_inputs[6] = _Par_Inc7__;
            __statist_inputs[7] = _Par_Inc8__;
            __statist_inputs[8] = _Par_Inc9__;
            __statist_inputs[9] = _Par_Inc10__;
            __statist_inputs[10] = _Par_Inc11__;
            __statist_inputs[11] = _Par_Inc12__;
            __statist_inputs[12] = _Par_Inc13__;
            __statist_inputs[13] = _Par_Inc14__;
            __statist_inputs[14] = _Par_Inc15__;
            __statist_inputs[15] = _Par_Inc16__;
            __statist_inputs[16] = _Par_Inc17__;
            __statist_inputs[17] = _Par_Inc18__;
            __statist_inputs[18] = _Par_Inc19__;
            __statist_inputs[19] = _Par_Inc20__;
            __statist_inputs[20] = _Par_Inc21__;
            __statist_inputs[21] = _Par_Inc22__;
            __statist_inputs[22] = _Par_Inc23__;
            __statist_inputs[23] = _Par_Inc24__;
            __statist_inputs[24] = _Par_Inc25__;
            __statist_inputs[25] = _Par_Inc26__;
            __statist_inputs[26] = _Par_Inc27__;
            __statist_inputs[27] = _Par_Inc28__;
            __statist_inputs[28] = _Par_Inc29__;
            __statist_inputs[29] = _Par_Inc30__;
            __statist_inputs[30] = _Par_Inc31__;
            __statist_inputs[31] = _Par_Inc32__;
            __statist_inputs[32] = _Par_Inc33__;
            __statist_inputs[33] = _Par_Inc34__;
            __statist_inputs[34] = _Par_Inc35__;

            double __statist_delta = 0;
            double __statist_maximum = 1;
            double __statist_minimum = 0;
            int __statist_nDummyInputs = 35;
            int __statist_ncont_inputs = 35;

            /*scale continuous inputs*/
            for (int __statist_i = 0; __statist_i < __statist_ncont_inputs; __statist_i++)
            {
                __statist_delta = (__statist_maximum - __statist_minimum) / (__statist_max_input[__statist_i] - __statist_min_input[__statist_i]);
                __statist_inputs[__statist_i] = __statist_minimum - __statist_delta * __statist_min_input[__statist_i] + __statist_delta * __statist_inputs[__statist_i];
            }

            /*Forward propagate*/
            int[] __statist_position = new int[2];
            __statist_position[0] = 0;
            __statist_position[1] = 0;
            int __statist_winner = 0;
            double __statist_dmin = 0.0;
            int __statist_nclusters = 3;
            int __statist_Height = 1;
            int __statist_Width = 3;

            for (int __statist_ii = 0; __statist_ii < __statist_nclusters; __statist_ii++)
            {
                __statist_outputs[__statist_ii] = 0.0;

                for (int __statist_jj = 0; __statist_jj < __statist_nDummyInputs; __statist_jj++)
                {
                    __statist_outputs[__statist_ii] = __statist_outputs[__statist_ii] + ((__statist_sofmWeights[__statist_ii, __statist_jj] - __statist_inputs[__statist_jj]) * (__statist_sofmWeights[__statist_ii, __statist_jj] - __statist_inputs[__statist_jj]));
                }

                __statist_outputs[__statist_ii] = Math.Pow(__statist_outputs[__statist_ii], 0.5);

                if (__statist_outputs[__statist_ii] < __statist_dmin || __statist_ii == 0)
                {
                    __statist_dmin = __statist_outputs[__statist_ii];
                    __statist_winner = __statist_ii;
                }
            }

            int __statist_kk = 0;
            for (int __statist_ii = 0; __statist_ii < __statist_Height; __statist_ii++)
            {
                __statist_position[0] = __statist_ii;

                for (int __statist_jj = 0; __statist_jj < __statist_Width; __statist_jj++)
                {
                    __statist_position[1] = __statist_jj;
                    if (__statist_kk < __statist_winner)
                    {
                        __statist_kk = __statist_kk + 1;
                    }
                    else
                    {
                        goto EXIT;
                    }
                }
            }
        EXIT:;

            double __statist_Activation = __statist_outputs[__statist_winner];
            string __statist_Winning_Position = "";
            __statist_Winning_Position = __statist_Winning_Position + "(" + (__statist_position[0] + 1).ToString() + "," + (__statist_position[1] + 1).ToString() + ")";
            //Console.WriteLine(" Activation = {0}", __statist_Activation);
            //Console.WriteLine(" Winning Position = {0}", __statist_Winning_Position);

            return __statist_position[1] + 1;
        }

        public static (List<Incident>, int[]) calculatePriorityForList(List<Incident> incidents)
        {
            int[] p_array = new int[] { 0, 0, 0 };

            foreach (Incident inc in incidents)
            {
                inc.priority = getPriority(inc.parameters.ToArray());
                p_array[inc.priority - 1]++;
            }

            return (incidents, p_array);
        }
    }
}
