using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Sorter
{
	class Heap
	{
		Turno[] arr;
		int sizeOfTree;

		public Heap()
		{
			int size = 1;
			arr = new Turno[size + 1];
			sizeOfTree = 0;
			Console.WriteLine("El montículo ha sido creado");
		}

		//Obtener valor raíz del Montículo
		public Turno PeekOfHeap()
		{
			if (sizeOfTree == 0)
				return null;

			else return arr[1];
		}

		//Obteniendo tamaño del Montículo
		public int sizeOfHeap()
		{
			return sizeOfTree;
		}

		public void InsertElementInHeap(Turno value)
		{
			if (sizeOfHeap() < 0)
			{
				Console.WriteLine("El montículo está vacío");
			}
			else
			{
				try
				{
					arr[sizeOfTree + 1] = value;
					Console.WriteLine("El tamaño del montículo es:" + sizeOfTree);
					sizeOfTree++;
					HeapifyBottomToTop(sizeOfTree);
					Console.WriteLine("Se insertó " + value + " en la cola de prioridad");
					levelOrder();
				}

				catch (IndexOutOfRangeException)
				{
					Array.Resize<Turno>(ref arr, arr.Length + 1);
					InsertElementInHeap(value);
				}
			}
		}

		public void HeapifyBottomToTop(int index)
		{
			int parent = index / 2;

			if (index <= 1)
			{
				return;
			}


			if (arr[index].peso < arr[parent].peso)
			{
				Turno tmp = arr[index];
				arr[index] = arr[parent];
				arr[parent] = tmp;
			}
			HeapifyBottomToTop(parent);
		}

		public void levelOrder()
		{
			Console.WriteLine("Imprimiendo los elementos en la cola de prioridad\n");

			for (int i = 1; i <= sizeOfTree; i++)
			{
				Console.Write(arr[i].numero.ToString() + " ");
			}
			Console.WriteLine("\n");
		}

		//Extract head of heap
		public Turno extractHeadOfHeap()
		{
			if (sizeOfTree == 0)
			{
				Console.WriteLine("El montículo está vacío");
				return null;
			}
			else
			{
				Console.WriteLine("La cabeza del montículo es: " + arr[1].numero);
				Console.WriteLine("Extrayéndola...");
				Turno extractedValue = arr[1];
				arr[1] = arr[sizeOfTree];
				sizeOfTree--;
				HeapifyTopToBottom(1);
				Console.WriteLine("Valor extraído del montículo!");
				levelOrder();
				return extractedValue;
			}
		}

		public void HeapifyTopToBottom(int index)
		{
			int left = index * 2;
			int right = (index * 2) + 1;
			int smallestChild = 0;

			if (sizeOfTree < left)
			{
				return;
			}

			else if (sizeOfTree == left)
			{
				if (arr[index].peso > arr[left].peso)
				{
					Turno tmp = arr[index];
					arr[index] = arr[left];
					arr[left] = tmp;
				}
				return;
			}
			else
			{
				if (arr[left].peso < arr[right].peso)
				{
					smallestChild = left;
				}
				else
				{
					smallestChild = right;
				}
				if (arr[index].peso > arr[smallestChild].peso)
				{
					Turno tmp = arr[index];
					arr[index] = arr[smallestChild];
					arr[smallestChild] = tmp;
				}
			}
			HeapifyTopToBottom(smallestChild);
		}
	}
}
