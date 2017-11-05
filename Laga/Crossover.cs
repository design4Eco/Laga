﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Laga.GeneticAlgorithm
{
    /// <summary>
    /// Crossover class
    /// </summary>
    public class Crossover
    {
        Random rnd;

        private int[] arrIndex;

        /// <summary>
        /// get and set indexes for parents in crossover.
        /// </summary>
        public int[] IndexParent
        {
            get => arrIndex;
            set
            {
                value = arrIndex;
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        public Crossover()
        {
            rnd = new Random();
        }

        /// <summary>
        /// A crossover algorithm performed in a single point of the chromosome.
        /// </summary>
        /// <param name="population">The population to perform the crossover</param>
        /// <param name="percent">Which percent of chromosomes will be croosver</param>
        /// <param name="pointCutter">Where the crossover will be executed</param>
        /// <returns>object[][]</returns>
        public object[][] SinglePointCrossover(object[][] population, float percent, int pointCutter)
        {
            int popLength = population.Length;
            arrIndex = LagaTools.Mom_Dad(popLength, percent);
            int iLength = arrIndex.Length; 
            object[] dad;
            object[] mom;
            object[] son1;
            object[] son2;

            object[][] inherencePop = new object[iLength][];

            object[][] crossPop = population.Select(a => a.ToArray()).ToArray();

            for (int i = 0; i < iLength - 1; i += 2)
            {
                dad = crossPop[arrIndex[i]];
                mom = crossPop[arrIndex[i + 1]];
                son1 = new object[dad.Length];
                son2 = new object[mom.Length];

                int t = pointCutter;
                int t2 = pointCutter;

                for (int j = 0; j < pointCutter; ++j)
                {
                    son1[j] = dad[j];
                    son2[j] = mom[j];
                }

                for (int j = 0; j < mom.Length; ++j)
                {
                    for (int k = pointCutter; k < dad.Length; ++k)
                    {
                        if (mom[j].Equals(dad[k]))
                        {
                            son1[t] = mom[j];
                            t++;
                        }
                    }
                }

                for (int j = 0; j < dad.Length; ++j)
                {
                    for (int k = pointCutter; k < mom.Length; ++k)
                    {
                        if (dad[j].Equals(mom[k]))
                        {
                            son2[t2] = dad[j];
                            t2++;
                        }
                    }
                }
                inherencePop[i] = son1;
                inherencePop[i + 1] = son2;
            }
            return inherencePop;
        }

        /// <summary>
        /// A crossover algorithm performed in a single point of the chromosome.
        /// </summary>
        /// <param name="population">The population to perform the crossover</param>
        /// <param name="percent">Which percent of chromosomes will be croosver</param>
        /// <param name="pointCutter">Where the crossover will be executed</param>
        /// <returns>double[][]</returns>
        public double[][] SinglePointCrossover(double[][] population, float percent, int pointCutter)
        {
            int popLength = population.Length;
            arrIndex = LagaTools.Mom_Dad(popLength, percent);
            int iLength = arrIndex.Length;

            double[] dad;
            double[] mom;
            double[] son1;
            double[] son2;

            double[][] inherencePop = new double[iLength][];

            //clone the array.
            double[][] crossPop = population.Select(a => a.ToArray()).ToArray();

            for (int i = 0; i < iLength - 1; i += 2)
            {
                dad = crossPop[arrIndex[i]];
                mom = crossPop[arrIndex[i + 1]];
                son1 = new double[dad.Length];
                son2 = new double[mom.Length];

                for (int j = 0; j < pointCutter; ++j)
                {
                    son1[j] = dad[j];
                    son2[j] = mom[j];
                }

                for (int k = pointCutter; k < dad.Length; ++k)
                {
                    son1[k] = mom[k];
                    son2[k] = dad[k];
                }

                inherencePop[i] = son1;
                inherencePop[i + 1] = son2;
            }
            return inherencePop;
        }

        /// <summary>
        /// A crossover algorithm performed in a single point of the chromosome.
        /// </summary>
        /// <param name="population">The population to perform the crossover</param>
        /// <param name="percent">Which percent of chromosomes will be croosver</param>
        /// <param name="pointCutter">Where the crossover will be executed</param>
        /// <returns>float[][]</returns>
        public float[][] SinglePointCrossover(float[][] population, float percent, int pointCutter)
        {
            int popLength = population.Length;
            arrIndex = LagaTools.Mom_Dad(popLength, percent);
            int iLength = arrIndex.Length;
            float[] dad;
            float[] mom;
            float[] son1;
            float[] son2;

            float[][] inherencePop = new float[iLength][];

            //clone the array.
            float[][] crossPop = population.Select(a => a.ToArray()).ToArray();

            for (int i = 0; i < iLength - 1; i += 2)
            {
                dad = crossPop[arrIndex[i]];
                mom = crossPop[arrIndex[i + 1]];
                son1 = new float[dad.Length];
                son2 = new float[mom.Length];

                for (int j = 0; j < pointCutter; ++j)
                {
                    son1[j] = dad[j];
                    son2[j] = mom[j];
                }

                for (int k = pointCutter; k < dad.Length; ++k)
                {
                    son1[k] = mom[k];
                    son2[k] = dad[k];
                }

                inherencePop[i] = son1;
                inherencePop[i + 1] = son2;
            }
            return inherencePop;
        }

        /// <summary>
        /// A crossover algorithm performed in a single point of the chromosome.
        /// </summary>
        /// <param name="population">The population to perform the crossover</param>
        /// <param name="percent">Which percent of chromosomes will be croosver</param>
        /// <param name="pointCutter">Where the crossover will be executed</param>
        /// <returns>int[][]</returns>
        public int[][] SinglePointCrossover(int[][] population, float percent, int pointCutter)
        {
            int popLength = population.Length;
            arrIndex = LagaTools.Mom_Dad(popLength, percent);
            int iLength = arrIndex.Length;

            int[] dad;
            int[] mom;
            int[] son1;
            int[] son2;

            int[][] inherencePop = new int[iLength][];

            //clone the array.
            int[][] crossPop = population.Select(a => a.ToArray()).ToArray();

            for (int i = 0; i < iLength - 1; i += 2)
            {
                dad = crossPop[arrIndex[i]];
                mom = crossPop[arrIndex[i + 1]];
                son1 = new int[dad.Length];
                son2 = new int[mom.Length];

                for (int j = 0; j < pointCutter; ++j)
                {
                    son1[j] = dad[j];
                    son2[j] = mom[j];
                }

                for (int k = pointCutter; k < dad.Length; ++k)
                {
                    son1[k] = mom[k];
                    son2[k] = dad[k];
                }

                inherencePop[i] = son1;
                inherencePop[i + 1] = son2;
            }
            return inherencePop;
        }

        /// <summary>
        /// A crossover algorithm performed in a single point of the chromosome.
        /// </summary>
        /// <param name="population">The population to perform the crossover</param>
        /// <param name="percent">Which percent of chromosomes will be croosver</param>
        /// <param name="pointCutter">Where the crossover will be executed</param>
        /// <returns>Char[][]</returns>
        public char[][] SinglePointCrossover(char[][] population, float percent, int pointCutter)
        {
            int popLength = population.Length;
            arrIndex = LagaTools.Mom_Dad(popLength, percent);
            int iLength = arrIndex.Length;

            char[][] inherencePop = new char[iLength][];
            int count = 0;

            //deep copy the array.
            char[][] crossPop = population.Select(a => a.ToArray()).ToArray();

            for (int i = 0; i < iLength - 1; i += 2)
            {

                char[] dad = crossPop[arrIndex[i]];
                char[] mom = crossPop[arrIndex[i + 1]];

                char[] son1 = new char[dad.Length];
                char[] son2 = new char[mom.Length];

                for (int j = 0; j < pointCutter; ++j)
                {
                    son1[j] = dad[j];
                    son2[j] = mom[j];
                }

                for (int k = pointCutter; k < dad.Length; ++k)
                {
                    son1[k] = mom[k];
                    son2[k] = dad[k];
                }

                inherencePop[count] = son1;
                inherencePop[count + 1] = son2;

                count += 2;
            }
            return inherencePop;
        }

    }

}
