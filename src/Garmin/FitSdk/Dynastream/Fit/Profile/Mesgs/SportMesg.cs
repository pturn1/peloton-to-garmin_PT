#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2023 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.105Release
// Tag = production/release/21.105.00-0-gdc65d24
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using System.Linq;

namespace Dynastream.Fit
{
    /// <summary>
    /// Implements the Sport profile message.
    /// </summary>
    public class SportMesg : Mesg
    {
        #region Fields
        #endregion

        /// <summary>
        /// Field Numbers for <see cref="SportMesg"/>
        /// </summary>
        public sealed class FieldDefNum
        {
            public const byte Sport = 0;
            public const byte SubSport = 1;
            public const byte Name = 3;
            public const byte Invalid = Fit.FieldNumInvalid;
        }

        #region Constructors
        public SportMesg() : base(Profile.GetMesg(MesgNum.Sport))
        {
        }

        public SportMesg(Mesg mesg) : base(mesg)
        {
        }
        #endregion // Constructors

        #region Methods
        ///<summary>
        /// Retrieves the Sport field</summary>
        /// <returns>Returns nullable Sport enum representing the Sport field</returns>
        public Sport? GetSport()
        {
            object obj = GetFieldValue(0, 0, Fit.SubfieldIndexMainField);
            Sport? value = obj == null ? (Sport?)null : (Sport)obj;
            return value;
        }

        /// <summary>
        /// Set Sport field</summary>
        /// <param name="sport_">Nullable field value to be set</param>
        public void SetSport(Sport? sport_)
        {
            SetFieldValue(0, 0, sport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the SubSport field</summary>
        /// <returns>Returns nullable SubSport enum representing the SubSport field</returns>
        public SubSport? GetSubSport()
        {
            object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
            SubSport? value = obj == null ? (SubSport?)null : (SubSport)obj;
            return value;
        }

        /// <summary>
        /// Set SubSport field</summary>
        /// <param name="subSport_">Nullable field value to be set</param>
        public void SetSubSport(SubSport? subSport_)
        {
            SetFieldValue(1, 0, subSport_, Fit.SubfieldIndexMainField);
        }
        
        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns byte[] representing the Name field</returns>
        public byte[] GetName()
        {
            byte[] data = (byte[])GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            return data.Take(data.Length - 1).ToArray();
        }

        ///<summary>
        /// Retrieves the Name field</summary>
        /// <returns>Returns String representing the Name field</returns>
        public String GetNameAsString()
        {
            byte[] data = (byte[])GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
            return data != null ? Encoding.UTF8.GetString(data, 0, data.Length - 1) : null;
        }

        ///<summary>
        /// Set Name field</summary>
        /// <param name="name_"> field value to be set</param>
        public void SetName(String name_)
        {
            byte[] data = Encoding.UTF8.GetBytes(name_);
            byte[] zdata = new byte[data.Length + 1];
            data.CopyTo(zdata, 0);
            SetFieldValue(3, 0, zdata, Fit.SubfieldIndexMainField);
        }

        
        /// <summary>
        /// Set Name field</summary>
        /// <param name="name_">field value to be set</param>
        public void SetName(byte[] name_)
        {
            SetFieldValue(3, 0, name_, Fit.SubfieldIndexMainField);
        }
        
        #endregion // Methods
    } // Class
} // namespace
