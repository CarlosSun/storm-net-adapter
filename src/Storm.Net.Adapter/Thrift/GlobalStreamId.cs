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
public partial class GlobalStreamId : TBase
{

  public string ComponentId { get; set; }

  public string StreamId { get; set; }

  public GlobalStreamId() {
  }

  public GlobalStreamId(string componentId, string streamId) : this() {
    this.ComponentId = componentId;
    this.StreamId = streamId;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_componentId = false;
    bool isset_streamId = false;
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
          if (field.Type == TType.String) {
            ComponentId = iprot.ReadString();
            isset_componentId = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            StreamId = iprot.ReadString();
            isset_streamId = true;
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
    if (!isset_componentId)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_streamId)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("GlobalStreamId");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "componentId";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(ComponentId);
    oprot.WriteFieldEnd();
    field.Name = "streamId";
    field.Type = TType.String;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(StreamId);
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("GlobalStreamId(");
    __sb.Append(", ComponentId: ");
    __sb.Append(ComponentId);
    __sb.Append(", StreamId: ");
    __sb.Append(StreamId);
    __sb.Append(")");
    return __sb.ToString();
  }

}

