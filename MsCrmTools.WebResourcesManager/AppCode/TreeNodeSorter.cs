﻿using System;
using System.Collections;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.AppCode
{
    // Create a node sorter that implements the IComparer interface.
    public class NodeSorter : IComparer
    {
        // Compare the length of the strings, or the strings
        // themselves, if they are the same length.
        public int Compare(object x, object y)
        {
            var tx = x as TreeNode;
            var ty = y as TreeNode;

            if (tx != null && ty != null)
            {
                if (tx.ImageIndex == ty.ImageIndex)
                {
                    return String.CompareOrdinal(tx.Text.ToLower(), ty.Text.ToLower());
                }

                if (tx.ImageIndex == 0)
                {
                    return -1;
                }

                if (tx.ImageIndex == 1 && tx.ImageIndex < ty.ImageIndex)
                {
                    return -1;
                }

                if (ty.ImageIndex == 1 && ty.ImageIndex < tx.ImageIndex)
                {
                    return 1;
                }

                return String.CompareOrdinal(tx.Text.ToLower(), ty.Text.ToLower());
            }

            return 0;
        }
    }
}