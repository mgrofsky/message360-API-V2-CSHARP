/*
 * Message360.PCL
 *
 * This file was automatically generated for message360 by APIMATIC v2.0 ( https://apimatic.io ) on 10/18/2016
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using message360;

namespace message360.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum DirectionEnum
    {
        IN, //in direction
        OUT, //out direction
        BOTH, //both
    }

    /// <summary>
    /// Helper for the enum type DirectionEnum
    /// </summary>
    public static class DirectionEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "in", "out", "both" };

        /// <summary>
        /// Converts a DirectionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The DirectionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(DirectionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case DirectionEnum.IN:
                case DirectionEnum.OUT:
                case DirectionEnum.BOTH:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of DirectionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of DirectionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<DirectionEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into DirectionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed DirectionEnum value</returns>
        public static DirectionEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type DirectionEnum", value));

            return (DirectionEnum) index;
        }
    }
} 