void main() {
  List<int> numbers = [5, 10, 15, 20, 25];
  int count = 0;

  for (int number in numbers) {
    if (number % 2 == 0) {
      count++;
    }
  }

  print("Cift sayilarin sayisi: $count");
}
-----------------------------------------------
void main() {
  Map<String, int> notlar = {'Ali': 4, 'Veli': 6, 'Ahmet': 8};
  int toplam = 0;

  for (int not in notlar.values) {
    toplam += not;
  }

  if (toplam > 10) {
    print("Buyuk");
  } else {
    print("Kucuk");
  }
}
------------------------------------------------
void main() {
  Set<int>  sayiDizisi= {1, 5, 9, 14, 10};

  if (sayiKumesi.contains(10)) {
    print("10 bulundu");
  } else {
    print("10 bulunamadı");
  }
}
