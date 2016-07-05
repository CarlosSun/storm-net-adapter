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
public partial class ExecutorSummary : TBase
{
  private ExecutorStats _stats;

  public ExecutorInfo Executor_info { get; set; }

  public string Component_id { get; set; }

  public string Host { get; set; }

  public int Port { get; set; }

  public int Uptime_secs { get; set; }

  public ExecutorStats Stats
  {
    get
    {
      return _stats;
    }
    set
    {
      __isset.stats = true;
      this._stats = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool stats;
  }

  public ExecutorSummary() {
  }

  public ExecutorSummary(ExecutorInfo executor_info, string component_id, string host, int port, int uptime_secs) : this() {
    this.Executor_info = executor_info;
    this.Component_id = component_id;
    this.Host = host;
    this.Port = port;
    this.Uptime_secs = uptime_secs;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_executor_info = false;
    bool isset_component_id = false;
    bool isset_host = false;
    bool isset_port = false;
    bool isset_uptime_secs = false;
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
          if (field.Type == TType.Struct) {
            Executor_info = new ExecutorInfo();
            Executor_info.Read(iprot);
            isset_executor_info = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            Component_id = iprot.ReadString();
            isset_component_id = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.String) {
            Host = iprot.ReadString();
            isset_host = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 4:
          if (field.Type == TType.I32) {
            Port = iprot.ReadI32();
            isset_port = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 5:
          if (field.Type == TType.I32) {
            Uptime_secs = iprot.ReadI32();
            isset_uptime_secs = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 7:
          if (field.Type == TType.Struct) {
            Stats = new ExecutorStats();
            Stats.Read(iprot);
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
    if (!isset_executor_info)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_component_id)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_host)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_port)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_uptime_secs)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("ExecutorSummary");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "executor_info";
    field.Type = TType.Struct;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    Executor_info.Write(oprot);
    oprot.WriteFieldEnd();
    field.Name = "component_id";
    field.Type = TType.String;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Component_id);
    oprot.WriteFieldEnd();
    field.Name = "host";
    field.Type = TType.String;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Host);
    oprot.WriteFieldEnd();
    field.Name = "port";
    field.Type = TType.I32;
    field.ID = 4;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Port);
    oprot.WriteFieldEnd();
    field.Name = "uptime_secs";
    field.Type = TType.I32;
    field.ID = 5;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Uptime_secs);
    oprot.WriteFieldEnd();
    if (Stats != null && __isset.stats) {
      field.Name = "stats";
      field.Type = TType.Struct;
      field.ID = 7;
      oprot.WriteFieldBegin(field);
      Stats.Write(oprot);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("ExecutorSummary(");
    __sb.Append(", Executor_info: ");
    __sb.Append(Executor_info== null ? "<null>" : Executor_info.ToString());
    __sb.Append(", Component_id: ");
    __sb.Append(Component_id);
    __sb.Append(", Host: ");
    __sb.Append(Host);
    __sb.Append(", Port: ");
    __sb.Append(Port);
    __sb.Append(", Uptime_secs: ");
    __sb.Append(Uptime_secs);
    if (Stats != null && __isset.stats) {
      __sb.Append(", Stats: ");
      __sb.Append(Stats== null ? "<null>" : Stats.ToString());
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}

