﻿#nullable   enable

using System.Xml.Serialization;

namespace Shared
{
    /*
      *  <Message type='Request' action='HeartBeat' id='0001'>
      *    <POS id='POS_001'/>
      *  </Message>
      * 
      * <Message type='Response' action='HeartBeat' id='0001'>
      *   <POS id='POS_001'/> 
      *   <Result status='Success'/>
      * </Message>
      * 
      */

    public enum MessageType
    {
        Request,
        Response
    }

    public enum Status
    {
        Success,
        Failure
    }

    [XmlRoot( "Message" )]
    public abstract class Message
    {
        [XmlAttribute( "id" )]
        public string? Id { get; set; }

        [XmlAttribute( "type" )]
        public MessageType Type { get; set; }

        [XmlAttribute( "action" )]
        public string? Action { get; set; }
    }

    public class POSData
    {
        [XmlAttribute( "id" )]
        public string? Id { get; set; }
    }

    public class Result
    {
        [XmlAttribute( "status" )]
        public Status Status { get; set; }
    }
}
