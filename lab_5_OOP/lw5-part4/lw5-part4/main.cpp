#include<iostream>
#include<ctime>

using namespace std;

class Animal {
private:
	string name;
public:
	virtual void sound() {
		cout << endl;
	}

	virtual ~Animal() { cout << "~Animal" << endl; }

	void nameOfAnimal1() {
		cout << AnimalName1() << endl;
	}

	void nameOfAnimal2() {
		cout << AnimalName2() << endl;
	}

	void method1() {
		cout << "Animal works" << endl;
	}

	string AnimalName1() {
		return "Animal";
	}

	virtual string AnimalName2() {
		return "Animal";
	}
};

class Cat : public Animal {
public:
	void sound() override {
		cout << "Meow" << endl;
	}
	void catchMouse() {
		cout << "Mouse is catched" << endl;
	}

	virtual ~Cat() { cout << "~Cat" << endl; }

	void method1() {
		cout << "Cat works" << endl;
	}

	string AnimalName1() {
		return "Cat";
	}

	string AnimalName2() {
		return "Cat";
	}
};

int main() {
	Cat* cat1 = new Cat();
	Animal* animal1 = new Cat();

	//cat1->nameOfAnimal1();
	//cat1->nameOfAnimal2();

	//animal1->method1();
	//cat1->method1();

	delete animal1;
	delete cat1;
}