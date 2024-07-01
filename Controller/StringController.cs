using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppSource.Contracts;
using WinFormsAppSource.Model;

namespace WinFormsAppSource.Controller
{
    public class StringController
    {
        private readonly StringModel model;
        private readonly Form1 view;
        public StringController(StringModel model, Form1 view) 
        {
            this.model = model;
            this.view = view;
            this.view.SortButtonClicked += OnSortButtonClicked;
        }


        private void OnSortButtonClicked(object sender, EventArgs e)
        {
            model.Input = view.InputString;

            ISortStrategy sortStrategy;
            switch (view.SelectedStrategy)
            {
                case "BubbleSort":
                    sortStrategy = new BubbleSort();
                    break;
                case "QuickSort":
                    sortStrategy = new QuickSort();
                    break;
                case "MergeSort":
                    sortStrategy = new MergeSort();
                    break;
                default:
                    throw new InvalidOperationException("Unknown sorting strategy");
            }

            model.Sorted = sortStrategy.Sort(model.Input);
            view.SetSortedString(model.Sorted);
        }

    }
}
