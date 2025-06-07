# View -> ViewModel -> Model
View (TextBox etc.)
     ↓
ViewModel.PersonName（set）
     ↓
Model.Name に代入


# Model -> ViewModel -> View
Model.Name に値をセット（ Model 内部または外部から）
     ↓（ PropertyChanged イベント発火）
ViewModel のイベントハンドラで検知
     ↓
RaisePropertyChanged("PersonName")
     ↓
View の TextBlock.Text に変更が反映
