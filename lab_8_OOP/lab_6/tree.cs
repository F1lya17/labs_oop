using lab_6.Figures;
using lab_6.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_6
{
    internal class tree : CObject, CObserver
    {
        internal TreeView treeView;
        List<CObserver> observers;
        public tree(TreeView tree)
        {
            observers = new List<CObserver>();
            treeView = tree;
        }

        public void AddObserver(CObserver obj)
        {
            observers.Add(obj);
        }
        public void notifyEveryone()
        {
            foreach (CObserver obs in observers)
            {
                obs.onSubjectChanged(this);
            }
        }

        public void onSubjectChanged(CObject o)
        {
            treeView.Nodes.Clear();
            figureContainer tmp = (figureContainer)o;
            for (int i = 0; i < tmp.Count; i++)
            {
                TreeNode new_node = new TreeNode(tmp[i].name);
                if (tmp[i].isSelected)
                {
                    new_node.Checked = true;
                    new_node.Expand();
                }
                else
                {
                    new_node.Collapse();
                }
                if (tmp[i].name == "Group")
                {
                    ProcessNode(new_node, tmp[i]);
                }
                treeView.Nodes.Add(new_node);
            }
            // treeView.Refresh();
        }
        public void ProcessNode(TreeNode tr, Figure elem)
        {
            if (elem is FGroup)
            {
                FGroup tmp = elem as FGroup;
                for (int i = 0; i < tmp.figuresGroup.Count; i++)
                {
                    TreeNode new_node = new TreeNode(tmp.figuresGroup[i].name);
                    if (tmp.figuresGroup[i].isSelected)
                    {
                        new_node.Checked = true;
                        new_node.Expand();
                    }
                    else
                    {
                        new_node.Collapse();
                    }
                    if (tmp.figuresGroup[i].name == "Group")
                    {
                        ProcessNode(new_node, tmp.figuresGroup[i]);
                    }
                    tr.Nodes.Add(new_node);
                }
            }
        }
    }
}
