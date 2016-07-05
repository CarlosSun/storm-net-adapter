/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


#if !SILVERLIGHT
[Serializable]
#endif
public partial class SpoutStats : TBase
{

  public Dictionary<string, Dictionary<string, long>> Acked { get; set; }

  public Dictionary<string, Dictionary<string, long>> Failed { get; set; }

  public Dictionary<string, Dictionary<string, double>> Complete_ms_avg { get; set; }

  public SpoutStats() {
  }

  public SpoutStats(Dictionary<string, Dictionary<string, long>> acked, Dictionary<string, Dictionary<string, long>> failed, Dictionary<string, Dictionary<string, double>> complete_ms_avg) : this() {
    this.Acked = acked;
    this.Failed = failed;
    this.Complete_ms_avg = complete_ms_avg;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_acked = false;
    bool isset_failed = false;
    bool isset_complete_ms_avg = false;
    TField field;
    iprot.ReadStructBegin();
    while (true)
    {
      field = iprot.ReadFieldBegin();
      if (field.Type == TType.Stop) { 
        break;
      }
      switch (field.ID)
      {
        case 1:
          if (field.Type == TType.Map) {
            {
              Acked = new Dictionary<string, Dictionary<string, long>>();
              TMap _map95 = iprot.ReadMapBegin();
              for( int _i96 = 0; _i96 < _map95.Count; ++_i96)
              {
                string _key97;
                Dictionary<string, long> _val98;
                _key97 = iprot.ReadString();
                {
                  _val98 = new Dictionary<string, long>();
                  TMap _map99 = iprot.ReadMapBegin();
                  for( int _i100 = 0; _i100 < _map99.Count; ++_i100)
                  {
                    string _key101;
                    long _val102;
                    _key101 = iprot.ReadString();
                    _val102 = iprot.ReadI64();
                    _val98[_key101] = _val102;
                  }
                  iprot.ReadMapEnd();
                }
                Acked[_key97] = _val98;
              }
              iprot.ReadMapEnd();
            }
            isset_acked = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.Map) {
            {
              Failed = new Dictionary<string, Dictionary<string, long>>();
              TMap _map103 = iprot.ReadMapBegin();
              for( int _i104 = 0; _i104 < _map103.Count; ++_i104)
              {
                string _key105;
                Dictionary<string, long> _val106;
                _key105 = iprot.ReadString();
                {
                  _val106 = new Dictionary<string, long>();
                  TMap _map107 = iprot.ReadMapBegin();
                  for( int _i108 = 0; _i108 < _map107.Count; ++_i108)
                  {
                    string _key109;
                    long _val110;
                    _key109 = iprot.ReadString();
                    _val110 = iprot.ReadI64();
                    _val106[_key109] = _val110;
                  }
                  iprot.ReadMapEnd();
                }
                Failed[_key105] = _val106;
              }
              iprot.ReadMapEnd();
            }
            isset_failed = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.Map) {
            {
              Complete_ms_avg = new Dictionary<string, Dictionary<string, double>>();
              TMap _map111 = iprot.ReadMapBegin();
              for( int _i112 = 0; _i112 < _map111.Count; ++_i112)
              {
                string _key113;
                Dictionary<string, double> _val114;
                _key113 = iprot.ReadString();
                {
                  _val114 = new Dictionary<string, double>();
                  TMap _map115 = iprot.ReadMapBegin();
                  for( int _i116 = 0; _i116 < _map115.Count; ++_i116)
                  {
                    string _key117;
                    double _val118;
                    _key117 = iprot.ReadString();
                    _val118 = iprot.ReadDouble();
                    _val114[_key117] = _val118;
                  }
                  iprot.ReadMapEnd();
                }
                Complete_ms_avg[_key113] = _val114;
              }
              iprot.ReadMapEnd();
            }
            isset_complete_ms_avg = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        default: 
          TProtocolUtil.Skip(iprot, field.Type);
          break;
      }
      iprot.ReadFieldEnd();
    }
    iprot.ReadStructEnd();
    if (!isset_acked)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_failed)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_complete_ms_avg)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("SpoutStats");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "acked";
    field.Type = TType.Map;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.Map, Acked.Count));
      foreach (string _iter119 in Acked.Keys)
      {
        oprot.WriteString(_iter119);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.I64, Acked[_iter119].Count));
          foreach (string _iter120 in Acked[_iter119].Keys)
          {
            oprot.WriteString(_iter120);
            oprot.WriteI64(Acked[_iter119][_iter120]);
          }
          oprot.WriteMapEnd();
        }
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "failed";
    field.Type = TType.Map;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.Map, Failed.Count));
      foreach (string _iter121 in Failed.Keys)
      {
        oprot.WriteString(_iter121);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.I64, Failed[_iter121].Count));
          foreach (string _iter122 in Failed[_iter121].Keys)
          {
            oprot.WriteString(_iter122);
            oprot.WriteI64(Failed[_iter121][_iter122]);
          }
          oprot.WriteMapEnd();
        }
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "complete_ms_avg";
    field.Type = TType.Map;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.Map, Complete_ms_avg.Count));
      foreach (string _iter123 in Complete_ms_avg.Keys)
      {
        oprot.WriteString(_iter123);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.Double, Complete_ms_avg[_iter123].Count));
          foreach (string _iter124 in Complete_ms_avg[_iter123].Keys)
          {
            oprot.WriteString(_iter124);
            oprot.WriteDouble(Complete_ms_avg[_iter123][_iter124]);
          }
          oprot.WriteMapEnd();
        }
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("SpoutStats(");
    __sb.Append(", Acked: ");
    __sb.Append(Acked);
    __sb.Append(", Failed: ");
    __sb.Append(Failed);
    __sb.Append(", Complete_ms_avg: ");
    __sb.Append(Complete_ms_avg);
    __sb.Append(")");
    return __sb.ToString();
  }

}

