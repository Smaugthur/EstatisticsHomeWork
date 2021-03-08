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

        public Statistics(float[] inputData)
        {
            this.inputData = inputData;
            frecuencyValues = GetFrecuencyValues(this.inputData);
            absoluteFrecuency = GetAbsoluteFrecuency(this.inputData, frecuencyValues);
            cumulativeFrecuency = GetCumulativeFrecuency(absoluteFrecuency);
        }
        public static float[] GetFrecuencyValues(float[] inputData)
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
        public static float[] GetAbsoluteFrecuency(float[] inputData, float[] frecuencyValues)
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
        public static float[] GetCumulativeFrecuency(float[] absoluteFrecuency)
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
    }
}