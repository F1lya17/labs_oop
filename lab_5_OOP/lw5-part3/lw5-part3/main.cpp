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
		cout << "work" << endl;
	}
	~Base() {
		cout << "Base destuctor" << endl;
	}
};

unique_ptr<Base> pass_object(unique_ptr<Base> p)
{
	p->out();
	return move(p);
}

shared_ptr<Base> pass_object(shared_ptr<Base> p)
{
	p->out();
	return p;
}

int main() {

	unique_ptr<Base> up1 = make_unique<Base >(1, 2);
	shared_ptr<Base> sp1 = make_unique<Base >(1, 2);

	unique_ptr<Base>up2 = move(up1); //ошибка

	up1 = pass_object(move(up1));

	sp1 = pass_object(sp1);
	shared_ptr<Base> sp2 = sp1;
	sp2->out();
}