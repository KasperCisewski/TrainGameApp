import React from 'react';
import { Provider } from 'react-redux';
import { BrowserRouter as Router, Route } from "react-router-dom";
import Main from "./views/Main/Main";
import {store} from "./store"
import { ThemeProvider } from 'styled-components';
import theme from './theme/theme.color';
import TopBar from "./common/TopBar";
import Game from "./views/Game/Game";
import BottomBar from "./common/BottomBar";
import Quiz from "./views/Quiz/Quiz";
import Ranking from "./views/Ranking/Ranking";
import WebsocketProvider from "./common/WebsocketProvider";

const App: React.FC = () => {

  return (
  	<WebsocketProvider>
			<ThemeProvider theme={theme}>
				<Provider store={store}>
					<Router>
						<TopBar/>
						<Route path="/" exact component={Main}/>
						<Route path="/game" component={Game}/>
						<Route path="/quiz" component={Quiz}/>
						<Route path="/ranking" component={Ranking}/>
						<BottomBar/>
					</Router>
				</Provider>
			</ThemeProvider>
		</WebsocketProvider>
  );
};

export default App;
