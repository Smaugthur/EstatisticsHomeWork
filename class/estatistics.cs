using System;
using System.Collections.Generic;

namespace STATISTICS
{
    class Statistics
    {
        public float[] inputData;
        public float[] frecuencyValues;
        public float[] absoluteFrecuency;
        public float[] cumulativeFrecuency;
        public float[] relativeFrecuency;

        public Statistics(float[] inputData)
        {
            this.inputData = inputData;
            frecuencyValues = GetFrecuencyValues(this.inputData);
            absoluteFrecuency = GetAbsoluteFrecuency(this.inputData, frecuencyValues);
            cumulativeFrecuency = GetCumulativeFrecuency(absoluteFrecuency);
            relativeFrecuency = GetRelativeFrecuency(absoluteFrecuency);
        }
        public float[] GetFrecuencyValues(float[] inputData)
        {
            List<float> frecuencyValues = new List<float>{inputData[0]};
            bool isNotOnTheList;
            foreach(float i in inputData)
            {
                isNotOnTheList = true;
                foreach(float e in frecuencyValues)
                {
                    if(i==e)
                    {
                        isNotOnTheList=false;
                        break;
                    }
                }
                if(isNotOnTheList) frecuencyValues.Add(i);
            }
            return frecuencyValues.ToArray();
        }
        public float[] GetAbsoluteFrecuency(float[] inputData, float[] frecuencyValues)
        {
            float[] absoluteFrecuency= new float[frecuencyValues.Length];
            for(int i=0; i<frecuencyValues.Length;i++)
            {
                foreach(float e in inputData)
                {
                    if(frecuencyValues[i]==e)
                    {
                        absoluteFrecuency[i]++;
                    }
                }
            }
            return absoluteFrecuency;
        }
        public float[] GetCumulativeFrecuency(float[] absoluteFrecuency)
        {
            float[] cumulativeFrecuencies = new float[absoluteFrecuency.Length];
            for(int i=0;i<absoluteFrecuency.Length;i++)
            {
                for(int e=0;e<=i;e++)
                {
                    cumulativeFrecuencies[i]+=absoluteFrecuency[e];
                }
            }
            return cumulativeFrecuencies;
        }
        public float[] GetRelativeFrecuency(float[] absoluteFrecuency)
        {
            float[] relativeFrecuency = new float[absoluteFrecuency.Length];
            for(int i = 0; i < relativeFrecuency.Length; i++)
            {
                relativeFrecuency[i] = absoluteFrecuency[i] / inputData.Length;
            }
            return relativeFrecuency;
        }
    }
    class StatisticsWithIntervals
    {
        public float[,] GetFrecuencyValues(float[] inputData, int intervalsLength)
        {
            int noIntervals = (int)(inputData[inputData.Length-1] - inputData[0]) / intervalsLength + 1;
            float initValue = inputData[0];
            float[,] intervals = new float[noIntervals,2];
            for(int i = 0; i < intervals.GetLength(0); i++)
            {
                intervals[i,0] = initValue + (intervalsLength * i);
                intervals[i,1] = intervals[i,0] + intervalsLength;
            }
            return intervals;
        }
        public float[] GetAbsoluteFrecuency (float[] inputData, float[,] intervals)
        {
            int noIntervals = intervals.GetLength(0);
            float[] absoluteFrecuency= new float[noIntervals];
            for(int i = 0; i < absoluteFrecuency.Length; i++)
            {
                for(int e = 0; e < inputData.Length; e++)
                {
                    if(inputData[e] > intervals[i,0] || inputData[e] < intervals[i,1])
                    {
                        absoluteFrecuency[e]++;
                    }
                }
            }
            return absoluteFrecuency;
        }
    }
}