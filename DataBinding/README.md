# View -> ViewModel -> Model
View (TextBox etc.)<br>
     ↓<br>
ViewModel.PersonName（set）<br>
     ↓<br>
Model.Name に代入<br>


# Model -> ViewModel -> View
Model.Name に値をセット（ Model 内部または外部から）<br>
     ↓（ PropertyChanged イベント発火）<br>
ViewModel のイベントハンドラで検知<br>
     ↓<br>
RaisePropertyChanged("PersonName")<br>
     ↓<br>
View の TextBlock.Text に変更が反映<br>
