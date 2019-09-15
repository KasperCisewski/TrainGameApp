import styled from 'styled-components';

interface ButtonWrapperPropsI {
	margin?: string
	padding?: string
	width?: string
}

export const ButtonWrapper = styled.button<ButtonWrapperPropsI>`
	border: none;
	background: ${props => props.theme.orange};
	border-radius: 2px;
	transition: .125s;
	font-family: inherit;
	font-size: 20px;
	margin: ${props => props.margin || '8px 0'};
	padding: ${props => props.padding || '3px 15px'};
	width: ${props => props.width || 'auto'};
	color: ${props => props.theme.white};
	letter-spacing: 2px;
	&:hover {
		transform: scale(1.1);
	}
`;