﻿/*
 * Copyright 2019 - 2020 akshay nikhare
 * 
 * This file is part of PDFStamperBinder.
 *
 * PDFStamperBinder is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.

 * PDFStamperBinder is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with PDFStamperBinder.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

namespace PDFStamperBinder
{
    public class ProcessLinker
    {
        IChannel channel;

        public bool IsServer
        {
            get { return channel is IpcServerChannel; }
        }

        public ProcessLinker()
        {
            try
            {
                channel = new IpcServerChannel("PDFStamperBinder");
                ChannelServices.RegisterChannel(channel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(IpcInterface), "files", WellKnownObjectMode.Singleton);
            }
            catch (RemotingException)
            {
                channel = new IpcClientChannel();
                ChannelServices.RegisterChannel(channel, true);
                RemotingConfiguration.RegisterWellKnownClientType(typeof(IpcInterface), "ipc://PDFStamperBinder/files");
            }
        }

        public void SendFileList(params string[] files)
        {
            var ipc = new IpcInterface();
            
            foreach (string file in files)
            {
                ipc.AddInputFile(file);
            }

            ipc.UpdateUI();
        }

        class IpcInterface : MarshalByRefObject
        {
            public void AddInputFile(string path)
            {
                Program.MainForm.AddInputFile(path);
            }

            public void UpdateUI()
            {
                Program.MainForm.UpdateUI();
            }
        }
    }
}
