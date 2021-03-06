﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator_ActionScripts.Enums;

namespace Generator_ActionScripts.ActionCharts.FrameEvents
{
    public class FrameEvent_Speed : FrameEventBase
    {
        public float m_Speed { get; set; }
        public float m_RemainingTime { get; set; }

        public FrameEvent_Speed(BinaryReader br, eActionChart_FrameEvent type) : base(br, type)
        {

        }

        public override void Parse()
        {
            base.Parse();

            m_Speed = bReader.ReadSingle();
            m_RemainingTime = bReader.ReadSingle();
        }

        public override void Write(BinaryWriter bw)
        {
            base.Write(bw);

            bw.Write(m_Speed);
            bw.Write(m_RemainingTime);
        }

        public override void InsertStrings(List<string> stringTable)
        {
            base.InsertStrings(stringTable);
        }
    }
}
