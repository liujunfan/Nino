/* this is generated by nino */
namespace Nino.Test
{
    public partial class Data
    {
        #region NINO_CODEGEN
        public void NinoWriteMembers(Nino.Serialization.Writer writer)
        {
            writer.CompressAndWrite(this.x);
            writer.Write(this.y);
            writer.CompressAndWrite(this.z);
            writer.Write(this.f);
            writer.Write(this.d);
            writer.Write(this.db);
            writer.Write(this.bo);
            writer.CompressAndWriteEnum(typeof(System.Byte), (ulong) this.en);
            writer.Write(this.name);
        }

        public void NinoSetMembers(object[] data)
        {
            this.x = System.Convert.ToInt32(data[0]);
            this.y = (System.Int16)data[1];
            this.z = System.Convert.ToInt64(data[2]);
            this.f = (System.Single)data[3];
            this.d = (System.Decimal)data[4];
            this.db = (System.Double)data[5];
            this.bo = (System.Boolean)data[6];
            this.en = (Nino.Test.TestEnum)data[7];
            this.name = (System.String)data[8];
        }
        #endregion
    }
}