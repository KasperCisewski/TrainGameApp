import styled from 'styled-components';

interface TopBarWrapperProps {
	backVisible: boolean
}

export const TopBarWrapper = styled.div<TopBarWrapperProps>`
	height: calc(10vh + 3px);
	min-height: 64px;
	width: 100vw;
	position: relative;
	background: ${props => props.theme.white};
	& > img {
		position: absolute;
		height: 5vh;
		top: 50%;
		transform: translateY(-50%);
		left: 8px;
	}
	& > img:last-child {
		left: ${props => props.backVisible && 'initial'};
		right: ${props => props.backVisible && '8px'};
	}
	& > span {
		font-weight: 20px;
		position: absolute;
		top: 50%;
		transform: translateY(-50%);
		right: 8px;
	}
	&:after {
		content: '';
  	position: absolute;
  	left: 0;
  	bottom: 0;
  	height: 0;
  	width: 100%;
  	border-bottom: 1.5px solid #000000;
		border-image: linear-gradient(to right, ${props => props.theme.darkblue}, ${props => props.theme.white});
		border-image-slice: 1;
  	opacity: 0.4;
	}
`;