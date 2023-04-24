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
	virtual string classname() {
		return "Animal";
	}
	virtual bool isA(const string& who) {
		return who == "Animal";
	}
	virtual void catchDog() {
		cout << "Dog is not catched" << endl;
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
	string classname() override {
		return "Cat";
	}
	bool isA(const string& who) override {
		return (who == "Cat") || (Animal::isA(who));
	}
};

class Dog : public Animal {
public:
	void sound() override {
		cout << "Wow-wow" << endl;
	}
	void catchCat() {
		cout << "Cat is catched" << endl;
	}
	string classname() override {
		return "Dog";
	}
	bool isA(const string& who) override {
		return (who == "Dog") || (Animal::isA(who));
	}
};

class Wolf : public Dog {
public:
	void sound() override {
		cout << "Wooooo" << endl;
	}
	void catchDog() {
		cout << "Dog is catched" << endl;
	}
	string classname() override {
		return "Wolf";
	}
	bool isA(const string& who) override {
		return (who == "Wolf") || (Dog::isA(who));
	}
};


int main() {
	srand(time(NULL));

	const int animals_count = 10;
	Animal* zoo[animals_count];

	for (int i = 0; i < animals_count; i++) {
		int a = rand() % 3;
		if (a == 0) {
			zoo[i] = new Cat();
		}
		else if (a == 1) {
			zoo[i] = new Dog();
		}
		else {
			zoo[i] = new Wolf();
		}
	}

	for (int i = 0; i < animals_count; i++) {
		//if ((zoo[i]->classname() == "Dog") || (zoo[i]->classname() == "Wolf")) {
		//	//((Dog*)zoo[i])->catchCat();
		//	static_cast<Dog*>(zoo[i])->catchCat();
		//}

		if (zoo[i]->isA("Dog")) {
			static_cast<Dog*>(zoo[i])->sound();
		}
		
		zoo[i]->catchDog();
		/*Wolf* alpha = dynamic_cast<Wolf*>(zoo[i]);
		if (alpha != nullptr) {
			alpha->catchDog();
		}*/
	}

}