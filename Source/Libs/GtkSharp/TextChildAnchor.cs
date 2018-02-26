// TextChildAnchor.cs - customizations to Gtk.TextChildAnchor
//
// Authors: Mike Kestner  <mkestner@ximian.com>
//
// Copyright (c) 2004 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

	public partial class TextChildAnchor {

		delegate IntPtr d_gtk_text_child_anchor_get_widgets(IntPtr raw);
		static d_gtk_text_child_anchor_get_widgets gtk_text_child_anchor_get_widgets = FuncLoader.LoadFunction<d_gtk_text_child_anchor_get_widgets>(FuncLoader.GetProcAddress(GLibrary.Load(Library.Gtk), "gtk_text_child_anchor_get_widgets"));

		public Widget[] Widgets {
			get {
				IntPtr raw_ret = gtk_text_child_anchor_get_widgets (Handle);
				if (raw_ret == IntPtr.Zero)
					return new Widget [0];
				GLib.List list = new GLib.List(raw_ret);
				Widget[] result = new Widget [list.Count];
				for (int i = 0; i < list.Count; i++)
					result [i] = list [i] as Widget;
				return result;
			}
		}
	}
}
