using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DijkstraGUI
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Dictionary<string, int>> graph;

        public MainForm()
        {
            InitializeComponent();
            graph = new Dictionary<string, Dictionary<string, int>>();
        }

        private void AddEdge(string source, string destination, int weight)
        {
            if (!graph.ContainsKey(source))
                graph[source] = new Dictionary<string, int>();

            graph[source][destination] = weight;
        }

        private List<string> Dijkstra(string startNode, string endNode)
        {
            var distance = new Dictionary<string, int>();
            var previousNode = new Dictionary<string, string>();
            var queue = new List<string>();

            foreach (var node in graph.Keys)
            {
                distance[node] = int.MaxValue;
                previousNode[node] = null;
                queue.Add(node);
            }

            distance[startNode] = 0;

            while (queue.Count > 0)
            {
                string currentNode = null;
                int minDistance = int.MaxValue;

                foreach (var node in queue)
                {
                    if (distance[node] < minDistance)
                    {
                        currentNode = node;
                        minDistance = distance[node];
                    }
                }

                queue.Remove(currentNode);

                if (currentNode == endNode)
                    break;

                if (graph.ContainsKey(currentNode))
                {
                    foreach (var neighbor in graph[currentNode])
                    {
                        int altDistance = distance[currentNode] + neighbor.Value;
                        if (altDistance < distance[neighbor.Key])
                        {
                            distance[neighbor.Key] = altDistance;
                            previousNode[neighbor.Key] = currentNode;
                        }
                    }
                }
            }

            var path = new List<string>();
            string current = endNode;

            while (current != null)
            {
                path.Insert(0, current);
                current = previousNode[current];
            }

            return path;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string startNode = startNodeTextBox.Text;
            string endNode = endNodeTextBox.Text;

            if (!graph.ContainsKey(startNode) || !graph.ContainsKey(endNode))
            {
                MessageBox.Show("Titik awal atau akhir tidak valid!");
                return;
            }

            List<string> shortestPath = Dijkstra(startNode, endNode);

            resultTextBox.Clear();

            if (shortestPath.Count > 0)
            {
                resultTextBox.AppendText("Jalur terpendek dari " + startNode + " ke " + endNode + " adalah: " + Environment.NewLine);
                resultTextBox.AppendText(string.Join(" -> ", shortestPath) + Environment.NewLine);
                resultTextBox.AppendText("Jarak total: " + CalculateTotalDistance(shortestPath) + Environment.NewLine);
            }
            else
            {
                resultTextBox.AppendText("Tidak ada jalur yang tersedia dari " + startNode + " ke " + endNode + Environment.NewLine);
            }
        }

        private int CalculateTotalDistance(List<string> path)
        {
            int totalDistance = 0;

            for (int i = 0; i < path.Count - 1; i++)
            {
                totalDistance += graph[path[i]][path[i + 1]];
            }

            return totalDistance;
        }

        private void addEdgeButton_Click(object sender, EventArgs e)
        {
            string source = sourceNodeTextBox.Text;
            string destination = destinationNodeTextBox.Text;
            int weight;

            if (!int.TryParse(weightTextBox.Text, out weight))
            {
                MessageBox.Show("Bobot harus berupa angka!");
                return;
            }

            AddEdge(source, destination, weight);
            AddEdge(destination, source, weight);

            sourceNodeTextBox.Clear();
            destinationNodeTextBox.Clear();
            weightTextBox.Clear();

            resultTextBox.AppendText("Tepian baru ditambahkan: " + source + " -> " + destination + " (Bobot: " + weight + ")" + Environment.NewLine);
        }
    }
}
