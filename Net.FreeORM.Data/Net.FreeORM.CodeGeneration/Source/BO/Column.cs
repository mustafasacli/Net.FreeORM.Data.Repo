using System.Text;

namespace Net.FreeORM.CodeGeneration.Source.BO
{
    internal struct Column
    {

        private string _propName;

        internal string PropertyChangeMethodName
        {
            get { return "OnPropertyChanged"; }
        }

        public Column(string sColumnName, string sColumnType)
        {
            _ColumnName = sColumnName;
            _ColumnTypeName = sColumnType;
            _propName = string.Empty;
            _propName = PropName();
        }

        private string _ColumnName;
        public string ColumnName
        {
            get { return _ColumnName; }
            set
            {
                _ColumnName = value;
                _propName = PropName();
            }
        }

        public string PropertyName
        {
            get
            {
                return _propName;
            }
        }

        private string PropName()
        {
            string strResult = string.Empty;

            strResult = string.Format("{0}", _ColumnName);

            strResult = strResult.Replace(" ", "");
            strResult = strResult.Replace("ğ", "g");
            strResult = strResult.Replace("ı", "i");
            strResult = strResult.Replace("ç", "c");
            strResult = strResult.Replace("ö", "o");
            strResult = strResult.Replace("ü", "u");
            strResult = strResult.Replace("Ğ", "G");
            strResult = strResult.Replace("Ç", "C");
            strResult = strResult.Replace("Ö", "O");
            strResult = strResult.Replace("Ü", "U");
            strResult = strResult.Replace("İ", "I");

            return strResult;
        }

        private string _ColumnTypeName;
        public string ColumnTypeName
        {
            get { return this.ConvertFromDbDataType(_ColumnTypeName); }
            set { _ColumnTypeName = value; }
        }

        public override string ToString()
        {
            string colName = this.PropertyName;
            string colType = this.ColumnTypeName;

            StringBuilder colBuilder = new StringBuilder();
            colBuilder.AppendFormat("\t\tprivate {0} _{1};\n", colType, colName);
            colBuilder.AppendFormat("\t\tpublic {0} {1}\n", colType, colName);
            colBuilder.Append("\t\t{\n\t\t\tset {");
            colBuilder.AppendFormat(" _{0} = value; {1}(\"{2}\");", colName, PropertyChangeMethodName, colName);
            colBuilder.AppendLine(" }");
            colBuilder.Append("\t\t\tget {");
            colBuilder.AppendFormat(" return _{0}; ", colName);
            colBuilder.AppendLine("}");
            colBuilder.AppendLine("\t\t}");
            colBuilder.AppendLine();
            return colBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj.GetType(), typeof(Column)))
            {
                Column cl = (Column)obj;
                return cl.ColumnName.Equals(_ColumnName) && cl.ColumnTypeName.Equals(_ColumnTypeName);
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private string ConvertFromDbDataType(string columnDataType)
        {
            string col = string.Format("{0}", columnDataType).ToLower().Replace('ı', 'i');

            switch (col)
            {
                case "number":
                case "int":
                case "integer":
                case "int4":
                    return "int";

                case "tinyint":
                    return "byte";

                case "smallint":
                    return "Int16";

                case "datetimeoffset":
                case "date":
                case "datetime":
                case "time":
                case "timestamp":
                case "timezone":
                    return "DateTime";

                case "bigint":
                    return "long";

                case "decimal":
                case "smallmoney":
                case "money":
                    return "decimal";

                case "real":
                    return "float";

                case "float":
                    return "double";

                case "bit":
                    return "bool";

                case "nvarchar":
                case "nvarchar2":
                case "varchar":
                case "varchar2":
                case "text":
                case "ntext":
                    return "string";

                case "char":
                case "nchar":
                    return "char";

                case "blob":
                case "binary":
                case "varbinary":
                case "image":
                    return "byte[]";

                default:
                    return "string";
            }
        }
    }
}