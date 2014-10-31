async void UpdateClockAsync() {
  while (true) {
    Title = "Title: " + DateTime.Now;
    await TaskEx.Delay(1000);
  }
}
