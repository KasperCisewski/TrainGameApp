import styled from 'styled-components';

const transitionTime = '.125s';

interface BottomBarWrapperProps {
	visible?: boolean
}

export const BottomBarWrapper = styled.div<BottomBarWrapperProps>`
	position: fixed;
	bottom: 0;
	height: calc(10vh + 4px;);
	width: 100%;
	background: ${props => props.theme.ligthblue};
	left: 0;
	display: flex;
	justify-content: space-around;
	border-top: 4px solid ${props => props.theme.darkblue};
`;

interface BottomBarItemProps {
	selected: boolean
}

export const BottomBarItem = styled.div<BottomBarItemProps>`
	background: ${props => props.theme.ligthblue};
	border-radius: ${props => props.selected && '9999px'};
	border: ${props => props.selected && `4px solid ${props.theme.darkblue}`};
	transform: ${props => props.selected && 'translateY(-5vh)'};
	display: flex;
	flex-direction: column;
	align-items: center;
	justify-content: center;
	width: 10vh;
	height: 10vh;
	transition: ${transitionTime};
	position: relative;
	color: ${props => props.theme.white};
	
	& > div {
		position: absolute;
		height: 5vh;
		width: 10vh;	
		bottom: -4px;
		background: ${props => props.theme.ligthblue};
		z-index: -1;
	}
	
	& > img {
		width: 32px;
		height: auto;
	}
	
	& > img, & > span {
		transition: ${transitionTime};
		transform: ${props => props.selected && 'translateY(8px)'};
	}
	
	& > span {
		letter-spacing: ${props => props.selected && '2px'};
	}
`;