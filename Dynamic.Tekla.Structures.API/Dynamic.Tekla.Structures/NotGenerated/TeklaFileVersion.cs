/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{
    public struct TeklaFileVersion
    {
        public int Major;
        public int Minor;
        public int Build;
        public int Build2;

        public override bool Equals(object obj)
        {
            if (!(obj is TeklaFileVersion))
            {
                return false;
            }

            var version = (TeklaFileVersion)obj;
            return Major == version.Major &&
                   Minor == version.Minor &&
                   Build == version.Build &&
                   Build2 == version.Build2;
        }

        public override int GetHashCode()
        {
            var hashCode = -1197760834;
            hashCode = hashCode * -1521134295 + Major.GetHashCode();
            hashCode = hashCode * -1521134295 + Minor.GetHashCode();
            hashCode = hashCode * -1521134295 + Build.GetHashCode();
            hashCode = hashCode * -1521134295 + Build2.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder(100);
            sb.Append(Major);
            sb.Append(".");
            sb.Append(Minor);
            sb.Append(".");
            sb.Append(Build);
            sb.Append(".");
            sb.Append(Build2);

            return sb.ToString();
        }

        public static bool operator ==(TeklaFileVersion version1, TeklaFileVersion version2)
        {
            return version1.Equals(version2);
        }

        public static bool operator !=(TeklaFileVersion version1, TeklaFileVersion version2)
        {
            return !(version1 == version2);
        }
    }
}
