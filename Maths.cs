namespace Mathss{
class Maths{
  // HAM HOAN HAI SO NGUYEN 
  public void HoanViTri(ref int a, ref int b){
    int temp = a;
    a = b;
    b = temp;
  }
  // HAM KIEM TRA SO NGUYEN TO
  public bool KiemTraSoNguyenTo(int number){
    if(number == 1){
      return false;
    }
    for(int i=2;i<number;i++){
      if(number % i == 0){
        return false;
      }
    }
    return true;
  }
  // HAM KIEM TRA SO HOAN HAO
  public bool KiemTraSoHoanHao(int number){
    int total = 0;
    for(int i=1;i<number;i++){
      if(number % i == 0){
        total += i;
      }
    }
    if(total == number){
      return true;
    }
    return false;
  }
  // HAM KIEM TRA SO CHINH PHUONG
  public bool KiemTraSoChinhPhuong(int number){
    for(int i=1;i<number;i++){
      if(i * i == number){
       return true;
      }
    }
    return false;
  }
  // HAM KIEM TRA SO CHAN 
  public bool KiemTraSoChan(int number){
     if(number % 2 == 0){
       return true;
     }
    return false;
  }
  // HAM KIEM TRA SO LE
  public bool KiemTraSoLe(int number){
     if(number % 2 == 0){
       return false;
     }
    return true;
  }
 }
}
