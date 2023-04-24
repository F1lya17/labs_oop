#include<iostream>

using namespace std;

struct Point {
    Point() : x(0), y(0) {};
    Point(float x, float y) : x(x), y(y) {};
    float x, y;
};

class Quadrilateral {
protected:
    Point p1, p2, p3, p4;
    float AB, BC, CD, DA, AC, BD;
public:
    Quadrilateral() {}
    Quadrilateral(const Point& p1, const Point& p2, const Point& p3, const Point& p4) {
        this->p1.x = p1.x; this->p1.y = p1.y;
        this->p2.x = p2.x; this->p2.y = p2.y;
        this->p3.x = p3.x; this->p3.y = p3.y;
        this->p4.x = p4.x; this->p4.y = p4.y;

        this->AB = CoordToLine(this->p1, this->p2);
        this->BC = CoordToLine(this->p2, this->p3);
        this->CD = CoordToLine(this->p3, this->p4);
        this->DA = CoordToLine(this->p4, this->p1);
        this->AC = CoordToLine(this->p1, this->p3);
        this->BD = CoordToLine(this->p2, this->p4);
    }
    virtual ~Quadrilateral() { cout << "~Quadrilateral\n"; }

    virtual string classname() {
        return "Quadrilateral";
    }

    void nameOfFigure1() {
        cout << FigureName1() << endl;
    }

    void nameOfFigure2() {
        cout << classname() << endl;
    }

    string FigureName1() {
        return "Quadrilateral";
    }

    float CoordToLine(const Point& p1, const Point& p2) {
        return sqrt(fabs(p1.x - p2.x) * fabs(p1.x - p2.x) + fabs(p1.y - p2.y) * fabs(p1.y - p2.y));
    }

    float GeronFunc(const float& a, const float& b, const float& c) {
        float p = (a + b + c) / 2;
        return sqrt(p * (p - a) * (p - b) * (p - c));
    }

    virtual void Area() {
        cout << "Area of a quadrilateral:" << GeronFunc(AB, BC, AC) + GeronFunc(CD, DA, AC) << '\n';
    }
};

class Parallelogram : public Quadrilateral {
public:
    Parallelogram() {}
    Parallelogram(const Point& p1, const Point& p2, const Point& p3, const Point& p4) : Quadrilateral(p1, p2, p3, p4) {}
    
    virtual ~Parallelogram() { cout << "~Parallelogram\n"; }

    string classname() override {
        return "Parallelogram";
    }

    string FigureName1() {
        return "Parallelogram";
    }

    void Area() override {
        float S = 0.5 * (fabs(p2.y - p1.y)) * (fabs(p1.x - p4.x));
        cout << "Area of a parallelogram: " << S << '\n';
    }

    void isParallelogram() {
        if ((CoordToLine(p1, p2) == CoordToLine(p3, p4)) && (CoordToLine(p2, p3) == CoordToLine(p4, p1))) {
            cout << "This quadrilateral is a parallelogram" << '\n';
        }
        else {
            cout << "This quadrilateral is not a parallelogram" << '\n';
        }
    }
};

int main() {
    //Quadrilateral* q1 = new  Parallelogram();
    //delete q1;

    //Quadrilateral* q1 = new Parallelogram();//new Quadrilateral(); Parallelogram* q1 = new  Parallelogram();
    //q1->nameOfFigure1();

    Quadrilateral* q2 = new Parallelogram();//new Quadrilateral(); Parallelogram* q1 = new  Parallelogram();
    q2->nameOfFigure2();

    //Quadrilateral* q3 = new Quadrilateral();
    //Parallelogram* q4 = new Parallelogram();
    //Quadrilateral* q5 = new Parallelogram();
    //cout << q3->FigureName1() << endl;
    //cout << q4->FigureName1() << endl;
    //cout << q5->FigureName1() << endl << endl;


    //Quadrilateral* q6 = new Quadrilateral();
    //Parallelogram* q7 = new Parallelogram();
    //Quadrilateral* q8 = new Parallelogram();
    //q6->Area();
    //q7->Area();
    //q8->Area();
}