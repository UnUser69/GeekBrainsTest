/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
обойтись исключительно массивами.*/

string [] arr1 = {"Hello", "2", "world", ":-)"}; 
string [] arr2 = {"1234", "1567", "-2", "computer science"}; 
string [] arr3 = {"Russia", "Denmark", "Kazan"};
string [] resultArr = new string[0];

void CreateNewArray(string[] array){
	int newLengthOfArray = new Random().Next(3);
	resultArr = new string[newLengthOfArray];
	int counter = 0;
	for(int i=0; i<newLengthOfArray; i++ ){
					resultArr[counter] = array[new Random().Next(array.Length)];
					counter++;
	}
}


void PrintArray(string[] array){
    if(array.Length == 0){
				Console.Write("!!!Array is empty!!!");
			}
			else{
                int count = 0;
				for(int i = 0; i<array.Length; i++){
					Console.Write($"{array[count]} ");
					count++;				
				}
			}
Console.WriteLine();    
}

void ProgramPlay(string[] array){
	Console.Write("Initial array: "); 
	PrintArray(array);
	CreateNewArray(array);
	Console.WriteLine("A new array of strings that are less than or equal to 3 characters long: "); 
	PrintArray(resultArr);
	Console.WriteLine();
}

ProgramPlay(arr1);
ProgramPlay(arr2);
ProgramPlay(arr3);