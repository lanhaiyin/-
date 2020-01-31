
#include <iostream>

using namespace std;


class Rectangle
{
    public:
        Rectangle();
        virtual ~Rectangle();
        void SetLength(int length){this->itsLength=length;}
        int GetLength()const {return this->itsLength;}
        void SetWidth(int width){itsWidth=width;}
        int GetWidth()const{return itsWidth;}



    private:
        int itsLength;
        int itsWidth;

};

Rectangle::Rectangle()
{
      itsLength=10;
      itsWidth=5;
}

Rectangle::~Rectangle()
{
    //dtor
}
int main()
{
    Rectangle *pRect=new Rectangle;
    const Rectangle *pConstRect=new Rectangle;//不能修改pConstRect指向的值
    Rectangle *const pConstptr=new Rectangle;//pConstRect不能指向其他变量

 cout<<"Length  :"<<pConstRect->GetLength()<<endl;
    cout<<"Width1  :"<<pRect->GetWidth()<<endl;
    cout<<"Width2  :"<<pConstRect->GetWidth()<<endl;
    cout<<"Width3  :"<<pConstptr->GetWidth()<<endl;
    cout<<"Width3  :"<<pConstptr->GetLength()<<endl;

    //修改
  pRect->SetWidth(10);
  pConstptr->SetWidth(20);
 // pConstRect->SetWidth(10);

    cout<<"new Width1  :"<<pRect->GetWidth()<<endl;
    cout<<"new Width2  :"<<pConstRect->GetWidth()<<endl;
    cout<<"new Width3  :"<<pConstptr->GetWidth()<<endl;

}
