/* this is generated by nino */
namespace Nino.Test
{
    public partial class BuildTestDataCodeGen
    {
        public static BuildTestDataCodeGen.SerializationHelper NinoSerializationHelper = new BuildTestDataCodeGen.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<BuildTestDataCodeGen>
        {
            #region NINO_CODEGEN
            public override void Serialize(BuildTestDataCodeGen value, Nino.Serialization.Writer writer)
            {
                writer.Write(value.a);
                writer.Write(value.b);
                writer.Write(value.c);
                writer.Write(value.d);
                writer.CompressAndWrite(ref value.e);
                writer.CompressAndWrite(ref value.f);
                writer.CompressAndWrite(ref value.g);
                writer.CompressAndWrite(ref value.h);
                writer.Write(value.i);
                writer.Write(value.j);
                writer.Write(value.k);
                writer.Write(value.l);
                writer.Write(value.m);
                writer.Write(value.n);
                if(value.o != null)
                {
                    writer.CompressAndWrite(value.o.Count);
                    foreach (var entry in value.o)
                    {
                        writer.CompressAndWrite(entry);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.p != null)
                {
                    writer.CompressAndWrite(value.p.Count);
                    foreach (var entry in value.p)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Serialize(entry, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.q != null)
                {
                    writer.CompressAndWrite(value.q.Length);
                    foreach (var entry in value.q)
                    {
                        writer.Write(entry);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.r != null)
                {
                    writer.CompressAndWrite(value.r.Length);
                    foreach (var entry in value.r)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Serialize(entry, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.s != null)
                {
                    writer.CompressAndWrite(value.s.Count);
                    foreach (var entry in value.s)
                    {
                        writer.Write(entry.Key);
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Serialize(entry.Value, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.t != null)
                {
                    writer.CompressAndWrite(value.t.Count);
                    foreach (var entry in value.t)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Serialize(entry.Key, writer);
                        writer.CompressAndWrite(entry.Value);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.u != null)
                {
                    writer.CompressAndWrite(value.u.Count);
                    foreach (var entry in value.u)
                    {
                        writer.Write(entry.Key);
                        writer.CompressAndWrite(entry.Value);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
                if(value.v != null)
                {
                    writer.CompressAndWrite(value.v.Count);
                    foreach (var entry in value.v)
                    {
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Serialize(entry.Key, writer);
                        Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Serialize(entry.Value, writer);
                    }
                }
                else
                {
                    writer.CompressAndWrite(0);
                }
            }

            public override BuildTestDataCodeGen Deserialize(Nino.Serialization.Reader reader)
            {
                BuildTestDataCodeGen value = new BuildTestDataCodeGen();
                reader.Read<System.Byte>(ref value.a, 1);
                reader.Read<System.SByte>(ref value.b, 1);
                reader.Read<System.Int16>(ref value.c, Nino.Shared.Mgr.ConstMgr.SizeOfShort);
                reader.Read<System.UInt16>(ref value.d, Nino.Shared.Mgr.ConstMgr.SizeOfUShort);
                reader.DecompressAndReadNumber<System.Int32>(ref value.e);
                reader.DecompressAndReadNumber<System.UInt32>(ref value.f);
                reader.DecompressAndReadNumber<System.Int64>(ref value.g);
                reader.DecompressAndReadNumber<System.UInt64>(ref value.h);
                reader.Read<System.Single>(ref value.i, Nino.Shared.Mgr.ConstMgr.SizeOfUInt);
                reader.Read<System.Double>(ref value.j, Nino.Shared.Mgr.ConstMgr.SizeOfULong);
                reader.Read<System.Decimal>(ref value.k, Nino.Shared.Mgr.ConstMgr.SizeOfDecimal);
                reader.Read<System.Boolean>(ref value.l, 1);
                reader.Read<System.Char>(ref value.m, Nino.Shared.Mgr.ConstMgr.SizeOfUShort);
                value.n = reader.ReadString();
                value.o = new System.Collections.Generic.List<System.Int32>(reader.ReadLength());
                for(int i = 0, cnt = value.o.Capacity; i < cnt; i++)
                {
                    var value_o_i = reader.DecompressAndReadNumber<System.Int32>();
                    value.o.Add(value_o_i);
                }
                value.p = new System.Collections.Generic.List<Nino.Test.NotIncludeAllClass>(reader.ReadLength());
                for(int i = 0, cnt = value.p.Capacity; i < cnt; i++)
                {
                    var value_p_i = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Deserialize(reader);
                    value.p.Add(value_p_i);
                }
                value.q = reader.ReadBytes(reader.ReadLength());
                value.r = new Nino.Test.NotIncludeAllClass[reader.ReadLength()];
                for(int i = 0, cnt = value.r.Length; i < cnt; i++)
                {
                    var value_r_i = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Deserialize(reader);
                    value.r[i] = value_r_i;
                }
                var value_s_len = reader.ReadLength();
                value.s = new System.Collections.Generic.Dictionary<System.String,Nino.Test.NotIncludeAllClass>(value_s_len);
                for(int i = 0; i < value_s_len; i++)
                {
                    var value_s_key = reader.ReadString();
                    var value_s_val = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Deserialize(reader);
                    value.s[value_s_key] = value_s_val;
                }
                var value_t_len = reader.ReadLength();
                value.t = new System.Collections.Generic.Dictionary<Nino.Test.NotIncludeAllClass,System.Int32>(value_t_len);
                for(int i = 0; i < value_t_len; i++)
                {
                    var value_t_key = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Deserialize(reader);
                    var value_t_val = reader.DecompressAndReadNumber<System.Int32>();
                    value.t[value_t_key] = value_t_val;
                }
                var value_u_len = reader.ReadLength();
                value.u = new System.Collections.Generic.Dictionary<System.String,System.Int32>(value_u_len);
                for(int i = 0; i < value_u_len; i++)
                {
                    var value_u_key = reader.ReadString();
                    var value_u_val = reader.DecompressAndReadNumber<System.Int32>();
                    value.u[value_u_key] = value_u_val;
                }
                var value_v_len = reader.ReadLength();
                value.v = new System.Collections.Generic.Dictionary<Nino.Test.NotIncludeAllClass,Nino.Test.NotIncludeAllClass>(value_v_len);
                for(int i = 0; i < value_v_len; i++)
                {
                    var value_v_key = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Deserialize(reader);
                    var value_v_val = Nino.Test.NotIncludeAllClass.NinoSerializationHelper.Deserialize(reader);
                    value.v[value_v_key] = value_v_val;
                }
                return value;
            }
            #endregion
        }
    }
}