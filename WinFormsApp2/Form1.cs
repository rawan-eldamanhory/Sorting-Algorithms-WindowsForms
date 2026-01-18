namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x;
        int[] a;
        int i = 0;

        //bucket sort
        public void bucketSort(int[] arr, int n)
        {
            if (a.Length <= 0)
                return;

            // 1) Create n empty buckets
            List<float>[] buckets = new List<float>[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                buckets[i] = new List<float>();
            }

            // 2) Put array elements in different buckets
            for (int i = 0; i < a.Length; i++)
            {
                float idx = a[i] * a.Length;
                buckets[(int)idx].Add(a[i]);
            }

            // 3) Sort individual buckets
            for (int i = 0; i < a.Length; i++)
            {
                buckets[i].Sort();
            }

            // 4) Concatenate all buckets into a[]
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    a[index++] = (int)buckets[i][j];
                }
            }
        }
        

        //Quick Sort
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        private static void Bucketsort(int[] a)
        {
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[min_idx])
                    {
                        min_idx = j;
                    }

                int temp = a[min_idx];
                a[min_idx] = a[i];
                a[i] = temp;
            }
        }

        //........................

        /*//bucket sort
        public int[] SortArrayOptimized(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return array;
            }

            int maxValue = array[0];
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            LinkedList<int>[] bucket = new LinkedList<int>[maxValue - minValue + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (bucket[array[i] - minValue] == null)
                {
                    bucket[array[i] - minValue] = new LinkedList<int>();
                }

                bucket[array[i] - minValue].AddLast(array[i]);
            }

            var index = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i] != null)
                {
                    LinkedListNode<int> node = bucket[i].First;

                    while (node != null)
                    {
                        array[index] = node.Value;
                        node = node.Next;
                        index++;
                    }
                }
            }

            return array;
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();
            panel15.Hide();
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = " ";
            for (int j = 0; j < a.Length; j++)
            {
                label4.Text += a[j].ToString() + " ,";
            }
            panel11.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox2.Text);
            a = new int[x];

            panel20.Show();

            /*int n = int.Parse(textBox2.Text);
            for (int i = 0; i < n; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("Enter Item {0} : ", i);
                //Position label on screen
                label.Left = 500;
                label.Top = (i + 3) * 70;
                label.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                //Create textbox
                TextBox textBox = new TextBox();
                //Position textbox on screen
                textBox.Left = 700;
                textBox.Top = (i + 3) * 70;
                textBox.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                textBox.ForeColor = Color.Crimson;
                textBox.Name = String.Format("Item{0}", i);
                //Add controls to form
                this.Controls.Add(label);
                this.Controls.Add(textBox);
            }*/
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a[i] = int.Parse(textBox1.Text);
            i++;
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //insertion sort
            int key, j;

            for (int i = 1; i < a.Length; i++)
            {
                key = a[i];
                j = i - 1;

                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;
            }

            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label7.Text += a[i].ToString() + ',';


            panel12.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            //selection sort
            int n = a.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[min_idx])
                    {
                        min_idx = j;
                    }

                int temp = a[min_idx];
                a[min_idx] = a[i];
                a[i] = temp;
            }

            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label8.Text += a[i].ToString() + ',';

            panel13.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //bubble sort
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label10.Text += a[i].ToString() + ',';

            panel14.Show();
        }

        //merge sort
        class Mergesort
        {
            void merge(int[] arr, int l, int m, int r)
            {
                int n1 = m - l + 1;
                int n2 = r - m;

                int[] L = new int[n1];
                int[] R = new int[n2];
                int i, j;

                for (i = 0; i < n1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < n2; ++j)
                    R[j] = arr[m + 1 + j];

                i = 0;
                j = 0;
                int k = l;
                while (i < n1 && j < n2)
                {
                    if (L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }

                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }
            public void sort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    int m = l + (r - l) / 2;

                    sort(arr, l, m);
                    sort(arr, m + 1, r);
                    merge(arr, l, m, r);
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Mergesort ob = new Mergesort();
            ob.sort(a, 0, a.Length - 1);
            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label12.Text += a[i].ToString() + ',';
            panel15.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Quick sort
            Quick_Sort(a, 0, a.Length - 1);
            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label14.Text += a[i].ToString() + ',';

            panel16.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //count sort
            int[] sortedArray = new int[a.Length];
            int minVal = a[0];
            int maxVal = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minVal) minVal = a[i];
                else if (a[i] > maxVal) maxVal = a[i];
            }
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < a.Length; i++)
            {
                counts[a[i] - minVal]++;
            }
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[a[i] - minVal]--] = a[i];
            }
            //display array after sorting
            for (int i = 0; i < sortedArray.Length; i++)
                label16.Text += a[i].ToString() + ',';

            panel17.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //bucket sort
            Bucketsort(a);
            
            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label18.Text += a[i].ToString() + ',';

            panel18.Show();
        }

        //radix sort
        class radix
        {
            public static int getMax(int[] arr, int n)
            {
                int mx = arr[0];
                for (int i = 1; i < n; i++)
                    if (arr[i] > mx)
                        mx = arr[i];
                return mx;
            }


            public void countSort(int[] arr, int n, int exp)
            {
                int[] output = new int[n];
                int i;
                int[] count = new int[10];


                for (i = 0; i < 10; i++)
                    count[i] = 0;

                for (i = 0; i < n; i++)
                    count[(arr[i] / exp) % 10]++;

                for (i = 1; i < 10; i++)
                    count[i] += count[i - 1];

                for (i = n - 1; i >= 0; i--)
                {
                    output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                    count[(arr[i] / exp) % 10]--;
                }

                for (i = 0; i < n; i++)
                    arr[i] = output[i];
            }

            public void radixsort(int[] arr, int n)
            {
                int m = getMax(arr, n);

                for (int exp = 1; m / exp > 0; exp *= 10)
                    countSort(arr, n, exp);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            //radix sort
            radix oo = new radix();
            oo.radixsort(a, a.Length);
            //display array after sorting
            for (int i = 0; i < a.Length; i++)
                label20.Text += a[i].ToString() + ',';
            panel19.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InsertionSort f1 = new InsertionSort();
            f1.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SelectionSort f1 = new SelectionSort();
            f1.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BubbleSort f1 = new BubbleSort();
            f1.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MergeSort f1 = new MergeSort();
            f1.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            QuickSort f1 = new QuickSort();
            f1.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CountSort f1 = new CountSort();
            f1.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            BucketSort f1 = new BucketSort();
            f1.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            RadixSort f1 = new RadixSort();
            f1.Show();
        }

       
    }
}