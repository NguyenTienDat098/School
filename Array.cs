using Mathss;
namespace Arrayss{
  class Arrays{
    // HAM NHAP MANG SO NGUYEN
    public void NhapMangSoNguyen(ref int[] arr, int length){
      for(int i=0;i<length;i++){
        Console.Write($"Nhap vao phan tu thu {i}: ");
        int.TryParse(Console.ReadLine(), out arr[i]);
      }
    }
    // HAM XUAT MANG SO NGUYEN
    public void XuatMang(ref int[] arr){
      Console.WriteLine("Cac phan tu cua mang la: ");
      for(int i=0;i<arr.Length;i++){
        Console.Write(arr[i] + " "); 
      }
    }
    // HAM SAP XEP MANG TANG DAN
    public void SapXepMangTangDan(ref int[] arr){
      for(int i=0;i<arr.Length;i++){
        for(int j=i+1;j<arr.Length;j++){
          if(arr[j] < arr[i]){
            new Maths().HoanViTri(ref arr[i], ref arr[j]);
          }
        }
      }
    }
    // SAP XEP MANG GIAM DAN 
    public void SapXepMangGiamDan(ref int[] arr){
       for(int i=0;i<arr.Length;i++){
        for(int j=i+1;j<arr.Length;j++){
          if(arr[j] > arr[i]){
            new Maths().HoanViTri(ref arr[i], ref arr[j]);
          }
        }
      }
    }
    // CHEN THEM PHAN TU VAO VI TRI X TRONG MANG
    public void ChenPhanTu(ref int[] arr, int positionAdd,int x){
      if(positionAdd < arr.Length && positionAdd <= 0){
       Array.Resize<int>(ref arr, arr.Length + 1);
       for(int i=arr.Length-1;i>=positionAdd;i++){
         arr[i] = arr[i - 1];
       }
       arr[positionAdd] = x;
      }
    }
    // XOA MOT PHAN TU TAI VI TRI X TRONG MANG
    public void XoaPhanTu(ref int[] arr, int positionDel){
      if(positionDel >= 0 && positionDel < arr.Length){
        for(int i=positionDel;i<arr.Length - 1;i++){
          arr[i] = arr[i + 1];
        }
        Array.Resize<int>(ref arr, arr.Length - 1);
      }
    }
    // TIM VI TRI CUA PHAN TU X DAU TIEN TRONG MANG
    public int TimViTriDauTienCuaPhanTu(ref int[] arr, int x){
      for(int i=0;i<arr.Length;i++){
        if(arr[i] == x){
          return i;
        }
      }
      return -1;
    }
  }
}
