#include <iostream>

using namespace std;

class Base {
private:
	int x;
	int y;
public:
	Base() : x(0), y(0) {
		cout << "Empty Base constructor" << endl;
	}
	Base(int x, int y) : x(x), y(y) {
		cout << "Base constructor with params" << endl;
	}
	Base(const Base& t) : x(t.x), y(t.y) {
		cout << "Base copy ref constructor" << endl;
	}
	Base(const Base* t) : x(t->x), y(t->y) {
		cout << "Base copy pointer constructor" << endl;
	}
	void out() {
		cout << "work";
	}
	~Base() {
		cout << "Base destuctor" << endl;
	}
};

class Desc : public Base {
private:
	int z;
public:
	Desc() : Base(), z(0) {
		cout << "Empty Desc constructor" << endl;
	}
	Desc(int x, int y, int z) : Base(x, y), z(z) {
		cout << "Desc constructor with params" << endl;
	}
	Desc(const Desc& t) : Base(t), z(t.z) {
		cout << "Desc copy ref constructor" << endl;
	}
	Desc(const Desc* t) : Base(t), z(t->z) {
		cout << "Desc copy pointer constructor" << endl;
	}
	void print(const string& str) {
		cout << str << endl;
	}
	~Desc() {
		cout << "Desc destuctor" << endl;
	}
};

Base function1() {
	Base bs;
	return bs;
}

Base* function2() {
	Base bs;
	return &bs;
}

Base& function3() {
	Base bs;
	return bs;
}

Base function4() {
	Base* bs = new Base();
	return *bs;
}

Base* function5() {
	Base* bs = new Base();
	return bs;
}

Base& function6() {
	Base* bs = new Base();
	return *bs;
}

void func1(Base bs) {
	static_cast<Desc&>(bs).print("func1");
}

void func2(Base* bs) {
	static_cast<Desc*>(bs)->print("func2");
}

void func3(Base& bs) {
	static_cast<Desc&>(bs).print("func3");
}

int main() {
	//Base* bs0 = new Base();
	//Desc* dc0 = new Desc();

	//func1(*bs0); //новый объект
	//func2(bs0);
	//func3(*bs0);

	//func1(*dc0); //новый объект
	//func2(dc0);
	//func3(*dc0);

	//Base bs1 = function1();

	//Base* bs2 = function2();
	//delete bs2;

	//Base& bs3 = function3();

	//Base bs4 = function4();

	//Base* bs5 = function5();
	//delete bs5;

	//Base& bs6 = function6();
	//delete& bs6;

	//delete bs0;
	//delete dc0;
}